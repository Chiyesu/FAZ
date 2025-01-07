# FAZ-WebApp

FAZ-WebApp is a web application designed to streamline and enhance the operations of the Football Association of Zambia (FAZ). It aims to provide efficient management of football-related activities, including player registrations, match scheduling, and result tracking, thereby improving the overall administration and promotion of football in Zambia.

## Folder Structure

The project follows a structured organization to maintain clarity and separation of concerns:

- `.vscode/`: Configuration files for Visual Studio Code.
- `Components/`: Reusable UI components used throughout the application.
- `Data/`: Contains data access layer, including database context and seed data.
- `Migrations/`: Entity Framework migrations for database schema management.
- `Models/`: Defines the data models representing the core entities of the application.
- `Properties/`: Project properties and settings.
- `Services/`: Business logic and service classes.
- `wwwroot/`: Static files such as CSS, JavaScript, and images.
- `FAZ.csproj`: Project file defining the project configuration and dependencies.
- `Program.cs`: Entry point of the application.
- `appsettings.json`: Configuration settings for the application.

## Tools and Technologies Used

- **ASP.NET Core**: Framework for building the web application.
- **Entity Framework Core**: Object-relational mapper (ORM) for database operations.
- **SQLite**: Database engine used for development and testing.
- **Visual Studio Code**: Code editor for development.

## License

This project is licensed under the MIT License.

## Collaborations

Currently, there are no external collaborations.

## API Keys and Third-Party Tools

- **GeoLite2**: Utilized for geolocation services.

## Framework Versions

- **ASP.NET Core**: Version 8.0
- **Entity Framework Core**: Version 8.0

## Requirements

### Functional Requirements

- User authentication and authorization.
- Player registration management.
- Match scheduling and result tracking.
- Reporting and analytics on football activities.

### Non-Functional Requirements

- Scalability to handle increasing data and user load.
- User-friendly interface for ease of use.
- Security measures to protect sensitive data.

## Start Commands

To run the application locally:

1. Ensure all dependencies are installed.
2. Apply migrations to set up the database:

   ```bash
   dotnet ef database update
   ```

3. Start the application:

   ```bash
   dotnet run
   ```

The application will be accessible at `https://localhost:5001`.

## Docker Usage

To run the application using Docker:

1. Build the Docker image:

   ```bash
   docker build -t faz-webapp .
   ```

2. Run the Docker container:

   ```bash
   docker run -p 5000:80 faz-webapp
   ```

The application will be accessible at `http://localhost:5000`.

For more details, visit the [FAZ-WebApp GitHub repository](https://github.com/Chiyesu/FAZ-WebApp). 
