class Program
{
    static void Main(string[] args)
    {
        var set = new Conjunto();

        // Agregar elementos
        set.add("hola");
        set.add("chau");
        set.add("hello");
        set.add("googbye"); // Duplicado, no se agregará

        // Verificar existencia
        Console.WriteLine(set.exist("dos")); // True
        Console.WriteLine(set.exist("cinco")); // False

        // Eliminar un elemento
        set.remove("dos");
        Console.WriteLine(set.exist("dos")); // False
    }
}
