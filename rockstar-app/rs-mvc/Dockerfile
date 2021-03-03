FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENV RS_API_URL http://localhost:5001
ENV SA_LOGIC_URL http://192.168.4.136:5000
ENV SA_WEB_APP_URL http://localhost:8080
ENTRYPOINT ["dotnet", "rs-mvc.dll"]
