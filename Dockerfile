FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY shadowrun-dice-roller-bot.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app shadowrun-dice-roller-bot.sln

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "shadowrun-dice-roller-bot.dll"]