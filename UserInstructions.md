# HolidayDessertStore Application Usage Instructions

## **Introduction**

The HolidayDessertStore application consists of two main parts:

1. **HolidayDessertStore.API:** This is the backend API built with ASP.NET Core, responsible for managing dessert data, handling authentication, and processing requests.
2. **HolidayDessertStore:** This is the frontend web application, also built with ASP.NET Core, providing a user interface to interact with the API.

## **Part 1: Setting up and Running the Applications**

### **Step 1: Run the HolidayDessertStore.API**

The HolidayDessertStore.API provides the backend services for the application.

1. Open a terminal in the `HolidayDessertStore.API` directory.
2. Execute the following command to run the API:

    ```bash
    cd HolidayDessertStore.API && dotnet run
    ```

    This command will navigate into the `HolidayDessertStore.API` directory and then start the API. The API will typically be accessible at `http://localhost:5014`. You can find the exact port in the `HolidayDessertStore.API\Properties\launchSettings.json` file under the `applicationUrl` property.

### **Step 2: Run the HolidayDessertStore Web Application**

The HolidayDessertStore web application provides the user interface.

1. Open a new terminal in the `HolidayDessertStore` directory.
2. Execute the following command to run the web application:

    ```bash
    cd HolidayDessertStore && dotnet run
    ```

    This command will navigate into the `HolidayDessertStore` directory and then start the web application. The web application will typically be accessible at `http://localhost:5001`. You can find the exact URL(s) in the `HolidayDessertStore\Properties\launchSettings.json` file under the `applicationUrl` property.

## **Part 2: Using the API Endpoints with HTTP Files**

The following HTTP files are provided to interact with the API: `GET-api-requests.http`, `POST-api-requests.http`, `PUT-api-requests.http`, `DELETE-api-requests.http`, and `Login-api-requests.http`. You can use tools like the REST Client extension in VS Code to execute these requests.

### **Step 1: Authentication**

Before accessing most API endpoints (except GET requests for desserts), you need to authenticate to obtain a JWT token.

* **File:** `Login-api-requests.http`
* **Method:** `POST`
* **Endpoint:** `http://localhost:5014/api/auth/login`
* **Content-Type:** `application/json`
* **Request Body:**

    ```json
    {
      "email": "admin@example.com",
      "password": "admin00"
    }
    ```

* **How to Use:** Open the `Login-api-requests.http` file in VS Code with the REST Client extension installed and click "Send Request".
* **Expected Response:** A successful request will return a JSON response containing an `authToken` (JWT). You will need to use this token in the headers of subsequent requests that require authentication.

### **Step 2: Getting Dessert Information**

* **File:** `GET-api-requests.http`
* **Method:** `GET`
* **Endpoints:**
  * `http://localhost:5014/api/Desserts` - Retrieves all desserts.
  * `http://localhost:5014/api/Desserts/{id}` (e.g., `http://localhost:5014/api/Desserts/1`) - Retrieves a specific dessert by its ID.
  * `http://localhost:5014/api/Desserts/999` - Example of a request that will likely return a 404 (Not Found) error.
* **Headers:** `Accept: application/json`
* **Authentication:** Not required for GET requests to the `/api/Desserts` endpoint.
* **How to Use:** Open the `GET-api-requests.http` file in VS Code with the REST Client extension installed and click "Send Request" for the desired request.
* **Expected Response:**
  * For the `/api/Desserts` endpoint, a JSON array of dessert objects.
  * For a specific dessert ID, a JSON object containing the dessert's details.
  * For a non-existent dessert ID, a 404 Not Found error.

### **Step 3: Creating a New Dessert**

* **File:** `POST-api-requests.http`
* **Method:** `POST`
* **Endpoint:** `http://localhost:5014/api/Desserts`
* **Content-Type:** `application/json`
* **Headers:** `Authorization: Bearer {{authToken}}` (replace `{{authToken}}` with the actual token obtained from the login endpoint).
* **Request Body:**

    ```json
    {
        "name": "Holiday Peppermint Cheesecake",
        "description": "Rich cheesecake swirled with crushed peppermint candies, topped with chocolate ganache and whipped cream",
        "price": 42.99,
        "imagePath": "/images/desserts/peppermint_cheesecake.jpg",
        "quantity": 15,
        "isAvailable": true
    }
    ```

* **How to Use:**
    1. Obtain an authentication token using the `Login-api-requests.http` file.
    2. Replace `{{authToken}}` in the `POST-api-requests.http` file with the obtained token.
    3. Open the `POST-api-requests.http` file in VS Code with the REST Client extension installed and click "Send Request".
* **Expected Response:** A successful request will return a 201 Created status code, and the response body may contain the newly created dessert object.

### **Step 4: Updating an Existing Dessert**

* **File:** `PUT-api-requests.http`
* **Method:** `PUT`
* **Endpoint:** `http://localhost:5014/api/Desserts/{id}` (e.g., `http://localhost:5014/api/Desserts/1`). **Note:** The ID in the URL must match the `id` in the request body.
* **Content-Type:** `application/json`
* **Headers:** `Authorization: Bearer {{authToken}}` (replace `{{authToken}}` with a valid admin JWT token).
* **Request Body (Example for updating dessert with ID 1):**

    ```json
    {
        "id": 1,
        "name": "Updated Orange Creamsicle Cheesecake",
        "description": "Smooth cheesecake topped with orange glaze and fresh orange slices, now with extra orange zest",
        "price": 45.99,
        "imagePath": "/images/desserts/orange_slice_cheesecake.jpg",
        "quantity": 18,
        "isAvailable": true
    }
    ```

* **How to Use:**
    1. Obtain an admin authentication token using the `Login-api-requests.http` file.
    2. Replace `{{authToken}}` in the `PUT-api-requests.http` file with the obtained token.
    3. Ensure the ID in the URL matches the `id` in the request body.
    4. Open the `PUT-api-requests.http` file in VS Code with the REST Client extension installed and click "Send Request".
* **Expected Response:**
  * A successful update will return a 204 No Content status code.
  * Attempting to update a non-existent dessert (e.g., ID 999) will likely return a 400 Bad Request error.

### **Step 5: Deleting a Dessert**

* **File:** `DELETE-api-requests.http`
* **Method:** `DELETE`
* **Endpoint:** `http://localhost:5014/api/Desserts/{id}` (e.g., `http://localhost:5014/api/Desserts/1`).
* **Headers:** `Authorization: Bearer {{authToken}}` (replace `{{authToken}}` with a valid admin JWT token).
* **Request Body:** None.
* **How to Use:**
    1. Obtain an admin authentication token using the `Login-api-requests.http` file.
    2. Replace `{{authToken}}` in the `DELETE-api-requests.http` file with the obtained token.
    3. Open the `DELETE-api-requests.http` file in VS Code with the REST Client extension installed and click "Send Request".
* **Expected Response:**
  * A successful deletion will return a 204 No Content status code.
  * Attempting to delete a non-existent dessert (e.g., ID 999) will likely return a 404 Not Found error.

## **Part 3: Using the Web Frontend**

Once both the API and the web frontend are running, you can access the web application in your browser by navigating to the URL provided in the terminal where you ran the `HolidayDessertStore` project (typically `https://localhost:7288` or `http://localhost:5288`).

The web frontend allows you to:

* **Browse Desserts:** View a list of available desserts.
* **View Dessert Details:** Click on a dessert to see more information.
* **Add to Cart:** Add desserts to your shopping cart.
* **View Cart:** See the items in your cart and proceed to checkout.
* **Checkout:** Process your order (note: payment processing might be simulated or require specific configuration).
* **Admin Interface:** Access an administrative section (likely requiring authentication) to manage desserts (add, edit, delete). This functionality will heavily rely on the API endpoints described in Part 2.

## **Part 4: Interaction between Frontend and API**

The HolidayDessertStore web frontend interacts with the HolidayDessertStore.API to fetch and manage dessert data. For example:

* When you browse desserts on the frontend, it makes GET requests to the API to retrieve the list of desserts.
* When you add a dessert to your cart, the frontend might send data to the API to update your cart information.
* The admin interface uses POST, PUT, and DELETE requests to the API to create, update, and delete desserts, respectively.

## **Conclusion**

This guide provides a comprehensive overview of how to use the HolidayDessertStore application, including running the API and web frontend, and detailed explanations for using each of the provided HTTP files to interact with the API. Remember to start both applications and use a REST client to execute the HTTP requests. The web frontend provides a user-friendly interface for interacting with the dessert store, while the API offers programmatic access to the data and functionalities.
