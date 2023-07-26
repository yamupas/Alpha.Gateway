#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Alpha.ApiGateway/Alpha.ApiGateway.csproj", "."]
RUN dotnet restore "./Alpha.ApiGateway.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./Alpha.ApiGateway/Alpha.ApiGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./Alpha.ApiGateway/Alpha.ApiGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Alpha.ApiGateway.dll"]

