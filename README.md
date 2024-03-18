# Proyecto Pokémon API

Una aplicación construida con una arquitectura robusta y prácticas de diseño modernas para proporcionar una solución eficiente y escalable. Aquí hay algunos aspectos clave de la implementación:
### Arquitectura en Layers
Se utilizó una arquitectura de capas para separar las responsabilidades y mejorar la modularidad del sistema. Las capas incluyen:
- Capa de Presentación (Controllers, DTOs)
- Capa de Aplicación (Services)
- Capa de Dominio (Entities, Interfaces)
- Capa de Infraestructura (Repositories, Configurations)

<div align="center">
    <img src="https://github.com/Ausubel/pokemon-api/assets/97548645/7b9a3890-c662-4e56-8b04-fe99413ad75b" alt="Screenshot Project">
</div>

Se usaron interfaces para desacoplar las capas y permitir la inyección de dependencias. Ademas del uso de patrones de diseño como Singleton (para el uso del contexto de la base de datos) y Repository (para el acceso a datos).

### Normalizacion de la Base de Datos
Se utilizó una base de datos relacional para almacenar los datos de los Pokémon. La base de datos se normalizó para evitar la redundancia de datos y mejorar la integridad de los mismos. Se crearon las siguientes tablas:

![Screenshot 2024-02-29 095659](https://github.com/Ausubel/pokemon-api/assets/97548645/90cd9db2-9981-4da1-9841-53fd8ad58d24)

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

Después de iniciar el proyecto, puedes explorar y probar la API importando el archivo JSON de Postman o usando Swagger. Accede a [https://localhost:7289/swagger/index.html](http://localhost:7289/swagger/index.html) para obtener una interfaz interactiva con la lista de endpoints disponibles.

![Swagger](https://github.com/Ausubel/pokemon-api/assets/97548645/09e34a70-4460-4a49-928a-56915d310fbd)

## Publicación con Azure

La API ha sido implementada en Azure utilizando el servicio App Services, una plataforma que simplifica la implementación y administración de aplicaciones en la nube. Además de la integración con una instancia de base de datos en SQL Server también alojada en Azure para una gestión mas simplificada.

<div align="center">
    <img src="https://github.com/Ausubel/pokemon-api/assets/97548645/8ff1b323-1866-40c7-ae60-c82155c73cad" alt="Screenshot Project">
</div>

Puedes probarlo en el siguiente Workspace de Postman [https://www.postman.com/maintenance-architect-77770106/workspace/public-workspace](https://www.postman.com/maintenance-architect-77770106/workspace/public-workspace/folder/29518795-8b21d663-8338-4660-826d-719745694e74)


