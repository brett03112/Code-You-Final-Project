// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

document.addEventListener('DOMContentLoaded', function () {
    const buyButtons = document.querySelectorAll('.buy-button');
    const tokenElement = document.querySelector('input[name="__RequestVerificationToken"]');
    const antiForgeryToken = tokenElement ? tokenElement.value : '';
    
    buyButtons.forEach(button => {
        button.addEventListener('click', async function() {
            const dessertId = this.getAttribute('data-dessert-id');
            try {
                const response = await fetch(`/DessertShop?handler=Purchase&dessertId=${dessertId}`, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                        'RequestVerificationToken': antiForgeryToken
                    }
                });

                if (response.ok) {
                    const result = await response.json();
                    if (result.success) {
                        alert('Thank you for your purchase!');
                        // Disable the button and change text to "Sold Out"
                        this.disabled = true;
                        this.classList.remove('btn-primary');
                        this.classList.add('btn-secondary');
                        this.textContent = 'Sold Out';
                    } else {
                        alert(result.message || 'Purchase failed. Please try again.');
                    }
                } else {
                    alert('Purchase failed. Please try again.');
                }
            } catch (error) {
                console.error('Error:', error);
                alert('An error occurred. Please try again.');
            }
        });
    });
});
