const especieSelect = document.getElementById("especie");
const seccionesEspecie = document.querySelectorAll(".campos-especie");

if (especieSelect) {
    function actualizarCuestionario() {
        seccionesEspecie.forEach((seccion) => {
            const mostrar = seccion.id === `campos-${especieSelect.value}`;

            seccion.hidden = !mostrar;

            seccion.querySelectorAll("input, select").forEach((campo) => {
                campo.disabled = !mostrar;
            });
        });
    }

    especieSelect.addEventListener("change", actualizarCuestionario);
    actualizarCuestionario();
}

const botonBuscar = document.getElementById("buscarMascota");

if (botonBuscar) {
    botonBuscar.addEventListener("click", () => {
        const codigo = document
            .getElementById("buscarCodigo")
            .value
            .trim()
            .toUpperCase();

        const filas = document.querySelectorAll("tbody tr[data-codigo]");
        const mensaje = document.getElementById("mensajeBusqueda");
        let encontrada = false;

        filas.forEach((fila) => {
            const coincide =
                fila.dataset.codigo.toUpperCase() === codigo;

            fila.hidden = codigo !== "" && !coincide;

            if (coincide) {
                encontrada = true;
            }
        });

        mensaje.textContent =
            codigo === "" || encontrada
                ? ""
                : "No se encontró una mascota con ese código.";
    });
}