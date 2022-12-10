#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Testes_Invor_Dados_Web/Testes_Invor_Dados_Web.csproj", "Testes_Invor_Dados_Web/"]
RUN dotnet restore "Testes_Invor_Dados_Web/Testes_Invor_Dados_Web.csproj"
COPY . .
WORKDIR "/src/Testes_Invor_Dados_Web"
RUN dotnet build "Testes_Invor_Dados_Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Testes_Invor_Dados_Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Testes_Invor_Dados_Web.dll"]