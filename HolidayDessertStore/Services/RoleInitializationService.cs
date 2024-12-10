using Microsoft.AspNetCore.Identity;

namespace HolidayDessertStore.Services
{
    public class RoleInitializationService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ILogger<RoleInitializationService> _logger;

        public RoleInitializationService(
            RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager,
            IConfiguration configuration,
            ILogger<RoleInitializationService> logger)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _configuration = configuration;
            _logger = logger;
        }

        public async Task InitializeAsync()
        {
            try
            {
                // Create Admin role if it doesn't exist
                if (!await _roleManager.RoleExistsAsync("Admin"))
                {
                    await _roleManager.CreateAsync(new IdentityRole("Admin"));
                    _logger.LogInformation("Created Admin role");
                }

                // Get admin email from configuration
                string adminEmail = _configuration["AdminUser:Email"];
                string adminPassword = _configuration["AdminUser:Password"];

                if (string.IsNullOrEmpty(adminEmail) || string.IsNullOrEmpty(adminPassword))
                {
                    _logger.LogWarning("Admin user credentials not found in configuration");
                    return;
                }

                // Create admin user if it doesn't exist
                var adminUser = await _userManager.FindByEmailAsync(adminEmail);
                if (adminUser == null)
                {
                    adminUser = new IdentityUser
                    {
                        UserName = adminEmail,
                        Email = adminEmail,
                        EmailConfirmed = true
                    };

                    var result = await _userManager.CreateAsync(adminUser, adminPassword);
                    if (result.Succeeded)
                    {
                        _logger.LogInformation($"Created admin user: {adminEmail}");
                    }
                    else
                    {
                        _logger.LogError($"Failed to create admin user: {string.Join(", ", result.Errors)}");
                        return;
                    }
                }

                // Assign Admin role to user if not already assigned
                if (!await _userManager.IsInRoleAsync(adminUser, "Admin"))
                {
                    var result = await _userManager.AddToRoleAsync(adminUser, "Admin");
                    if (result.Succeeded)
                    {
                        _logger.LogInformation($"Assigned Admin role to user: {adminEmail}");
                    }
                    else
                    {
                        _logger.LogError($"Failed to assign Admin role: {string.Join(", ", result.Errors)}");
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in role initialization: {ex.Message}");
            }
        }
    }
}
