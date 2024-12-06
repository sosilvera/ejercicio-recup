using System.ComponentModel;

public class Conjunto
{
    private List<string> _elementos; // Lista para guardar los elementos del conjunto

    public Conjunto(){
        _elementos = new List<string>(); // Inicializa la lista vacía
    }

    // Añade un elemento si no está ya en el conjunto
    public bool add(string elemento){
        bool exist = false;
        // Revisa si el elemento ya está en el conjunto
        for (int i = 0; i < _elementos.Count; i++){
            if (_elementos[i] == elemento){
                exist = true; // Marca como 'true' si el elemento ya existe
            }
        }
        // Si no existe, lo agrega
        if (!exist){
            _elementos.Add(elemento);
        }

        // Devuelve 'true' si lo añadió, 'false' si ya existía
        return !exist;
    }

    // Elimina un elemento del conjunto
    public bool remove(string elemento)
    {
        // Busca el elemento y lo elimina si lo encuentra
        for (int i = 0; i < _elementos.Count; i++){
            if (_elementos[i] == elemento){
                _elementos.RemoveAt(i); // Elimina el elemento
                return true; // Devuelve 'true' si lo eliminó
            }
        }

        // Devuelve 'false' si no encontró el elemento
        return false;
    }

    // Verifica si un elemento está en el conjunto
    public bool exist(string elemento){
        // Recorre la lista para ver si el elemento está
        for (int i = 0; i < _elementos.Count; i++){
            if (_elementos[i] == elemento){
                return true; // Devuelve 'true' si lo encuentra
            }
        }

        // Devuelve 'false' si no lo encuentra
        return false;
    }

    // Verifica si el conjunto está vacío
    public bool isEmpty(){
        return _elementos.Count == 0; // Devuelve 'true' si no tiene elementos
    }

    // Devuelve el primer elemento del conjunto
    public string get(){
        if (_elementos.Count == 0){
            return ""; // Si está vacío, devuelve una cadena vacía
        }
        else{
            return _elementos[0]; // Devuelve el primer elemento
        }
    }

    // Devuelve todos los elementos del conjunto en una nueva lista
    public List<string> getAll(){
        List<string> list = new List<string>();
        // Copia todos los elementos a la nueva lista
        for (int i = 0; i < _elementos.Count; i++){
            list.Add(_elementos[i]);
        }
        return list; // Devuelve la lista con todos los elementos
    }

    // Realiza la unión de este conjunto con otro
    public Conjunto union(Conjunto c){
        Conjunto conjunto = new Conjunto();

        // Añade todos los elementos de este conjunto
        for (int i = 0; i < _elementos.Count; i++){
            conjunto.add(_elementos[i]);
        }

        // Añade todos los elementos del conjunto 'c'
        List<string> list = c.getAll();
        for (int i = 0; i < list.Count(); i++){
            conjunto.add(list[i]);
        }

        return conjunto; // Devuelve el conjunto con la unión de los elementos
    }

    // Realiza la intersección de este conjunto con otro
    public Conjunto interseccion(Conjunto c){
        Conjunto conjunto = new Conjunto();

        // Añade los elementos comunes a ambos conjuntos
        for (int i = 0; i < _elementos.Count; i++){
            if (c.exist(_elementos[i])){
                conjunto.add(_elementos[i]);
            }
        }

        // Añade los elementos de 'c' que también están en este conjunto
        List<string> lista = c.getAll();
        for (int i = 0; i < lista.Count; i++){
            if (this.exist(lista[i])){
                conjunto.add(lista[i]);
            }
        }

        return conjunto; // Devuelve el conjunto con la intersección
    }
}