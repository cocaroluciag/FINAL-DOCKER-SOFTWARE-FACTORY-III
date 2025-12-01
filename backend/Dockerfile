# ======================
# ETAPA DE BUILD
# ======================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiamos csproj
COPY ProyectoDocker/ProyectoDocker/*.csproj ProyectoDocker/ProyectoDocker/

# Restauramos dependencias
RUN dotnet restore ProyectoDocker/ProyectoDocker/ProyectoDocker.csproj

# Copiamos todo el backend
COPY ProyectoDocker/ProyectoDocker/ ProyectoDocker/ProyectoDocker/

# Publicamos
WORKDIR /src/ProyectoDocker/ProyectoDocker
RUN dotnet publish -c Release -o /app


# ======================
# ETAPA RUNTIME
# ======================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

COPY --from=build /app .

# API expone puerto 8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "ProyectoDocker.dll"]
