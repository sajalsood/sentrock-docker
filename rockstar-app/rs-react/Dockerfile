FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

RUN curl --silent --location https://deb.nodesource.com/setup_10.x | bash -
RUN apt-get install --yes nodejs

# FROM arm64v8/node:14.16.0-buster-slim
WORKDIR /src
COPY *.csproj ./

RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /src
EXPOSE 80
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "rs-react.dll"]
