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