
# dotnetcoreapi-vue-heroku-postgres-template

You can use this project to deploy a .NET Core Api project with Vue.js to Heroku using Github Actions.

This project includes Dotnet Core Api, Vue.js, Docker, Github Actions and Postgres Database.

# Getting Started :star:

### To use this template 
Download this Repository

### Using the dotnet CLI to install package

```powershell
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL.Design
dotnet add package VueCliMiddleware
```

### Configuring the project to use PostgreSQL

Update `appsettings.json`'s `ConnectionStrings` MyDb property to your Heroku Postgre server address:

```json
    "ConnectionStrings": {
        "MyDb": "Server=;Database=;User Id=;Password=;SslMode=Require;"
    }
```

## Build the vue application.
```powershell
cd /ClientApp
npm install
```

## Run the application.
```powershell
cd /
dotnet run
```

## Open the browswer to see the result
http://localhost:5000/


## Running the sample using Docker
### Build docker image
```powershell
docker build -t dotnetcoreapi-vue-heroku-postgres-template .
```
### Run docker image
```powershell
docker run -d -p 5000:80 --name myapp dotnetcoreapi-vue-heroku-postgres-template
```

## Related Articles
- [Deploy .Net Core App to Heroku](https://medium.com/null-exception/deploy-net-core-app-to-heroku-a22a04f107c9)
- [Deploy .NET Core & React to Heroku using Github Actions](https://medium.com/splendr-llc/deploy-net-core-react-to-heroku-using-github-actions-ec32d1925b1e)