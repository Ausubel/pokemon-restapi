# Proyecto Pokémon API

Una aplicación construida con una arquitectura robusta y prácticas de diseño modernas para proporcionar una solución eficiente y escalable. Aquí hay algunos aspectos clave de la implementación:
### Arquitectura de Layers
Se utilizó una arquitectura de capas para separar las responsabilidades y mejorar la modularidad del sistema. Las capas incluyen:
- Capa de Presentación (Controllers, DTOs)
- Capa de Aplicación (Services)
- Capa de Dominio (Entidades, Interfaces, Excepciones)
- Capa de Infraestructura (Acceso a Datos, Configuraciones)

Se usaron interfaces para desacoplar las capas y permitir la inyección de dependencias. Ademas del uso de patrones de diseño como Singleton (para el uso del contexto de la base de datos) y Repository (para el acceso a datos).

### Normalizacion de la Base de Datos
Se utilizó una base de datos relacional para almacenar los datos de los Pokémon. La base de datos se normalizó para evitar la redundancia de datos y mejorar la integridad de los mismos. Se crearon las siguientes tablas:

- pokemon
- pokemonType
- pokemonDiet
- pokemonSize
- pokemonRarity

## Requisitos Previos

- .NET Core SDK 8
- Microsoft SQL Server 2022

## Configuración del Proyecto

1. Clona este repositorio.
2. Abre el proyecto en tu entorno de desarrollo favorito.
3. Ejecuta el archivo db_pokemon.sql, que está dentro de la carpeta de Docs, para crear la base de datos e insertar los datos iniciales.
3. Actualiza la cadena de conexión a la base de datos con tus credenciales en `appsettings.json`, o si tienes el Windows Authentication habilitado, puedes dejar la cadena de conexión tal como está.
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