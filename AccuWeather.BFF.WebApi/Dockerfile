FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AccuWeather.BFF.WebApi/AccuWeather.BFF.WebApi.csproj", "AccuWeather.BFF.WebApi/"]
RUN dotnet restore "AccuWeather.BFF.WebApi/AccuWeather.BFF.WebApi.csproj"
COPY . .
WORKDIR "/src/AccuWeather.BFF.WebApi"
RUN dotnet build "AccuWeather.BFF.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AccuWeather.BFF.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AccuWeather.BFF.WebApi.dll"]
