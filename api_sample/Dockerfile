FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["api_sample.csproj", "./"]
RUN dotnet restore "./api_sample.csproj"
COPY . .
RUN dotnet build "api_sample.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "api_sample.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "api_sample.dll"]

