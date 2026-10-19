namespace SistemaVeterinaria.Models
{
public class ListaMascotas
{
    private Nodo? cabeza {get; set;}
    private Nodo? cola {get; set;}
    private int cont;

    public ListaMascotas()
    {
        this.cabeza = null; 
        this.cola = null;
        this.cont = 0;
    }

    public void agregarMascota(Mascota mascota)
    {
        Nodo nuevoNodo = new Nodo(mascota);
        if (cabeza == null)
        {
            this.cabeza = nuevoNodo; 
            this.cola = nuevoNodo; 
        }
        else
        {
            nuevoNodo.anterior = this.cola;
            this.cola.siguiente = nuevoNodo; 
            this.cola = nuevoNodo; 
        }
        this.cont ++; 
    }
    public Mascota? buscar (String codigo)
    {
        
        Nodo? actual = this.cabeza;
        while(actual != null){
        if(actual.mascota.GetCodigo() == codigo)
        {
            return actual.mascota;
        }
        }
        return null;
    }

    public Mascota? consultarMascota(string codigo)
    {
        Nodo? actual = this.cabeza;
        while (actual != null)
        {
            if (actual.mascota.GetCodigo() == codigo)
            {
                return actual.mascota;
            }
            actual = actual.siguiente;
        }
        return null;
    }

    public int contMascotas()
    {
        return this.cont; 
    }

    public IEnumerable<Mascota> getMascotas()
        {
            Nodo? actual = this.cabeza;
            while (actual != null)
            {
                yield return actual.mascota;
                actual = actual.siguiente;
            }
        }

        
}
}