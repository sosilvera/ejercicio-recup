# Tipo de dato Conjunto:

Funciones:

- set(): Crea un conjunto vacío.
- add(elemento) -> bool: Agrega un elemento al conjunto, devolviendo true si el elemento fue añadido correctamente y false si el elemento ya existía en el conjunto.
- remove(elemento) -> bool: Elimina un elemento específico del conjunto, devolviendo true si el elemento fue eliminado correctamente, o false si el elemento no estaba presente.
- exist(elemento) -> bool: Verifica si un elemento está presente en el conjunto, devolviendo true si existe, y false si no se encuentra.
- isEmpty() -> bool: Verifica si el conjunto está vacío, devolviendo true si no contiene elementos, y false si tiene al menos un elemento.
- get() -> string: Obtiene un elemento del conjunto. Si el conjunto no está vacío, devuelve uno de sus elementos; si está vacío, devuelve una cadena vacía.
- getAll() -> List<string>: Obtiene todos los elementos del conjunto como una lista de cadenas.
- union(conjunto) -> Conjunto: Devuelve un nuevo conjunto que es la unión de este conjunto con el conjunto proporcionado, combinando todos los elementos sin duplicados.
- interseccion(conjunto) -> Conjunto: Devuelve un nuevo conjunto que contiene los elementos comunes entre este conjunto y el conjunto proporcionado.
