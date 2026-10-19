# Sistema de Veterinaria

Aplicación web para la gestión de mascotas de una veterinaria, desarrollada en C# con ASP.NET Core MVC, aplicando los principios de la Programación Orientada a Objetos (POO).

## Descripción del proyecto

El proyecto consiste en adaptar un sistema de veterinaria desarrollado previamente en consola a una aplicación web. Su propósito es permitir la administración de mascotas mediante una interfaz web, utilizando controladores, vistas Razor y modelos para separar las responsabilidades de la aplicación.

El sistema contempla diferentes tipos de mascotas, la consulta y modificación de su información, el cambio de estado de salud y el cálculo de dosis de medicamento según el tipo de animal.

## Objetivos

- Implementar el patrón Modelo-Vista-Controlador (MVC) utilizando ASP.NET Core.
- Aplicar los principios de abstracción, encapsulamiento, herencia y polimorfismo.
- Reutilizar las clases y la estructura de lista desarrolladas en la Práctica 1.
- Administrar las mascotas mediante una interfaz web.
- Separar la lógica del sistema, el procesamiento de solicitudes y la presentación de información.

## Funcionalidades

El sistema contempla las siguientes operaciones:

- **Registrar mascotas:** crear nuevos registros de perros, gatos, aves y tortugas.
- **Listar mascotas:** visualizar las mascotas registradas.
- **Consultar mascotas:** revisar la información de una mascota.
- **Editar mascotas:** modificar la información de los registros existentes.
- **Eliminar mascotas:** retirar registros de mascotas.
- **Cambiar estado de salud:** establecer si una mascota está sana o enferma.
- **Calcular dosis de medicamento:** determinar la dosis correspondiente a partir de la dosis base por kilogramo y el factor de ajuste de cada tipo de mascota.

### Factores de ajuste de dosis

| Tipo de mascota | Factor de ajuste |
|---|---:|
| Perro | 100 % |
| Gato | 90 % |
| Ave | 50 % |
| Tortuga | 80 % |

El cálculo debe considerar el factor de ajuste correspondiente al tipo de mascota.

## Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework web:** ASP.NET Core MVC
- **Interfaz:** HTML y vistas Razor (`.cshtml`)
- **Arquitectura:** Modelo-Vista-Controlador (MVC)
- **Paradigma de programación:** Programación Orientada a Objetos
- **Control de versiones:** Git y GitHub

## Arquitectura del proyecto

La aplicación utiliza el patrón MVC para separar las responsabilidades de sus componentes.

| Componente | Responsabilidad |
|---|---|
| `Models` | Contiene las clases que representan las mascotas y la lógica de negocio. |
| `Views` | Contiene las vistas Razor que presentan la información y los formularios. |
| `Controllers` | Procesa las solicitudes, ejecuta las acciones y coordina la interacción entre modelos y vistas. |

El flujo general de una solicitud es:

`URL → Controller → Action → Model → View`

Esta organización permite mantener la lógica principal en las clases correspondientes y evitar que las vistas se encarguen directamente de procesar las operaciones del sistema.

## Principios de Programación Orientada a Objetos

El proyecto contempla los siguientes principios:

- **Abstracción:** representar las características y comportamientos esenciales de las mascotas.
- **Encapsulamiento:** controlar el acceso a los atributos y métodos de las clases.
- **Herencia:** reutilizar características de la clase base `Mascota` en las clases específicas.
- **Polimorfismo:** permitir que los distintos tipos de mascotas implementen comportamientos particulares.

### Clases principales

El sistema conserva las siguientes clases definidas para representar a los pacientes:

- `Mascota`
- `Perro`
- `Gato`
- `Ave`
- `Tortuga`

## Estructura de datos

Se debe conservar la implementación de la lista desarrollada en la Práctica 1 para almacenar, buscar, actualizar y eliminar mascotas.

Por las restricciones de la práctica, no se debe sustituir esta implementación por `List<T>` ni por otra estructura de datos equivalente proporcionada por C#.

Los datos se mantienen en memoria mientras la aplicación permanece en ejecución. No se requiere una base de datos ni persistencia de datos para esta práctica.

## Requisitos previos

Para ejecutar el proyecto se necesita:

- Git.
- .NET SDK compatible con la versión de destino del proyecto.
- Un editor de código, como Visual Studio o Visual Studio Code.

## Instalación y ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/GabrielSales123/IPC2_Practica3_202505058_2S2026.git
```

### 2. Ingresar al directorio del proyecto

```bash
cd IPC2_Practica3_202505058_2S2026/SistemaVeterinaria
```

### 3. Restaurar las dependencias

```bash
dotnet restore
```

### 4. Ejecutar la aplicación

```bash
dotnet run
```

