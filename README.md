# Address Management Application

This project consists of an Angular frontend and a .NET Core backend API.

## Prerequisites

- Node.js (v14 or later)
- .NET Core SDK 6.0
- Angular CLI (v15)

## Setup Instructions

1. Clone the repository:
 ```
git clone https://github.com/sachinbarthwal/AGDataProjectNoRaven.git
cd --YourFolderName--
```
3. Set up the backend:
 ```
cd AddressAPI
dotnet restore
dotnet build
 ```

4. Set up the frontend:
 ```cd ../frontend
npm install
npm install bootstrap
```

### Running the Application

After completing the setup, you have two options to run the application:

1. **Using the Batch File**:  
   A batch file named `start-app.bat` has been added to the root folder of the project. This file can be used to start both the backend and frontend services with a single command. Simply double-click on `start-app.bat` to run the application.

2. **Using Visual Studio**:  
   Alternatively, you can run the application directly through Visual Studio. Open the solution file in Visual Studio, and start the application by pressing `F5` or using the "Start Debugging" option.
- Right click on solution go to properties, startup project then select Multiple Startup projects and select start for both of both the project and ok.
- Start the backend:
  ```
  cd ../AddressAPI
  dotnet run
  ```
- In a new terminal, start the frontend:
  ```
  cd ../AngularFrontend
  ng serve
  ```

- Open a web browser and navigate to `http://localhost:4200`

## Ports

- The backend API will be available at `https://localhost:7262`
- The frontend will be served at `http://localhost:4200`

## Project Structure

- `AddressAPI/`: .NET Core 6
- `AngularFrontend/`: Angular 15 frontend application

## Backend (AddressAPI)

- Built with .NET Core 6
- Implements RESTful API endpoints for address management

## Troubleshooting

- If you encounter CORS issues, ensure that the backend is properly configured to allow requests from the frontend origin.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.

For backend issues, refer to the .NET Core
