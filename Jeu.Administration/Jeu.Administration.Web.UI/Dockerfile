FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Jeu.Administration.Web.UI/Jeu.Administration.Web.UI.csproj", "Jeu.Administration.Web.UI/"]
RUN dotnet restore "Jeu.Administration.Web.UI/Jeu.Administration.Web.UI.csproj"
COPY . .
WORKDIR "/src/Jeu.Administration.Web.UI"
RUN dotnet build "Jeu.Administration.Web.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Jeu.Administration.Web.UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Jeu.Administration.Web.UI.dll"]