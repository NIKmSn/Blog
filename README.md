# Blog
## Requirements
 - .NET Core 3.0+
 - Node.JS
 - PostgreSQL (connection string in Back/API/appsettings.json)
## Optional
 - Docker
 - Docker-compose
## You can use Docker to run the project:
```
cd Docker
docker-compose -f docker-compose.yml -f docker-compose.override.yml up --build
```
### :heavy_exclamation_mark: Don't forget to specify these variables in your Docker/.env file!
1. REACT_APP_MAIN_API_URL=https://localhost:5001/api/
2. DATABASE_HOST=127.0.0.1
3. POSTGRES_DB=blog-db
4. POSTGRES_USER=admin
5. POSTGRES_PASSWORD=admin
