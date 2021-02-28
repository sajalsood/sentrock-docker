FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
RUN curl --silent --location https://deb.nodesource.com/setup_10.x | bash -
RUN apt-get install --yes nodejs
WORKDIR /src
COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /src
EXPOSE 80
COPY --from=build /app/publish .
ENV RS_API_URL http://localhost:5001
ENTRYPOINT ["dotnet", "rs-react.dll"]
