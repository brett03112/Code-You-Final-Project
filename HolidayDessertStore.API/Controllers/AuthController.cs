using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HolidayDessertStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ILogger<AuthController> _logger;

        /// <summary>
        /// Constructor for AuthController.
        /// </summary>
        /// <param name="userManager">User manager for authenticating users.</param>
        /// <param name="configuration">Configuration for application.</param>
        /// <param name="logger">Logger for writing logs.</param>
        public AuthController(
            UserManager<IdentityUser> userManager,
            IConfiguration configuration,
            ILogger<AuthController> logger)
        {
            _userManager = userManager;
            _configuration = configuration;
            _logger = logger;
        }

        public class LoginModel
        {
            public string Email { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
        }

        /// <summary>
        /// /api/auth/login
        /// Logs in a user and returns a JWT token and their roles if the credentials are valid.
        /// </summary>
        /// <param name="model">Email and password of the user to log in.</param>
        /// <returns>
        /// A JSON object containing the JWT token, expiration time of the token in UTC, and the roles of the user.
        /// If the credentials are invalid, an Unauthorized response is returned.
        /// If an exception occurs during login, a 500 Internal Server Error response is returned.
        /// </returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            try
            {
                _logger.LogInformation("Login attempt for user: {Email}", model.Email);

                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    _logger.LogWarning("User not found: {Email}", model.Email);
                    return Unauthorized(new { message = "Invalid credentials" });
                }

                if (await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    var userRoles = await _userManager.GetRolesAsync(user);
                    _logger.LogInformation("User roles: {Roles}", string.Join(", ", userRoles));

                    var authClaims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.UserName ?? string.Empty),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(ClaimTypes.Email, user.Email ?? string.Empty)
                    };

                    foreach (var userRole in userRoles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                    }

                    var jwtSettings = _configuration.GetSection("JwtSettings");
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"] ?? throw new InvalidOperationException("JWT SecretKey is not configured")));
                    var tokenExpirationMinutes = double.Parse(jwtSettings["ExpirationInMinutes"] ?? "60");

                    var token = new JwtSecurityToken(
                        issuer: jwtSettings["Issuer"],
                        audience: jwtSettings["Audience"],
                        expires: DateTime.Now.AddMinutes(tokenExpirationMinutes),
                        claims: authClaims,
                        signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                    );

                    _logger.LogInformation("Login successful for user: {Email}", model.Email);

                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo,
                        roles = userRoles
                    });
                }

                _logger.LogWarning("Invalid password for user: {Email}", model.Email);
                return Unauthorized(new { message = "Invalid credentials" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during login for user: {Email}", model.Email);
                return StatusCode(500, new { message = "An error occurred during login" });
            }
        }
    }
}
