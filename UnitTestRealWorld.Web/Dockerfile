FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["UnitTestRealWorld.Web/UnitTestRealWorld.Web.csproj", "UnitTestRealWorld.Web/"]
RUN dotnet restore "UnitTestRealWorld.Web/UnitTestRealWorld.Web.csproj"
COPY . .
WORKDIR "/src/UnitTestRealWorld.Web"
RUN dotnet build "UnitTestRealWorld.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UnitTestRealWorld.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UnitTestRealWorld.Web.dll"]
