# CoreBlogPro

CoreBlogPro is a sophisticated blog platform built using ASP.NET Core 6 with the MVC architecture and Entity Framework 6 (EF6) for database operations. This project serves as an exemplary model for developing robust, scalable, and maintainable web applications using modern .NET technologies.

## Features

- **User Authentication and Authorization**: Secure login and role-based access control.
- **CRUD Operations**: Create, read, update, and delete blog posts and categories.
- **Responsive Design**: User-friendly interface optimized for various devices.
- **Entity Framework 6**: Efficient database interactions with LINQ queries.
- **MVC Architecture**: Clean separation of concerns for maintainability and scalability.
- **Tag Management**: Categorize posts with tags for better organization.
- **Comment System**: Engage with users through comments on blog posts.
- **Search Functionality**: Find posts quickly with an integrated search feature.

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

### Installation

1. **Clone the repository:**
    ```bash
    git clone https://github.com/enesscigdem/Asp.net-Core-6-MVC-EF6-Blog-Project.git
    cd Asp.net-Core-6-MVC-EF6-Blog-Project
    ```

2. **Configure the database connection:**
    - Update the `appsettings.json` file with your SQL Server connection string.
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CoreBlogPro;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
    ```

3. **Apply migrations and seed the database:**
    ```bash
    dotnet ef database update
    ```

4. **Run the application:**
    ```bash
    dotnet run
    ```

### Usage

- Navigate to `https://localhost:5001` in your web browser.
- Register a new account or log in with existing credentials.
- Start creating, editing, and managing your blog posts and categories.

## Project Structure

- **Controllers**: Handles the incoming HTTP requests and returns responses.
- **Models**: Represents the data structure and business logic.
- **Views**: Renders the UI elements.
- **Data**: Contains the database context and migrations.

## Contributing

We welcome contributions! Please follow these steps to contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature/your-feature`).
5. Create a new Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

- Thanks to the ASP.NET Core and Entity Framework teams for their incredible work and documentation.
