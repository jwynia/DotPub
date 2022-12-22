FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DotPub.WebApi/DotPub.WebApi.csproj", "DotPub.WebApi/"]
RUN dotnet restore "DotPub.WebApi/DotPub.WebApi.csproj"
COPY . .
WORKDIR "/src/DotPub.WebApi"
RUN dotnet build "DotPub.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotPub.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotPub.WebApi.dll"]
