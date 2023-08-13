<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ASP.NET Core Web API - Product Management</title>
</head>

<body>

    <h1>ASP.NET Core Web API - Product Management</h1>
    <p>A RESTful API built with ASP.NET Core MVC for managing products.</p>

    <h2>Features</h2>
    <ul>
        <li>CRUD operations for products.</li>
        <li>Integrated with Entity Framework Core.</li>
        <li>Proper error handling.</li>
    </ul>

    <h2>Getting Started</h2>

    <h3>Prerequisites</h3>
    <ul>
        <li>.NET Core SDK</li>
        <li>Database setup as per <code>ApplicationDbContext</code></li>
    </ul>

    <h3>Setup</h3>
    <ol>
        <li>Clone the repo:
            <pre><code>git clone https://github.com/MuhammadSaqib786/AspNetCoreWebAPI-Project.git</code></pre>
        </li>
        <li>Install dependencies:
            <pre><code>dotnet restore</code></pre>
        </li>
        <li>Update the database:
            <pre><code>dotnet ef database update</code></pre>
        </li>
        <li>Run:
            <pre><code>dotnet run</code></pre>
        </li>
    </ol>

    <h2>API Endpoints</h2>
    <ul>
        <li><strong>All Products</strong>: <code>GET /api/products</code></li>
        <li><strong>Add Product</strong>: <code>POST /api/products</code></li>
        <li><strong>Product by ID</strong>: <code>GET /api/products/{id}</code></li>
        <li><strong>Update Product</strong>: <code>PUT /api/products/{id}</code></li>
        <li><strong>Delete Product</strong>: <code>DELETE /api/products/{id}</code></li>
    </ul>

    <h2>Contributing</h2>
    <p>Pull requests are welcome. For major changes, please open an issue first to discuss what you'd like to change.</p>

    <h2>Contact</h2>
    <p>Muhammad Saqib - <a href="https://github.com/MuhammadSaqib786" target="_blank">GitHub Profile</a></p>

</body>

</html>
