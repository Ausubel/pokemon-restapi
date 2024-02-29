# Proyecto Pokémon API

Una API para gestionar información sobre Pokémon.

## Requisitos Previos

- .NET Core SDK 8
- Microsoft SQL Server 2022

## Configuración del Proyecto

1. Clona este repositorio.
2. Abre el proyecto en tu entorno de desarrollo favorito.
3. Ejecuta el archivo db_pokemon.sql para crear la base de datos e insertar los datos iniciales.
3. Actualiza la cadena de conexión a la base de datos en `appsettings.json`.
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost; Database=db_pokemon; Trusted_Connection=True; TrustServerCertificate=True;"
    }
    ```

5. Instala las dependencias del NuGet Package Manager
    - Microsoft.EntityFrameworkCore.SqlServer(8.0.2)
    - Microsoft.EntityFrameworkCore.Tools(8.0.2)

## Instrucciones de Uso

Después de iniciar el proyecto, puedes explorar y probar la API utilizando Swagger. Accede a [https://localhost:7289/swagger/index.html](http://localhost:7289/swagger/index.html) para obtener una interfaz interactiva con la lista de endpoints disponibles.