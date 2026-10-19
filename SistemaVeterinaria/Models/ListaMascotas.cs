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

    public bool eliminarMascota(string codigo)
    {
        Nodo? actual = this.cabeza;

        while (actual != null && actual.mascota.GetCodigo() != codigo)
        {
            actual = actual.siguiente;
        }

        if (actual == null)
        {
            return false;
        }

        if (actual.anterior == null)
        {
            this.cabeza = actual.siguiente;
        }
        else
        {
            actual.anterior.siguiente = actual.siguiente;
        }

        if (actual.siguiente == null)
        {
            this.cola = actual.anterior;
        }
        else
        {
            actual.siguiente.anterior = actual.anterior;
        }

        return true;
    }

    public string siguienteCodigo()
    {
        return $"ID{this.cont + 1:D4}";
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