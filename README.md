📘Trabajo Práctico: Desarrollo y Despliegue de una Aplicación Web con Docker y Backend - Software Factory III



Este proyecto consiste en una aplicación Fullstack con:



Backend: API REST desarrollada en .NET 8 / C#



Frontend: HTML, CSS y JavaScript.



Base de datos: MySQL + PhpMyAdmin



Contenerización: Docker y Docker Compose.



El objetivo del proyecto es permitir que un usuario complete un formulario dentro del frontend, el cual envía los datos al backend y éstos se almacenan correctamente en la base de datos.



📌 1. Funcionalidad del Proyecto



La aplicación permite:



Enviar información desde un formulario web.



Procesar la solicitud en un backend desarrollado en .NET.



Almacenar la información en una base de datos MySQL.



Visualizar y administrar la BD mediante PhpMyAdmin.



Ejecutar todo el entorno dentro de contenedores Docker para facilitar la portabilidad y despliegue.



📂 2. Clonar el Repositorio



git clone https://github.com/tu-usuario/tu-repositorio.git

cd tu-repositorio



🐳 3. Levantar el Entorno con Docker



Asegurate de tener instalado:



Docker



Docker Compose



Luego ejecutar:



docker-compose up --build





Esto iniciará:



El backend en un contenedor .NET



El frontend en un servidor web (Nginx o similar)



La base de datos MySQL



PhpMyAdmin



🔗 Accesos por defecto

Servicio	URL

Frontend	http://localhost:8080



Backend (.NET API)	http://localhost:5000



PhpMyAdmin	http://localhost:8081



MySQL	puerto 3306

🧱 4. Tecnologías Utilizadas

Frontend



HTML5



CSS3



JavaScript



Backend



.NET 6 / ASP.NET Core Web API



C#



Base de Datos



MySQL



PhpMyAdmin



Contenerización



Docker



Docker Compose



🛠 5. Rutas del Backend y Ejemplos de Respuesta

📌 GET /api/registro



Obtener todos los registros.



Ejemplo de respuesta:



\[

  {

    "id": 1,

    "nombre": "Lucia",

    "email": "lucia@mail.com",

    "mensaje": "Hola!"

  }

]



📌 POST /api/registro



Enviar datos del formulario.



Body esperado:



{

  "nombre": "Lucia",

  "email": "lucia@mail.com",

  "mensaje": "Consulta..."

}





Respuesta:



{

  "success": true,

  "message": "Registro almacenado correctamente"

}



🧪 6. Criterios de Evaluación Cubiertos

✅ Frontend



HTML estructurado correctamente



CSS aplicado de forma consistente



JavaScript para consumir la API



✅ Backend



API funcional y estable



Recepción correcta de solicitudes desde el formulario



Inserción en base de datos MySQL



✅ Docker



Frontend contenerizado



Backend contenerizado



MySQL y PhpMyAdmin contenerizados



Orquestación completa con Docker Compose



✅ Git / GitHub



Commits descriptivos y frecuentes



Uso de branches



Uso recomendado de pull requests



✅ Documentación



README completo



Instrucciones claras para levantar el proyecto



Descripción del flujo y la arquitectura



📜 7. Flujo General del Proyecto



El usuario completa el formulario en el frontend



El frontend envía los datos al backend .NET



El backend procesa la solicitud y guarda los datos en MySQL



Se puede gestionar la base desde PhpMyAdmin



Todo corre sobre Docker para garantizar portabilidad



🙌 Autor



Proyecto realizado por \[tu nombre o tu grupo]

