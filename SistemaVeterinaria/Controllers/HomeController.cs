using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaVeterinaria.Models;

namespace SistemaVeterinaria.Controllers;

public class HomeController : Controller
{
    private readonly ListaMascotas mascotas;
    public HomeController(ListaMascotas mascotas)
    {
        this.mascotas = mascotas;
    } 

    [HttpGet]
    public IActionResult Index()
    {
        return View(mascotas.getMascotas());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult Agregar(string especie, string nombre, 
    int peso, int edad, string sexo, string propietario, 
    string codigo, bool enfermo, string? razaPerro, string? tamanoPerro,
    string? razaGato, bool? esterilizado, string? tipoCaparazon, bool? esAcuatica,
    int? envergadura, bool? volador )
    {
        codigo = $"ID{mascotas.contMascotas() + 1:D4}";
        Mascota nuevaMascota;
        

        switch (especie)
        {
            case "Perro":
                nuevaMascota = new Perro(nombre, peso, edad, sexo, propietario, codigo, enfermo, razaPerro!, tamanoPerro!);
                break;
            case "Gato":
                nuevaMascota = new Gato(nombre, peso, edad, sexo, propietario, codigo, enfermo, esterilizado!.Value, razaGato!);
                break;
            case "Tortuga":
                nuevaMascota = new Tortuga(nombre, peso, edad, sexo, propietario, codigo, enfermo, tipoCaparazon!, esAcuatica!.Value);
                break;
            case "Ave":
                nuevaMascota = new Ave(nombre, peso, edad, sexo, propietario, codigo, enfermo, envergadura!.Value, volador!.Value);
                break;
            default:
                return BadRequest("Especie no válida");
        }
        mascotas.agregarMascota(nuevaMascota);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Details(string? id)
    {
        if (string.IsNullOrWhiteSpace(id))
        return BadRequest();
        Mascota? mascota = mascotas.consultarMascota(id);
        if (mascota is null)
        return NotFound();

    return View(mascota);
}

    [HttpGet]
    public IActionResult Edit(string? id)
    {
        if (string.IsNullOrWhiteSpace(id))
            return BadRequest();
        Mascota? mascota = mascotas.consultarMascota(id);

        if (mascota is null){return NotFound();}
        return View(mascota);
    }

    [HttpPost]
    public IActionResult Edit(
        string id,
        string nombre,
        int peso,
        int edad,
        string sexo,
        string propietario,
        bool enfermo)
    {
        Mascota? mascota = mascotas.consultarMascota(id);
        if (mascota is null){return NotFound();}
            mascota.SetNombre(nombre);
            mascota.SetPeso(peso);
            mascota.SetEdad(edad);
            mascota.SetSexo(sexo);
            mascota.SetPropietario(propietario);
            mascota.SetEnfermo(enfermo);
            return RedirectToAction(nameof(Details), new { id });
    }   
}
