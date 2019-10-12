# c_sharp.tutorial.languaje
Un tutorial de 0 a 100 sobre C#, en el marco de desarrollo de .Net Core 2.2 aunque es C# asi que dara igual si lo haces en .Net Core o .Net Framework

# Introduccion
C# es un lenguaje de programación multiparadigma desarrollado y estandarizado por Microsoft como parte de su plataforma .NET, que después fue aprobado como un estándar por la ECMA (ECMA-334) e ISO (ISO/IEC 23270). C# es uno de los lenguajes de programación diseñados para la infraestructura de lenguaje común.

Su sintaxis básica deriva de C/C++ y utiliza el modelo de objetos de la plataforma .NET, similar al de Java, aunque incluye mejoras derivadas de otros lenguajes.

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

# Clases basicas
Las clases nos permiten definir una entidad con estado (variables, las cuales son llamadas propiedades) y comportamiento (metodos).

Es buena practica que las clases tengan responsabilidades definidas y que no sean exageradamente grandes (procura que todo lo que definas en ellas tenga relacion directa)

# Interferencia de tipos
Si defines una variable de tipo de string, debes asignarle una cadena de texto, entre "" claro esta, lo mismo si defines un tipo int, debes asignarle un numero.

Para evitar esto, C# cuenta con inferencia de tipos, por lo que puedes hacer esto:

var name = "Jhon" => C# interpretara que esa variable es de tipo string.

var age = 55 => interpretara que esta variable es de tipo int

de manera que con la palabra recervda "var" puedes hacer inferencia de tipos. 

NOTA: en la definicion de variables podemos declararlas sin necesariamente inicializarlas, en este caso no.

var price; => esto daria error, pues no le estamos diciendo a c# que tipo adquirira esta variable.

# Operadores
Nos permiten realizar operaciones con las variables, principalmente tocaremos el tema de los operadores aritmeticos.

(+ - * /) entre otros...

El tipo de resultado de una operacion aritmetica es el tipo del operando mas general. Osea, si sumamos un int y un long, el resultado sera un long, ya que puede almacenar mas cantidad de datos y pues obviamente si uno de los dos es de tipo long, necesitara ese tamano para guardar el resultado.

Tambien se uso para incremento y decremento:

1. x++ => se incrementa uno a la variable
2. x-- => se decrementa uno a la variable
3. a%b => da como resultado el residuo, osea: 15/2 = 7 y el residuo es 1, ese 1 es lo que devuelve esta operacion.

# Operaciones de relacion
Nos sirven apra comaprar dos valores. Su tipo de resultado es un boleano (true, false). Las operaciones de relacion mas comunes son:

igual que(==), diferente de(!=), menor que(<), mayor que(>), menor o igual(<=), mayor o igual(>=), is (is string, is int, is bool, is double, etc...)

a < b => nos compara si el valor de a es menor que el de b, si es cierto nos devuelve un true, si es falso nos devuelve false.

# Operaciones logicos
El tipo de resultado es boleano. y los operando tambien son de tipo boleano.

Algunas operaciones logicas son: 

1. Negacion (!)
2. Conjucion (&&)
3. Disyuncion inclusiva y exclusiva

# Trabajando un poco con DateTime (fecha)
Nos sirve para guardar fechas y horas.

Para manejar aspectos de tiempo en nuestro programa, saber cuantos dias hay entre una fecha y otra, agregarle meses a una fecha, agregarle anos, hacer resta entre fechas y devolver la cantidade de dias, meses, anos, horas etc... que hay como resultado de la resta.

# Bloques y alcance de variables

1. Bloques
Con bloques no referimos al codigo en el interior de dos llaves.

{
    ... codigo
    ... codigo
    ... mas codigo
}

2. Alcance
Cuando hablamos de alcance nos referimos a desde donde podemos referirnos o invocar una variable o metodo.

Si defino una variable en un metodo o ciclo, el alcance de esta se limita al bloque de dicho metodo o ciclo. O los bloques que esten dentro de el bloque de definicion.

NOTA: si desea usar una varible global en un metodo estatico, debes definirla como static.

Asi que podemos hacer 3 reglas:
1. Toda variable declarada en un bloque, la puedo utilizazr dentro del mismo, o de algun bloque hijo.
2. No puedes acceder a elementos definidos en bloques internos desde un bloque externo. Osea no puede acceder a una variable que ha sido definida en un bloque hijo, OJO: al reves si se puede.
3. Solo podemos acceder a una propiedad o variable la cual tenga como modificador de acceso el atributo public.
4. No puedes acceder a variables o propiedades definidas en bloques hermanos, osea, bloques definido dentro de la misma clase.

En caso de las clases, tienes acceso a sus propiedades(variables) "publicas" por medio de la instancia de la clase.

var instancia = new ClassName();
instancia.nombrePropiedad = "lo que sea";

Claro esta, en el caso de clase va a depender del modificador de acceso, ya que si es private no podras acceder a el desde otra clase que no sea la misma. Pero ya eso lo trataremos en el tema de modificadores de acceso.

# Strings en C#
Las cadenas de textos em C# son un tipo de dato que usaras muy a menudo, asi que debes tener un bune manejo de ellas.
Este tipo de dato tiene muchos metodos que nos resultan muy utiles en el desarrollo.

1. Length => saber la cantidad de caracteres de una cadena
2. Substring() => nos permite hacer una cadena secundaria en base a una principal, tenemos que pasarle como parametro el numero del caracter con el cual empezara la cadena.
3. StartsWith() => se usa para saber su un string empieza con una subcadena especificada como parametro, Ojo: ten en cuanta las mayusculas y minusculas, es sencible a ellas, de manera que si esta "Joseph" pero le pasas como parametro "joseph" retornara false, y no solo al inicio, sin importar donde este la mayuscula debes ponerlo exactamente igual, en caso de que lo que quieras validar este con mayusculas.
4. EndsWith() => se usa para saber su un string termina con una subcadena especificada como parametro. Ojo: tambien es sencible a mayusculas y minusculas
5. Contains() => se usa para saber si un string contiene una subcadena, sin importar que sea al final o al inicio o en el medio. Ojo: tambien es sencible a mayusculas y minusculas
6. IndexOf() => nos retorna el numero en el cual se encuentra la subcadena que especificamos, y sino se encuentra, nos lanzara un -1
7. operador (+) => concatenacion o unir cadenas

Los siguientes son usados a las hora de validar datos, por ejemplo, poner todo minusculo o mayuscula, quitar espacios y demas.

8. ToLower() => para hacer todos los caracteres de una cadena minusculas.
9. ToUpper() => para hacer todos los caracteres de una cadena mayusculas.
10. Trim() => eliminara los espacios tanto al inicio como al final de una cadena
11. Format() => te permitira mostrar variables dentro de una cadena de manera mas simple, integrando dentro de la cadena indices = {0}, {1}, {2}
12. Replace() => reemplazara un caracter de la cadena especificado por otro caracter que se pasara como parametro, se puede utilizar para quitar cualquier caracter no alfabetico
13. Equals() => se utiliza para comparar si una cadena es igual a otra
14. Split() => dividira la cadena en base al caracter especificado. ejemplo: "Esta es una cadena" si la quieres dividar por cada espacio usas Split(" "); y listo. si te fijas se pasa el caracter de espacio como parametro.
15. IsNullOrWhiteSpace() => nos retorna true si la cadena pasada como parametro es nula (null) o solo son espacios en blancos ("   ")
16. IsNullOrEmpty() => nos retorna true si la cadena pasada como parametro es nula (null) o esta vacia ("")

# Condicional if


# Ciclo for


# Ciclo foreach


# Ciclo while


# break y continue


# enums y "numeros magicos"


# Strings "magicos"


# namespace y using


# Comentarios


# try/catch


# Nullables
