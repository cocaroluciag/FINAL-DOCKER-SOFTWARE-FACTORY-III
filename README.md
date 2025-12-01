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

PhpMyAdmin

🔗 Accesos por defecto
Servicio    URL
FRONTEND: 	http://localhost:8080

BACKEND (.NET API):	http://localhost:5000

PhpMyAdmin: http://localhost:8081

MySQL:	puerto 3306

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
    "name": "Lucia",
    "email": "cocarolucia@gmail.com",
    "phone": "12345678",
    "message": "Hola, primer mensaje!"
    "createdAt": "2025-11-30T18:42:15.327Z"
  }
]

📌 POST /api/clients

Enviar datos del formulario.

Body esperado:

{
  "name": "Lucia",
  "email": "cocarolucia@gmail.com",
  "phone": "12345678",
  "message": "Hola, primer mensaje!"
}



Respuesta:

{
  "success": true,
  "message": "Registro almacenado correctamente"
}



🙌 Autor:

Proyecto realizado por Cócaro, Lucia Guadalupe.
