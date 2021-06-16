#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["RestWithASP-NETUdemy/RestWithASP-NETUdemy.csproj", "RestWithASP-NETUdemy/"]
RUN dotnet restore "RestWithASP-NETUdemy/RestWithASP-NETUdemy.csproj"
COPY . .
WORKDIR "/src/RestWithASP-NETUdemy"
RUN dotnet build "RestWithASP-NETUdemy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestWithASP-NETUdemy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestWithASP-NETUdemy.dll"]
