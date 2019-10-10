# c_sharp.tutorial.languaje
Un tutprial de 0 a 100 sobre C#, en el marco de desarrollo de .Net Core 2.2

# Introduccion


# Variables
Se usan para guardar informacion y ser usada posteriormente.

Deben ser declaradas e inicializadas antes de ser usadas.

Para declarar una variable debes seguir esta sintaxis:

tipo identificador;
int varName;

El tipo de una variable puede ser entero, caracter, cadena, fecha, boolean (logico), etc ...

El identificador es el nombre de la variable.

# Methodos
Los metodos son bloques de codigo que podemos ejecutar al invocarlos.

Pueden recibir valores de entrada, llamados parametros. Tambien pueden retorar valores si se desea.

# Entrada de datos
Todos los programas informaticos necesitan informacion por parte del cliente, de manera que necesitas crear una forma de pedirla y leerla.

Console.ReadLine(); => ayudara a obtener informacion ingresada por el usuario.

# Tipos de datos
Es simple y llanamente el tipo de informacion que guardas en una varaible

int, string, char, float, decimal, bool, etc... 

Una division aun mas tecnica y profunda es esta.

Tipos de valores:

1. Tipos simples
2. Enums
3. Struct
4. Nullables

Tipos de referencia:

Guardan una referencia del valor asignado, pero no el valor en si.

Cuando le asignamos el valor de una variable ya creada a una nueva variable.

int age = 22;
int peopleAge = age; // referencia

De esta manera si cambiamos el valor de age a 66 la varaible peopleAge seguira con el valor d e 22 que es el valor antiguo de age.

Se dividen en 4:

1. Clases (clase)
2. Interfaces (interface)
3. Arreglos (array)
4. Delegados (delegate)

# 
