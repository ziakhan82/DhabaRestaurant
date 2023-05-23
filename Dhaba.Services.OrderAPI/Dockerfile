#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Dhaba.Services.OrderAPI/Dhaba.Services.OrderAPI.csproj", "Dhaba.Services.OrderAPI/"]
RUN dotnet restore "Dhaba.Services.OrderAPI/Dhaba.Services.OrderAPI.csproj"
COPY . .
WORKDIR "/src/Dhaba.Services.OrderAPI"
RUN dotnet build "Dhaba.Services.OrderAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dhaba.Services.OrderAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dhaba.Services.OrderAPI.dll"]