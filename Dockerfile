FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# First stage
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
ENV BuildingDocker true
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY ["./dotnetcoreapi-vue-heroku-postgres-template.csproj", "src/"]
RUN dotnet restore "src/dotnetcoreapi-vue-heroku-postgres-template.csproj"

# Copy everything else and build website
COPY . .
WORKDIR "/src"
RUN dotnet build "dotnetcoreapi-vue-heroku-postgres-template.csproj" -c Release -o /app/build

# Build Vue app
FROM node:12-alpine as build-node
WORKDIR /ClientApp
COPY ClientApp/package.json .
COPY ClientApp/package-lock.json .
RUN npm install
COPY ClientApp/ .
RUN npm run-script build

FROM build AS publish
RUN dotnet publish "dotnetcoreapi-vue-heroku-postgres-template.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=build-node /ClientApp/dist ./ClientApp/build

# ENTRYPOINT ["dotnet", "dotnetcoreapi-vue-heroku-postgres-template.dll"]
# CMD ["dotnet", "dotnetcoreapi-vue-heroku-postgres-template.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet dotnetcoreapi-vue-heroku-postgres-template.dll