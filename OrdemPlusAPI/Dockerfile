# Etapa base com o runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
# Copia o arquivo do projeto e restaura as dependências
COPY ["OrdemPlusAPI.csproj", "./"]
RUN dotnet restore "OrdemPlusAPI.csproj"
# Copia todo o código e compila
COPY . .
RUN dotnet build "OrdemPlusAPI.csproj" -c Release -o /app/build

# Publicação
FROM build AS publish
RUN dotnet publish "OrdemPlusAPI.csproj" -c Release -o /app/publish

# Etapa final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OrdemPlusAPI.dll"]

