# Manual Técnico — Sistema de Veterinaria

## 1. Introducción

El Sistema de Veterinaria es una aplicación web desarrollada en C# con ASP.NET Core MVC, cuyo objetivo es gestionar mascotas mediante una interfaz web. El proyecto aplica los principios de Programación Orientada a Objetos (POO) y conserva las clases y la estructura de datos definidas en la Práctica 1.

## 2. Tecnologías utilizadas

- **C#:** lenguaje de programación utilizado para implementar la lógica del sistema.

- **ASP.NET Core MVC:** framework utilizado para desarrollar la aplicación web.

- **Razor:** tecnología utilizada para construir las vistas.

- **HTML y CSS:** utilizados para la estructura y presentación de la interfaz web.

- **Git y GitHub:** herramientas para el control de versiones y almacenamiento del código fuente.

## 3. Arquitectura del sistema

La aplicación utiliza el patrón Modelo-Vista-Controlador (MVC), que separa las responsabilidades en tres componentes:

- **Models:** contiene las clases que representan a las mascotas y la lógica relacionada con su comportamiento.

- **Views:** presenta la información al usuario mediante archivos Razor (`.cshtml`).

- **Controllers:** recibe las solicitudes, procesa las acciones y coordina la interacción entre los modelos y las vistas.

El flujo general de ejecución es:

`URL → Controller → Action → Model → View`

## 4. Clases principales

El sistema contempla las siguientes clases:

| Clase     | Descripción                              |
| --------- | ---------------------------------------- |
| `Mascota` | Clase base para representar una mascota. |
| `Perro`   | Representa una mascota de tipo perro.    |
| `Gato`    | Representa una mascota de tipo gato.     |
| `Ave`     | Representa una mascota de tipo ave.      |
| `Tortuga` | Representa una mascota de tipo tortuga.  |

Estas clases permiten aplicar abstracción, encapsulamiento, herencia y polimorfismo, así como mantener los comportamientos específicos de cada tipo de mascota.

## 5. Funcionalidades del sistema

El sistema contempla las siguientes operaciones:

- Registrar y listar mascotas.

- Consultar y editar información.

- Eliminar registros.

- Cambiar el estado de salud entre sana y enferma.

- Calcular la dosis de medicamento según el tipo de mascota y la dosis base por kilogramo.

Para almacenar las mascotas se debe conservar la implementación de lista propia desarrollada en la Práctica 1, sin sustituirla por `List<T>`.

## 6. Almacenamiento de datos

La aplicación administra la información en memoria durante su ejecución. No utiliza una base de datos ni Entity Framework, y no requiere persistencia de datos. Por ello, los registros pueden perderse al detener o reiniciar la aplicación.

## 7. Instalación y ejecución

### Requisitos

- Git.

- .NET SDK compatible con el proyecto.

- Editor de código o terminal.

### Pasos

1. Clonar el repositorio:
   
   ```
   git clone https://github.com/GabrielSales123/IPC2_Practica3_202505058_2S2026.git
   ```

2. Ingresar a la carpeta del proyecto:
   
   ```
   cd IPC2_Practica3_202505058_2S2026/SistemaVeterinaria
   ```

3. Restaurar las dependencias:
   
   ```
   dotnet restore
   ```

4. Ejecutar la aplicación:
   
   ```
   dotnet run
   ```

5. Abrir en el navegador la dirección local que muestra la terminal.

## 8. Consideraciones técnicas

- La lógica de negocio debe mantenerse en las clases correspondientes y no directamente en las vistas.

- Las consultas deben utilizar HTTP GET y las operaciones que envían información mediante formularios deben utilizar HTTP POST, según corresponda.

- Debe conservarse la implementación de lista propia.

- No se permite utilizar Entity Framework ni una base de datos para esta práctica.


