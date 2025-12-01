# FINAL-DOCKER-SOFTWARE-FACTORY-III

📘Trabajo Práctico: Desarrollo y Despliegue de una Aplicación Web con Docker y Backend - Software Factory III.

Este proyecto consiste en una aplicación Fullstack con:

Backend: API REST desarrollada en .NET 8 / C#

Frontend: HTML, CSS y JavaScript.

Base de datos: MySQL + PhpMyAdmin

Contenerización: Docker y Docker Compose.

El objetivo del proyecto es permitir que un usuario complete un formulario dentro del frontend, el cual envía los datos al backend y éstos se almacenan correctamente en la base de datos.

📌 1. Funcionalidad del Proyecto

La aplicación permite:

Enviar información desde un Formulario Web.

Procesar la solicitud en un backend desarrollado en .NET.

Almacenar la información en una base de datos MySQL.

Visualizar y administrar la BD mediante PhpMyAdmin.

Ejecutar todo el entorno dentro de contenedores Docker para facilitar la portabilidad y despliegue.

📂 2. Clonar el Repositorio

git clone https://github.com/cocaroluciag/FINAL-DOCKER-SOFTWARE-FACTORY-III.git

cd FINAL-DOCKER-SOFTWARE-FACTORY-III

🐳 3. Levantar el Entorno con Docker

Asegurate de tener instalado:

Docker

Docker Compose

Luego ejecutar:

docker-compose up --build

- Esto iniciará:

El backend en un contenedor .NET

El frontend en un servidor web (Nginx)

La base de datos MySQL

🔗 Accesos por defecto

Servicio |	URL
FRONTEND	 http://localhost:8080

BACKEND (.NET API)	http://localhost:5000/api/clients

Swagger (.NET API)	http://localhost:5000/swagger/index.html

PhpMyAdmin	http://localhost:8082

MySQL	Puerto 3306

🔐 Credenciales por defecto (MySQL / PhpMyAdmin)

Host: mysql

Usuario: root

Contraseña: luciasql

Base de datos: client_db

📌 Acceso web a PhpMyAdmin

👉 http://localhost:8082

Usuario: root

Contraseña: luciasql


🧱 4. Tecnologías Utilizadas
Frontend:

HTML5

CSS3

JavaScript

Backend:

.NET 8 / ASP.NET Core Web API

C#

Base de Datos

MySQL

PhpMyAdmin

Contenerización:

Docker

Docker Compose

🛠 5. Rutas del Backend y Ejemplos de Respuesta

(Nota: Si bien la consigna menciona un endpoint llamado /submit-client-data, en este proyecto se implementa el estándar RESTful /api/clients, cumpliendo exactamente la misma funcionalidad requerida para almacenar los datos enviados desde el formulario).

📌 GET /api/clients

Obtener todos los registros.

Ejemplo de respuesta:

[
  {
    "id": 1,
    "name": "lucia",
    "email": "cocaroluciaguadalupe@gmail.com",
    "phone": "2923497786",
    "message": "Hola, primer mensaje",
    "createdAt": "2025-12-01T19:23:10"
  }
]


📌 POST /api/clients

Enviar datos del formulario.

Body esperado:

{
  "name": "string",
  "email": "user@example.com",
  "phone": "string",
  "message": "string"
}

(No es necesario enviar id ni createdAt, ya que son generados automáticamente por el backend).


Respuesta:

{
  "success": true,
  "message": "Registro almacenado correctamente"
}



🙌 Autor:

Proyecto realizado por Cócaro, Lucia Guadalupe.
