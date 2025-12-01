// archivo: assets/js/formulario.js

document.addEventListener("DOMContentLoaded", function () {
    const form = document.getElementById("formularioContacto");
    const mensajeError = document.getElementById("mensajeError");
    const mensajeGuardado = document.getElementById("mensajeGuardado");

    form.addEventListener("submit", async function (e) {
        e.preventDefault();

        const nombre = document.getElementById("nombre").value.trim();
        const telefono = document.getElementById("telefono").value.trim();
        const email = document.getElementById("email").value.trim();
        const mensaje = document.getElementById("mensaje").value.trim();

        if (!nombre || !email || !mensaje) {
            mensajeError.style.display = "block";
            mensajeGuardado.style.display = "none";
            return;
        } else {
            mensajeError.style.display = "none";
        }

        const data = {
            name: nombre,
            phone: telefono,
            email: email,
            message: mensaje
        };

        try {
            const response = await fetch("http://localhost:5000/api/clients", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(data)
            });

            if (!response.ok) {
                throw new Error("Error en el servidor");
            }

            mensajeGuardado.style.display = "block";
            form.reset();

        } catch (error) {
            alert("Hubo un problema enviando los datos.");
            console.error(error);
        }
    });
});