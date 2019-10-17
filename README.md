# c_sharp.tutorial.languaje
Un tutorial de 0 a 100 sobre C#, en el marco de desarrollo de .Net Core 2.2 aunque es C# asi que dara igual si lo haces en .Net Core o .Net Framework

# Introduccion
C# es un lenguaje de programación multiparadigma desarrollado y estandarizado por Microsoft como parte de su plataforma .NET, que después fue aprobado como un estándar por la ECMA (ECMA-334) e ISO (ISO/IEC 23270). C# es uno de los lenguajes de programación diseñados para la infraestructura de lenguaje común.

Su sintaxis básica deriva de C/C++ y utiliza el modelo de objetos de la plataforma .NET, similar al de Java, aunque incluye mejoras derivadas de otros lenguajes.

# PRIMER MODULO

# Variables
Se usan para guardar informacion y ser usada posteriormente.

Deben ser declaradas e inicializadas antes de ser usadas.

Para declarar una variable debes seguir esta sintaxis:

tipo identificador;
int varName;

El tipo de una variable puede ser entero, caracter, cadena, fecha, boolean (logico), etc ...

El identificador es el nombre de la variable.

Se pude realizar el casteo de tipos o conversion de tipos, que no es mas que signarle un tipo a un dato antes de asignarlo a una variable de un tipo definido. Ejemplo:

float fDays = 56.36;
int day = fDays; // nos dara error asignarle un float a un int, pero
int day = (int)fDays; // lo convertimos antes de asignarlo y listo o tambien podemos hacerlo de esta manera
int day = Convert.ToInt32(fDays);

Mas informacion sobre el casteo o conversion de tipo en este link:

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions

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

Estos no son todos los metodos de string, si necesitas alguna funcionalidad que estos no te dan, puedes consultar la documentacion de Microsoft, este es el enlace que te lleva al tema de los string:

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/

# Condicional if
Nos sirve para decidir que hacer con el resultado de comparaciones logicas.

Otra definicion mas tecnica es, que nos permite ejecutar cierto bloque de codigo si se da una condicion establecida.

si (esta lloviendo) entonces (llevas paraguas).

Puedes usar mas de un condicional:

if(){

}
else if(){

}else{

}

En resumen, usaras la condicional if para tomar decisiones en base a una comparacion logica, validaciones y demas.

Existe una forma corta de crear una expresion if, es esta:

if() ? instruccion_si_es_verdadero : instruccion_si_es_falso;

Si quires saber mas sobre el, aui esta el link a documentacion oficial.

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator

# Ciclo for
El ciclo for es por mucho uno de los ciclos mas usados en lo que al desarrollo se refiere. ya que te permite hacer una x operacion cantidades de veces previamente fijadas. Como se vio en el ejemplo de string, para mostrar un array.

Podemos usarlo para recorrer o llenar arreglos, listas (aunque para las listas el bucle perfecto es el foreach), pero en fin, para todo que tenga que  ver con repetir algo una cantidad x de veces.

for(valor_de_inicio; valor_final; valor_a_sumar)
{
    ... codigo
    ... codigo
    ... codigo
}

# Ciclo foreach
El ciclo foreach es mas completo por asi decirlo, y como se menciono anteriormente es perfecto para las listas, podria decirse que es un ciclo for con esteroides.

Su estructura es la siguiente:

foreach(tipo_de_dato nombre_que_tendra in nombre_de_la_lista)
{
    Console.WriteLine(nombre_que_tendra);
}

Ya en codigo seria asi:

foreach(string name in names)
{
    Console.WriteLine(name);
}

OJO: el tipo de dato, debe coincidir con el tipo de dato de la lista, pues en si lo que hacemos es una clonacion momentanea de cada dato de la lista en este, asi que tiene que  ser el mismo o dara error.

NOTA: Otra diferencia bastante importa es el hecho de que no puedes modificar el valor de la variable que defines para iterador (nombre_que_tendra), ya que es una variable del bucle en si.

# Ciclo while y do while
Son ciclos basados en repetir un bloque de codigo las veces que sea necesario hasta que sus condicionales se dejen de cumplir:

1. while()
Este ciclo se basa en repetir un bloque de codigo siempre y cuando la condicion que se le pasa como parametro sea verdadera, es muy usada a la hora de hacer menus en consola.
Su principal diferencia con el ciclo do{ ... }while() es que el while() primero examina y luego hace.

while(true)
{
    ... codigo
    ... codigo
}

2. do{ ... }while()
En escencia es lo mismo que el while, solo que lo usamos cuando queremos que se ejecute el bloque de codigo al menos una vez. En si, el do while primero ejecuta y luego compara.

do{
    ... codigo
    ... codigo
}while(true)

Siempre recuerda, el do while() ejecuta el codigo al menos una vez, y luego compara a ver si la expresion es true, asi que ten cuidado, su mayor fortaleza tambien es su mayor debilidad.

Aunque se puede hacer algo para que se salga del proceso por "x" o "y" razon, eso lo veremos en el proxima capitulo.

# break y continue
En si son sentencias de escapes. 

1. break
Lo utilizamos para detener la ejecucion de un proceso, no necesariamente el bucle while o do while,tambien sirve en el for.

En palabras simples detiene de forma arbitraria un proceso ciclico, por ejemplo, si pides dos numero para mostrar de inicio a final, pero el usuario ingreso un numero final, extremedamente grande, puedes verificar si el numero ingresado es mayor que (500000) por ejemplo, haces el break. Y no ejecutas nada.

2. continue
Ignora el resto de codigo dentro del ciclo utilizado, asi que tecnicamente continue equivale a llegar al final del ciclo y vuelve a ejecutar la comparacion del inicio, pero obviamente vuelve a ejecutarse. De manera que al llegar al continue, el bucle vuelve a examinar la condicion.

Lo podemos utilizar cunado en un ciclo necesitamos ignorar "x"  o "y" valor o resultado.

# enums y "numeros magicos"

1. enum
Un tipo de enumeración proporciona una manera eficiente de definir un conjunto de constantes integrales con nombre que pueden asignarse a una variable. Por ejemplo, suponga que tiene que definir una variable cuyo valor representará un día de la semana. Solo hay siete valores significativos que esa variable almacenará alguna vez. Para definir esos valores, puede usar un tipo de enumeración, que se declara mediante la palabra clave enum .

Estas enumeraciones de variables se pueden usar por ejemplo en estados de ejecucion.

enum NombreDeLaColeccion {
    nombre_identificador = numero_o_cadena_que_vale,
    nombre_identificador = numero_o_cadena_que_vale,
    nombre_identificador = numero_o_cadena_que_vale,
};

Ejemplo:

enum OperationsStatus 
{
    Succesful = 1,
    ClientNotFound = 2,
    InternError = 5
};

Una ventaja de los enums es el hecho de que lo usas globalizado, de manera que si cambias un valor en el enum este valor cambiara en todos los lugares en donde lo invoques. Garantizando la integridad de tu codigo.

Si necesitas mas informacion pues aqui te dejo un link:

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/enumeration-types

2. numeros magicos
En si es un anglosajismo, y llamamos numero magico a todo aquel numero "hardcodeado" que facilmente se te olvida su proposito.

ejemplo:

if(variable == 1)
{
    ... codigo
}

Quizas en el momento en el que hagas el codigo, te acuerdas que vale, pero unos meses despues, o una persona que no seas tu se le volvera un caos la cabeza para saber que es eso.

# Strings "magicos"
Al igual que con los numeros magicos, se puede dar el caso con cadenas. Al igual que con los numeros se puede solucionar globalizando estos valores en un enum.

# namespace y using
Todo tu codigo no va a estar en un solo archivo, al ir creciendo utilizaras carpetas las cuales deberas ordenar tanto en orden de prioridad y poder como dentro de los archivos mismos. Para esto se usan los namespace y los using.

Si creas un archivo extra en una carpeta de tu proyecto con la ruta:

ruta_del_proyecto/NombreApp/UserMetodos

para acceder a este desde el archivo c# debes usar el using e incluir el namespace, seria algo como esto:

using System; // este siempre esta  por defecto
using NombreApp.UserMetodos;

En si es el uso basico, y obviamente mientras mas subcarpetas tengas mas largo sera el namespace.

# Comentarios
Son utilizados para documnetar el codigo, osea:
Que hace ese codigo que le sigue? de esta manera tu mismo timepo despues o alguien mas que vaya a mantener tu codigo, sabe que hacer en caso de error o refactorizacion

NOTA: aunque el objetivo de los comentarios es hacer el codigo mas entendible. ES TOTALMENTE INNECESARIO COMENTAR CODIGO QUE SEA MAS QUE OBVIO SU COMPORTAMIENTO POR EJEMPLO:

*UN IF QUE COMPARE DOS VARIABLES
*UN CICLO FOR QUE LLENE O VACIE UN ARREGLO
*UN FOREACH QUE MUESTRE UNA LISTA, ETC

Es mas comun usarlos en:

1. Consultas a base de datos (ORM), ya que puedes hacer consultas muy complejas con el uso de EF y LINQ.
2. Al recorrer arreglos multidimensionales.
3. En todo codigo con complejidad cuestionable.

En resumen, has comentarios utiles.

Tip:
Si quieres hacer un comentario rapido hay combinacion de teclas:

Visual Studio 2015, 2017, 2019 => (Ctrl K + C)
Visual Studio Code =>  (Ctrl + /)

Otro tipo de comentario es para las clases y metodos que hacemos, por lo general al usar una clase o metodo nos muestra las opcioens de clases y metodos publicos que tenemos, pero podemos agregar una descripcion que nos muestre al acceder a ella.

///<sumary>
/// Description breve de la clase
///</sumary>

Este pues es opcion, pero sirve de mucho a la hora de invocar las clases.

RECUERDA: a veces mas que explica el que, es mejor explicar el porque de las cosas (propiedades, clases, metodos) en tus comentarios.

# try/catch
En algun momento nuestro programa dara un error, de manera que necesitaremos una directiva para preever que esos errores hagan crashear nuestra app. Para esto existe try/catch.

En si lo usamos cuando las probabilidades de error sean altas:

1. Al conectar con una base de datos
2. Al hacer un httpRequest a una api
3. Al hacer un query a una base de datos
4. Si sospechamos que el usuario puede ingresar un dato invalido

Algo a resaltar es el hecho de que puedes especificar el catch que deseas ejecutar, los cuales pueden ser dependiendo de la operacion realizada, y puedes combinar catch demanera que puedes incluir dosx tres, cuatro, aunque cuidado, tampoco llenes tu codigo de catch, con poner el catch correspondiente a la excepcion esperada y un cath por defecto es mas que suficiente:

1. IndexOutOfRangeException
2. DivideByZeroException
3. Exception (por defecto), entre otras...

Y solo se ejecutara el cath que cumpla con la exception creada o el por defecto.

Hay otra instruccion que es parte del try{}catch() y es el finally{}el cual se de la excecion o no se de, siempre se va a ejecutar el codigo que esta alli. Nos puede servir para liberar recursos, alguna instancia, conecion a base de datos etc...

Su sintaxis es:

try{
    ... codigo que puede dar algun error
}catch(Exception ex)
{
    ... codigo para ejecutar en caso de que suceda un error o excepcion
}finally
{
    ... codigo que se ejecutara de todas formas
}

Ejemplo: 

Dividir un numero entre 0.

try{
    int div = 4 / 0;
}catch(Exception ex)
{
    Console.Write("Error, no se puede dividir entre 0");
}finally
{
    Console.Write("Esto se muestra obligatoriamente");
}

Obviamente el mensaje de error es enviado en base al error dado, en este caso por la division entre cero.

Asi que ya sabes, el try{}catch() es para correr codigo que posiblemente de error.

OJO, OJO, OJO: => Sino tinees idea de que excepcion puede lanzar tu codigo, siempre coloca el exception por defecto detras del exception que crees que puede ejecutarse.

# Nullables
Nos permiten darle por defecto un null a cualquier tipo de valor, o declara una varibale de tipo "x" que a la hora de asignarle valor puede ser null.

Tiene una sintaxis larga u otra corta:

1. Nullable<tipo_de_dato> nombre_variable; => se especifica explicitamente con el Nullable
2. tipo_de_dato? nombre_variable; => se le agrega un signo de (?) para indicar que puede ser nulo.

Si declaraste un nullable y quieres saber si tiene valor usa la propiedad HasValue:

nombre_variable.HasValue => si tiene valor retorna true

NOTA: un tipo de dato con nullable no es lo mismo que el mismo tipo de dato sin el nullable.

DateTime? != Datetime
int? != int

si necesitas pasar un nullable a un metodo y recibe un tipo de dato no nullable, debes pasarlo de esta manera:

nombre_variable.Value => con la propiedad (Value) envia el valor en si de la variable no la variable como tal. Obviamente primero debes hacer una condicional para saber que la propiedad nullable tiene un valor.

# SEGUNDO MODULO

# Constructores
Es el primer metodo que se ejecuta al instanciar una clase.

Se usa principalmente para inicializar propiedades como asignar un valor a una propiedad antes de ser usada en un metodo, o hacer un request y almacenar el resultado para utilizarlo posteriormente.

Se  pueden definir contructores a tu gusto, aceptando parametros distintos obviamente.

Existe un shorcut para declaralos:

1. Visual Studio (2015, 2017, 2019, etc..) => ctor luego pulsar Tab.
2. VS Code => ctor y presionas Enter.

Rara vez un constructor pasa de 5 linea de codigo.

# Campos y propiedades

1. Campo
Es una varible definida en el bloque de una clase. Ose no defina en un metodo, ni en una estructura ni enum sino en la clase en si. Ejemplo:

class NameClass
{
    private int varName; => esto es un campo

    public void MethodName()
    {
        ... codigo
    }
}

Por lo general los campos son de tipo privado, ya que gran parte de las veces almacenaran informacion delicada.

2. Propiedades
Son todas aquellas variables que son accesibles desde fuera de la clase. Por lo general son accesibles desde fuera mediante la instancia de la clase que la contiene.

Nos permiten encapsular la logica de la lectura y escritura de las variables o campos de una clase.

Su sintaxis es esta:

public tipo_dato nombre_variable { get; set; }

Existe un shortcut para escribirla de manera rapida que es: prop luego presionas Tab y te creara un template de esta manera:

public int Properties { get; set; }

# Indexadores
Nos permite acceder al index "x" de una colecion en un campo de clase o propiedad en si.

Los indexadores permiten que las instancias de una clase o estructura se indexen al igual que las matrices. El valor indexado se puede establecer o recuperar sin especificar explícitamente un tipo o miembro de instancia. Los indexadores se parecen a las propiedades, excepto que sus accesores toman parámetros.

De manera que asi como accedemos a un valor de un campo por medio de una propiedad. La sintaxis es esta:

public tipo_del_valor_a_devolver this[int index]
{
    get
    {
        return nombre_del_campo[index];
    }
    set
    {
        nombre_del_campo[index] = value;
    }
}

OJO: El campo es mas que obvio que debe ser un coleccion.

El tema es un poco extenso para entenderlo en su totalidad, asi que aqui te dejo un link a la documentacion oficial:

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/

# Metodos
Nos permite hacer un bloque de codigo asignarle un nombre que por lo general tiene que ver con la funcion que hacen, podemos pasarles parametros y retornar un tipo de valor.

En parte nos permite ahorrar muchas lineas de codigo a la hora de hacer una accion determinadas cantidades de veces. Asi que usaras metodos tecnicamente para todo.

Su sintaxis es esta:

modificador_de_acceso tipo_de_retorno nombre_metodo(tipo_de_parametro nombre_local_del_parametro)
{
    ... codigo
    ... codigo
}

Ejemplo:

public int Sumar(int valor1, int valor2)
{
    return valor1 + valor2;
}

Obviamente puede ser private, static, o puede retornar un double o no retornar nada, o aceptar 5 parametros o ninguno.

# Operaciones en las clases
Podemos crear operaciones en nuestras clases en base a los operadores conocidos habitualmente.

(+ - / *) => son los operadores mas conocidos
(++, --) => puedes definir estos operadores en una clase para que al invocar la clase, por ejemplo le sume uno a cada parametro, vector o lo que sea, o restarle uno, o sumarle una cantidad especifica, etc... 

La sintaxis es muy simple:

public static valor_retorno operador operador_a_usar(parametros)
{
    ... codigo
    ... codigo
}

Seria asi:

public static int operador ++(int numero)
{
    return numero++; 
    (o podrias retornar)
    return numero + un_valor_especificado;
}

# Struct
Una estructura (struct) es un tipo de "valor" que podemos definir. No te confundas con las clases ya que las clases es un tipo de "referencia" que podemos definir.

Tecnicamente puedes poer todo lo de una clase en una estrutura:

1. Campos
2. Propiedades
3. Indexadores
4. Constructores
5. Metodos

Entonces cual es su diferencia o cuando debemos usar una clase y cuando una estructura:

* Una estructura la vamos a usar cunado nuestras instancias tenga un tiempo de vida corto, tenga pocos datos, no tenemos necesidad de "castear" mucho y que sus funcionalidades sean pequenas.

(Castear) => se refiera a la practica de cambiar el tipo de valor de forma implicita o explicita. Sucede cunado por ejemplo haces la suma de int y un double el double es mas grande en memoria, de manera que el rersultado se castea a double. O cuando delante de la variable ponemos (double) o (string) o (int). Eso ya lo consideramos en el primer tema de las variables y tipos.

Este tema es simple pero algo delicado aqui te dejo un link con todo y ejemplos para que entiendas bien:

https://social.msdn.microsoft.com/Forums/es-ES/e44f9b6e-760a-4fc1-b5fa-afd675e9e002/explicacion-castear?forum=dcees

Ejemplo:
Instanciamos una estructura usamos un metodo u obtenemos un valor y ya.

* Una clase la vamos a usar cuando debemos modelar comportamietnos y datos mas complejos que se pretenden modifciar despues de crear un objeto de la clase.

En resumen, para cosas sencilla struct, para cosas grandes, complicadas y requira seguridad deberas usar clases.

# Sobrecarga de metodos
A veces necesitamos hacer una accion del mismo nombre pero con diferente numeros de parametros o con parametros iguales pero de distintos tipos. Para esto usamos la sobrecarga de metodos.

Para usar sobrecarga deben cumplirse algunos requisitos:

1. Hacer la misma funcionabilidad
2. Que los parametros no sean la misma cantidad
3. En caso de que sea la misma cantidad deben ser de tipos distinto

NOTA: No puede crear un metodo que retorne int y otro que retorna double con la misma cantidad de parametros y tipos, ya que C# no inferira en cuando llamas a cada uno, dara error.

# Params
Nos facilita la tarea de pasar parametros a los metodos, sea con sobrecarga o sin ella. En si nos permite pasar un sin numeros de parametros a nuestros metodos sin estar anteriormente definidos, OJO: los parametros enviados tienen que ser del mismo tipo ya que en si lo que hace params es un arreglo de parametros (hace que los parametros se acumulen en un array y obviamnete tienen todas las propiedades de un array => length, etc...)

private int Calcular(params int[] numeros)
{
    ... codigo
    ... codigo
}

private double Calcular(params double[] numeros)
{
    ... codigo
    ... codigo
}

Pero tampoco abuses de su uso, recuerda que n el desarrollo mientras mas especifico mejor.

# Argumentos opcionales o valores por defecto
Al crear un metodo y definir dos valores de entrada, podemos hacer que esos valores tenga un valor por defecto, en caso de que al invocarlo solo se envie algunos de los valores necesitados. Lo hacemos de manera muy simple:

private void NombreMetodo(string name, int age = 18)
{
    ... codigo
    ... codigo
}

En esta definicion decimos que recibimos dos valores un string y un int, y que en caso de que al invocar el metodo no se ingrese el int pues tomara por defecto el valor de 18. Simple, facil, sin perdedera.

OJO: Los valores por defecto te pueden ocasionar problemas principalmente si el metodo que lo implenta esta en un asembly, dll distinta de la que estas trabajando. Es tanto el caso de que si agregas un valor por defecto a un metodo debes recompilar todos los proyectos de la solucion, en caso de que sean mas de uno, visual studio tiene la opcion de hacer un "rebuild", es recomendable hacer el rebuild cuando se hacen cambios importantes y a la hora de agregar un nuget.

NOTA IMPORTANTE: Si vas a usar una dll para hacer referencia a ella desde un proyecto "x" de manera que los metodos deberas ponerlos "public" asi no te recomiendo usar valores por defecto, mejor usa sobrecarga de metodos.

# Objetos y contextos
Algo que debe quedar claro es que el valor que se asigna en una instancia es unico, osea lo que hago con:

var ni = new NombreClase();
var oi = new NombreClase();

Sin importa lo que pase, el valor y contexto de la instancia ni sera diferente de la instancia oi.

la palabra reservad "this" indica que estamo trabajando con miembros de la clase en el contexto que estamos.

# Metodos de extencion
Nos permite agregarle acciones o funcionabilidades a una estructura ya creada la cual no controlamos.

Por ejemplo si quieres agregar una funcionabilidad a un tipo especifico de valor (int, double, string, bool).

La clase debe ser static y el metodo por ende tambien debe ser static, su sintaxis es mas o menos esta:

public static class NombreDeLaExtencion
{
    public static double NombreDeLaFuncion(this int value, int exponente)
    {
        ... codigo
        ... codigo
    }
}

Explico:

1. Es recomendable que el nombre de la extencion comience cono el tipo de dato que manejara, ejemplo:

int => IntegerExtencionMethod
doube => DoubleExtencionMethod
string => StringExtencionMethod, y asi por el estilo

2. El metodo en si, debe retornar algun valor, y se especifica el tipo de valor como siempre se hace => public static tipo_de_valor NombreMetodo().
3. El nombre del metodo procura que sea bien descriptivo.
4. El primer parametro que le precede la palabra this y luego el tipo, es la refencia que le damos a C# de hacia que tipo de valor esta orientada esa extencion. Y pues, en si representa el valor en si al cual estamos invocando ese metodo.

int => this int value: el value puede ser cualquier otro nombre
double => this double value
string => this string value

Y luego de esto, los parametros, si son necesarios.

Al guardar y manejear datos del tipo que hiciste la extencion ya debe aparecer el metodo que acabas de crear como extencion.

NOTA: Para usar la extencion en el tipo creado, debe estar definido como tal, no acepta la conversion explicita ni implicita asi que debes definir la variable del  tipo corrrecto para invocar la extencion previamente hecha.

# Clases y miembros estaticos
Son clases que no son instanciadas, osea no tienes que crear un objeto de referencia. Por tanto al no tener instancias no tienen datos separados (como sabemos las instancias guardan datos diferentes segun la instacia invocada), en el caso de las static no.

Son especialmente utiles cuando:

1. Necesitamos metodos que retornen un valor en base a parametros que no se necesite mantener en memoria (osea envio retorna y ya).
2. Necesitamos procesos que no se mantengan en memoria.

Para acceder a los campos, propiedades, metodos de una clase static no debemos instanciarla como bien dijimos, incluimos el using, y solo escribimos el nombre de la clase mas el punto y se mostrara la lista de propiedades y metodos que hallas creado en ella. La sintaxis seria esta:

NombreClaseStatic.NombreMetodo(parametros_si_los_necesita);

Si retorna algun valor pues se le asigna a una variable del tipo de retorno y listo.

Algunos de los inconvenientes es que las clases estaticas solo se comunican con metodos estaticos. Para acceder de manera indirecta debemos instanciar la clase padre en la que estamos y accedemos a ese metodo por via de dicha clase.

OJO: Una clase estatica no puede tener metodos de otro tipo que no sean estaticos, pero una clase normal por asi decirlo, si puede tener metodos estaticos. Para acceder a los metodos estaticos no hay que instanciar la clase, osea para acceder a los metodos estaticos sea la clase estatica o no, accdesmo a ellos directamente con el nombre de la clase.

# Encapsulamiento
Consiste en esconder los detalles de la implementacion de un tipo.

En palabras mas simples, mantener oculto todas las variables y procesos que se llevan a cabo en una clase.

Por ejemplo a la hora de acceder a los campos es bueno utilizar propiedades las cuales por medio de get (acceder) y set(asignar) pueden manejar la data de los campos pero no invocarlos en si.
De esta manera puedes incluso agregar algunas condicionales en caso de que el valor sea null, y asi por el estilo.

Como extra inicializa los campos con valores por defecto, de esa manera en caso de que no se le asigne nada, puede no mostrar nada pero sin errores.

# Herencia
Es utilizar metodos y propiedades publicas o protegidas (las privadas no) para usar el codigo mas eficientemente, pero antes de que te vuelvas loco entendiendo esto dejame explicarte algunos conceptos.

1. Clase padre => es la clase de la cual se derivan las demas.
2. Clase derivada => son las clases hijo de la clase padre.

OJO: las clases padre es tu papa o tu mama, la clase derivada eres tu, de la misma manera en la que si tus padres mueren heredas dinero, casa auto o algo, al tomar herencia en las clases heredas metodos, propiedades etc.. Esto es solo una ilustracion para que entiendas mejor.

Consejos:

Ala hora de crear una clase padre, toma en cuenta esto:

1. Debe tener todas las propiedades comunes de las clases derivadas. Ejemplo:

Vaca { nombre, patas, peso, color, tipo_de_cola }
Perro { nombre, patas, peso, color, tipo_de_cola }

Si te fijas tienen propiedades en comun, en este caso todas, pero eso es solo porque no he pensado en mas propiedades, el punto es que la clase padre animal toma todas las propiedades comunes de las derivadas asi que seria de esta manera:

Animal { nombre, patas, peso, color, tipo_de_cola }
Vaca {  }
Perro {  }

Como ya dije todas las que tenian eran comunes, pero obviamente se quedaran con las propiedades que sean unica y exclusivamente de ellas.

2. Al igual que con las propiedades tambien debe tener los metodos comunes, solo que con la palabra reservada (virtual) para que posteriormente en la clase hijo se use el (override) para modificar el comportamiento de dicho metodo. El ejemplo de esto lo veras en el codigo.

Algo que debes saber que de hecho es obvio, es que la herencia puede pasarse de una clase a otra osea:

class Animal
{
    ... codigo
}

class Perro : Animal
{
    ... codigo
}

class Doberman : Perro
{
    ... codigo
}

Perro hereda de Animal y Doberman hereda de perro y asi sucesivamente.

# Polimorfismo
Nos permite pasarle a un metodo un tipo el cual puede exponeer varios miembros, como por ejemplo pasarle clases hijos como parametros cuando en realidad espera clase padre, aparte del hecho de que a la hora de instanciarlo, se puede definir como un tipo y pasarle una cllase hijo como valor, osea:

ClassA clsB = new ClasB();

Obviamente ClassB() es hija de ClassA(), por eso podemos declararlo como parte de ella, de lo contrario daria error.

De igual manera podemos pasarle como parametro la clase hija, siempre y cuando el tipo sea de la clase padre.

NombreMetodo(ClassA clsA);
le pasamos como parametro la clase hija:
NombreMetodo(clsB);

Porque sucede esto?

Porque al ser hijos de la clase padre, C# esta completamente seguro de que van a implementar el metodo llamado por parte del padre, ya que lo heredan de el.

A esto llamamos polimorfismo por herencia.

Existe otra polimosfismo que es el que usamos con interfaces, ese lo veremos mas adelante.

# Modificadores de acceso
Nos permiten definir el tipo de accesibilidad de un tipo o de un miembre (propiedad, metodo, etc...).

Son los siguientes:

1. public => todos los que tengan acceso a las clase/estructura en donde esta definido puede utilizarlo.
2. protected => solo aquellas clase que herede de dicha clase puede utilizarlo, (de mas esta decir que la misma clase en si puede usarlo). OJO:  puedes usarlo en la clase que hereda pero al instanciar la clase hijo no tienes acceso, osea no se hereda para instancias solo para uso dentro de la clase.
3. private => solo puede usarlo la clase en donde se define.
4. internal => limita el uso de una clase, estructura, metodo y/o propiedad a un proyecto en si, osea no tenemos acceso a la propiedad por medio de referencia ni nada por el estilo. En palabras mas simples, internal es como un public, pero solo para los archivos que se encuentran en el mismo proyecto.

Ejemplo:

*****************

Tu padre puede prestarle una planta, un pico, una pala a un vecino. Entonces esto es de tipo public.

De tu padre puedes heredar el auto, la casa, porque eres hijo en si de el. De manera que estas cosas son protected, solo los puedes heredar tu.

No puedes heredar tu madre, es solo de tu padre, de modo que tu madre es private.

No puedes darle la llave de la casa a nadie mas que no sea alguien de tu familia, por tanto las llaves de la casa son de tipo internal.

*****************

Son algunas ilustraciones al raras pero espero que te hallan funcionado.

# Interfaces
Es un contrato el cual obliga a la clase que la hereda a definir todos los metodos que se encuentran en ella.

Al igual que con las clases padre e hijos, C# asegura que toda clase que herede una interfaz define cada uno de los metodos que esta posee, por tanto podemos pasarle un tipo de la clase que tenemos cuando se pide un tipo de la interface que heredamos.

public void NombreMetodo(INombreInterface inter);

Podemos hacerle esto:

var obj  = new NewClass();

NombreMetodo(obj);

Podemos hacer esto siempre  y cuando NewClass herede y por tanto implemente los metodos que estan en INombreInterface.

Asi que tambien aprovechamos polimorfismo con las interfaces.

Para que no te confundas:

* En el caso de la herencia de clases, C# esta seguro de que todos cuentan con los metodos sea porque utilizan el override para redefinirlos, o porque aplican el virtual por defecto.

* En el caso de la herencia de interfaces, C# esta seguro de que todos cuentan con los metodos porque el contrato asi lo estipula, osea, me heredas me aplicas, asi de simple.

# Objeto Object y objeto is
1. Object => puede definirse como el padre de todo, ose:

true es un Object, string es un Object, int es un Object, de manera que si definimos un Object podemos asignarle el valor de tipo que seaa, (pero al hacer esto perdemos el acceso a las propiedades especificas de cada tipo), por lo que si defines una cadena de tipo Object no tendras acceso a la propiedad Lenght por ejemplo.

Se escribe asi:

Object nombreVariable = "Hola soy una cadena";
nombreVariable = true;
nombreVariable = 45.678890;

En fin le puedes asignar lo que se te de la gana.

2. is => es un "operador" para identificar el tipo. Se usa por lo general es condicionales, ejemplo:

if(nombre_variable is string)
{
    .. codigo en caso de que sea string
}
if(nombre_variable is int)
{
    ... codigo en caso de que sea int
}

Y asi por el estilo con (is bool, is double, is DateTime, etc...).

# Pragmatismo
Es una actitud que valora la utilidad y el valor practico de las cosas. De manera que cada vez que hagas algo en el desarrollo debes hacerlo porque aporta valor al software no porque sencillamente te dijeron que lo hagas.

Ejemplo:

Un patron de diseno (que no es mas que una solucion reutilizable para un problema recurrente en un contexto determinado) no siempre aporta algo a tu software asi que ten cuidado. Incluso a veces tendras que ir en contra de los mismisimos principios de la creacion de software, ya que no son leyes constante como las de la fisica (gravedad, velocidad de ela luz, etc...).

Asi que a la hora de desarrollar debes dar tres pasos:

1. Analizar y pensar cual es tu problema.
2. Ver las opciones que tienes para resolverlo.
3. Escojer la solucion que mas te convenga segun tu caso.

Con esto no digo que no aprendas patrones de diseno, para nada, pues estos te dan una perspectiva de como ver las cosas. Pero no son la solucion a todo, tenlo pendiente. Te preguntaras porque te digo esto y... 

Es que hay desarrolladores que lo unico que tienen en su caja de herramientas es un destornillador, de manera que creen que todo problema en la vida es un tornillo, y no es asi.

EN RESUMEN:

HAS LAS COSAS QUE TE APORTEN, NO HAGAS LAS COSAS PORQUE SI, PIENSA, ANALIZA, RESULEVE Y ESCOGE SEGUN TU PROBLEMA (SI ES POSIBLE INFORMATE SOBRE CASOS PARECIDOS AL TUYO Y ASI TIENES UNA VISION GENERAL DE LAS COSAS).

# Inyeccion de dependencias
Es un patrón de diseño orientado a objetos, en el que se suministran objetos a una clase en lugar de ser la propia clase la que cree dichos objetos. Esos objetos cumplen contratos que necesitan nuestras clases para poder funcionar (de ahí el concepto de dependencia). Nuestras clases no crean los objetos que necesitan,sino que se los suministra otra clase 'contenedora' que inyectará la implementación deseada a nuestro contrato.

En si es pasar una insancia de una interface como parametro, de manera que podemos enviar cualquier clase que herede y por tanto aplique los metodos de la interface en ella. .Librandonos de la tediosa tarea de definir un metodo en caso de una clase especifica, ya que solo pedimos interface, C# verifica si ese metodo la aplica y ya.

De manera que si tenemos el siguiente metodo:

void NombreMetodo(INombreInterface inter);

Podemos pasarle como parametro cualquier clase que implemente esa interface, ya que por el contrato, la clase se ve obligada a definir cada metodo que posee dicha interface, de esta manera al acceder por ejemplo, al metodo GetAll de la interface, C# sabe que la clase que se envio posee ese metodo.

# Factoria de clases
En si la usamos para crear instancias de clases sin que el cliente lo sepa, osea, por lo general instanciamos asi:

var obj = new NombreClase();

En este caso, el nombre de la clase es explicito, es visible, pero queremos hacerlo mas  privado, entonces, creamos una factoria, por lo general se crea una clase aparte definimos un metodo que toma como parametro un string o un entero, dependdiendo de como quieras crear las clases (si es con un enum mucho mejor), y en base al valor del parametro, este por medio de condicionales o switch() te retornara una instancia de la clase especificada para dicho parametro.

Obviamente el metodo que usaremos como factoria, retorna un tipo INombreInterfaz pero ojo, todas las instancia que seran creadas deben implementar esa interfaz. Pues de otra manera te dara error.

Ejemplo:

public INombreInterface ClassFactory(string cmd)
{
    if(cmd.Equals("enviar_mensaje"))
    {
        return new EnviarMensaje();
    }
    if(cmd.Equals("enviar_correo"))
    {
        return new EnviarCorreo();
    }
}

Y es mas que obvio que el main method llamara la clase que tiene este metodo, no las clases que se instancian.

# Tipos anonimos y dynamic
Los tipos "anonimos" son aquellos tipos que no estan definidos por c#,osea, los creamos nosotros, por lo general su sintaxis es esta:

var anonimo = { nombre_propiedad = valor_propiedad ... };

Parecido a un JSON solo que en ves de usar comillas y : se usa un nombre en si, ejemplo:

var anonimos = new {
    nombre = "Fulano",
    apellido = "De tal",
    edad = 56,
    tamano = 1.80
};

Como puedes ver, los tipos anonimos se paracen a las listas, de manera que con un foreach podemos iterarlos, solo que, la lista tendra como tipo generico un <dynamyc>.

Seria algo como esto:

List<dynamic> anonimosList = new List<dynamic>();
anonimosList.Add(anonimos);// en este caso anonimos es el que                                     definimos arriba con nombre, apellido,                              edad, etc...
foreach(dynamic anon in anonimosList)
{
    Console.WriteLine(anon);
}

OJO: LOS TIPOS ANONIMOS REQUIREN DE DINAMICOS PARA SER ITERADOS, PERO, LOS TIPOS DINAMICOS FORMAN CUELLOS DE BOTELLAS EN TU APP, DE MANERA QUE EVITALOS A TODA COSTA.

# Clases abstracta
Muchas veces las clases padres solo las necesitamos para compartir codigo con las clases hijos, pero no es necesario instanciarla ya que no accederemos a ningun dato relevante, como hacemos eso? Pues con clases abstractas.

En si, la unica diferencia que tiene con las clases comunes es que no permite la instancia de ella, por tanto no tenemos acceso a sus propiedades ni metodos. 

Para definirla basta con escribir:

public abstract class NombreClase
{
    // y podemos definir aqui cualquier campo, propiedad y metodo
}

# Metodos genericos
A veces tenemos que hacer la misma accion solo que con Tipos distintos (cuando me refiero a tipos me refiero a int, string, clase, etc...), y tendemos a hacer un metodo para cada tipo. Con los genericos nos ahorramos esto. Basicamente un generico nos permite pasar como parametro cualquier tipo. Ejemplo:

public tipo_de_retorno NombreMetodo<T>(T valor)
{
    ... codigo
    ... codigo
}

Si te fijas, agregamos algo al nombre del metodo, a esto llamamos generico, y puedes poner cualquier letra realmente, pero es un estandar usar la "T". de manera que a la hora de invocar este metodo seria asi:

Si es para pasar la clase Persona pues:
NombreMetodo<Persona>(T valor);

Si es para la clase Correo pues:
NombreMetodo<Correo>(T valor);

Y asi sucesivamente.

# Readonly vs Const
Ambas tienen algo en comun, no pueden cambiar su valor, const por su parte una ve definido no se le puede asignar otro valor y readonly por su parte, debe inicializarse con un valor o asignarsele en el constructor.

* const => debes asignarle el valor en el instante en que la declaras, y no puedes pasarselo como referencia, osea, no puedes decir que es igual a el valor de una propiedad de una clase instanciada.

* readonly => le puedes asignar el valor como referencia, explicito, desde el constructor, como quieras, solo que solo es de lectura como su nombre lo dice (readonly = solo lectura).

readonly es superior a const porque al igual que ella no es modificable pero al momento de asignarle valor acepta cualquier forma sea explicita, implicita o por referencia.

Es mas que obvio el hecho de que los tipos que se le pueden asignar son todos (clases, httpcontex, loggers, etc...)

# Ref vs Out
Un tipo de refencia es cuando le indicamos a una variable que su valor dependera de una variable a la cual apunta la referencia.
Los tipos int, double, string y demas no son de referencia, ya que son guardados directamente en la memoria.

Que tal si queremos que se comporten como si fueran referencias?

Usamos "ref" => para hacer que un tipo de variable se comporte como si fuera de referencia, esto nos permite cambiar el valor de una variable aun despues de haberle asignado uno.

Usamos "out" => hace lo mismo que ref, solo que no require que la variable que se va a pasar se inicialice. Pero a la hora de asignarle un valor en el metodo que se invoca debes asignarle un valor obligatoriamente, ya que al no venir inicializada debes de inicializarla en el metodo.

En resumen, out te obliga a asignarle un valor, pero ref no. Y ya.

# Introduccion a los genericos
Los genéricos introducen en .NET el concepto de parámetros de tipo,lo que le permite diseñar clases y métodos que aplazan la especificación de uno o varios tipos hasta que el código de cliente declare y cree una instancia de la clase o el método. Por ejemplo, al usar un parámetro de tipo genérico T puede escribir una clase única que otro código de cliente puede usar sin incurrir en el costo o riesgo de conversiones en tiempo de ejecución u operaciones de conversión boxing.

En pocas palabras puedes hacer metodos clases que tomen como parametro cualquier tipo.

Este tema es algo extenso si quieres mas ejemplos entra en este link:

https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/generics/

# Clases selladas
Son clases que no pueden ser heredadas. Asi de simple, asi de sencillo.

Te preguntaras, para que quiero una clase que no puede ser heredada?

Pues imagina que creas la clase Animal,luego Perro hereda de ella y luego Doberman hereda de perro, despues de doberman no hay mas nada, de manera que doberman puede ser sellada.

# Ejemplo de clases genericas
Puedes declarar una clase generica de esta manera no estas atado a solo pasar "x" tipo como parametro a ella.

Te sirve de mucho para ahorrar codigo.

No solo puedes determinar un solo tipo de generico osea

class NombreClase<T>
{
    ... codigo
}

Al instanciar esta clase debo pasarle algun tipo para que ocupe el generico T:

var genIns = new NombreClass<int>(); => en este caso el generico seria un tipo int.

Sino que tambien puedes definir mas de un generico:

class NombreClass<T, I>
{
    ... codigo
}

Al instanciar esta clase debo pasarle algun tipo para que ocupe el generico T y otro para generico I:

var genIns = new NombreClass<int, string>(); => en este caso el generico T seria un tipo int y el generico I seria string.

# Interfaces genericas
Nos permiten el uso de clases genericas pero con la ventaja del polimorfismos, osea pedimos un tipo de interface y si pasamos un clase que hereda de ella no pasara nada, ya que por contrato debe definir cada uno de los metodos que ella posee.

# Restricciones de los genericos
Hasta ahora hemos usado genericos a nivel basico, pues aceptabamos cualquier tipo. Pero podemos definir restricciones, este tema es algo delicado y complicado, pon atencion y no pases de el, hasta que no lo comprendas bien.

Podemos ordenarle a una clase, metodo (lo que sea que estemos hacinedo generico) que solo recibiremos un tipo especifico, para esto a la definicion que hasta ahora tenemos debemos agregarle algo mas, fijate:

public void GenericoStruct<T>(T valor)
{

}

Hasta ahora haciamos esto, lo que le agregamos es unas cuantas cositas detras.

public void GenericoStruct<T>(T valor) : where T : struct
{

}

ves ese ( : where T : struct ), con esto definimos que el metodo solo acepta genericos de tipo struct, es bien facil de recordar si te fijas, pues la sentencia solo dice, traducido al espanol (donde T : tipo_de_dato_aceptado).

Aqui tienes algunos ejemplos con otros datos:

int => : where T : int
double => : where T : double
float => : where T : float
class => : where T : class
IEnumerable => : where T : IEnumerable

Tambien puedes aplicar varias restricciones, ejemplo:

double => : where T : class, IEnumerable<T>

Esto lo colocas detras de cada metodo, clase, interface, detras de lo que sea que este haciendo generico y listo.

OJO: Uso T, pero si la representacion de tu generico es M, O, MiGenerico o como sea, debes usar esa misma representacion.

# Lista, colecciones y arreglos
Una lista nos permite guardar una coleccion de valores de un tipo en especifico. Su sintaxis  es esta:

List<tipoDeDato> nombre_identitficativo = new List<tipoDeDato>();

Si defines que le pasaras enteros, solo debes pasar enteros, no puedes hacer una mezcla.

Posee muchos metodos para agregar, insertar, remover, etc...

List<int> numeros = new List<int>();

1. Agregar => numeros.Add(4);// agrega un valor al final de lal lista
2. Insertar => numeros.Insert(2, 56);// esta inserta un valor en el indice indicado, osea, de los dos parametros, el primero es el indice, el segundo es el valor a insertar.
3. Remove => numeros.Remove(5); // obviamente el valor que quieres remover debe existir
4. RemoveAt => numeros.RemoveAt(4) // remueve el elemento que se encuentra en ese indice
5. Clear => numeros.Clear()// es mas que obvio que limpia la lista

Podemos mostrar todos los elementos de una lista por medio de un foreach:

foreact(var nums in numeros)
{
    Console.WriteLine(nums);
}

Pero tambien puedes acceder mediante un indexador que seria este:

var numeroI = numeros[3]// accede al valor almacenado en el index 3 y se lo asigna a la variable

# Diccionarios
Es un estructura que nos permite asociar llaver y valores.

Su sintaxis es:

Dictionary<tipo_llave, tipo_valor> instancia = new Dictionary<tipo_llave, tipo_valor>();

Ejemplo:

Dictionary<string, int> nombreEdad = new Dictionary<string, int>();

La llave seria strig, el valor seria un int.

Puntos importantes:

1. No se pueden repetir las llaves, osae, si definiste una llave de valor "victor" no puedes repetirla. En el caso de los valores si, las veces  que quieras.
2. No llames llaves que no existan, te daran error.
3. Si le indicas que pasaras valores de un tipo no le pases valores de tipo diferente, pues obviamente te dara error.

Algunos de sus metodos son:

1. Add => agregar llave y valor
2. Remove => remover un valor en base a su llave
3. Clear => limpiar
4. ContainsKey => retorna un boleano en caso de que tenga esa llave, esto se usa para acceder a un llave que no estamos muy seguro de que exista.
5. ContainsValue => igual que el ContainsKey pero con valores.

Puedes iterar un diccionario por medio de un foreach agregando la propiedad Keys:

foreach(var content in dictionaryName.Keys)
{
    // asi mostrara las llaves
    Console.WriteLine(content);
    // asi mostrara el valor
    Console.WriteLine(dictionaryName[content]);
}

Son herramientas bastantes utiles a la hora de por ejemplo parcear a JSON y demas.

# FirstIn FirstOut con Queue
Queue es un getionador de colecciones  el cual utiliza el principio
first-in => first-out, osea, llegas de primero, te vas de  primero,llegas de ultimo, te vas de  ultimo.

Podria decirse que es como hacer una fila. Te toca el turno en el que llegaste.

Toma valores genericos, puedes pasar, int, double, string, etc...

Su sintanxis es simple:

Queue<tipo_dato> instancia = new Queue<tipo_dato>();

Algunos de sus metodos son:

1. Enqueue => agrega un elemento a la cola. Como ya te explique trabaja a modo de fila. 
2. Dequeue => saca un registro y te lo trae, de manera que puedes almacenarlo en una variable o simplemente eliminarlo.
3. Clear => limpia el Queue
4. ToArray => el nombre lo dice claro, puedes almacenar tu Queue en un arreglo, del mismo tipo de valor que almacenas en el obviamente. Y para mostarlo pues puedes usar el for de toda la vida, y pues como es array esta de mas decir que el index empieza en 0.
5. Contains => verificar si entre los valores existe el valor especificado.

Para iterarlo usas un foreach como para todo colection:

foreact(var item in queueName)
{
    Console.WriteLine(item);
}

Preguntaras para que quieres un Queue, pues para todo proceso que guarde o muestre datos por orden de llegada, por ejemplo:

Se tienen que imprimir en orden de llegada los archivos en una impresora, el Queue te garantizara que segun vallan llegando los archivo (en este caso el path de dicho archivo) en ese orden se iran imprimiendo.

# LastIn FirstOut con Stack
Al igual que Queue nos permite gestionar colecciones pero en ves de sacar el primero que se agrega, saca el ultimo (last in, first out).

La sintaxis es tecnicamente la misma:

Stack<tipo_dato> instancia = Stack<tipo_dato>();

Seria algo como esto:

Stack<int> instancia = Stack<int>();

Algunos de sus metodos son:

1. Push => agrega un elemento al stack
2. Pop => extrae un elemento del stack, y al igual que Queue, te lo trae de manera que lo puedes almacenar en una variable
3. Contains => verifica si existe el valor pasado como parametro en el stack.
4. ToArray => convierte el stack en arreglos, y por supuesto que el tipo de arreglo debe coincidir con el tipo del stack. 

Y algunos mas que no son muy usados pero que es bueno que pruebes.

Asi como Queue nos serviria para procesos que requieran orden de llegada, stack serviria de igual manera para mostrar el utlimo de primero.

# Conjuntos con HashSet
Un conjunto podemos definirlo como colecciones de objetos que no se repiten.

Nos beneficia ya que hay muchas operaciones en los conjuntos que nos permiten realizar grandes tareas sin ucho esfuerzo.

Para eso usamos HasSet que no es mas que una coleccion al cual le asignamos un generico:

HashSet<tipo> instancia = new HashSet<tipo>();

Ejemplo:

HashSet<int> instancia = new HashSet<int>();

Algunos de sus metodos son:

1. Add => agregar valor al conjunto
2. Clear => limpiar todo el conjunto
3. Contains => verificar si el conjunto contiene un valor

Pero hablamos de conjunto de manera que necesitaremos dos conjuntos y hacer operaciones de conjunto, que son (union, interseccion, diferencia, diferencia asimetrica, etc...)

1. Union => une todos los elementos de un conjunto sin repetir, y crea un conjunto nuevo con ellos
2. Interseccion => toma todos los elementos que se repiten, y crea un conjunto nuevo con ellos
3. Diferencia => toma los elementos del conjunto 1 que no se repiten en el conjunto 2
4. Diferencia asimetrica => toma los elementos de ambos conjunto que no se repiten en ninguno. 

A diferencia de lo que hemoms visto, si intentamos agregar un valor que ya existe no devuelve error, solo no lo agrega y ya.

De manera que los conjuntos pueden servinos para de cierta manera filtrar lo que tenemos en las listas.

# Introduccion a los arreglos
Son muy parecidos a las listas. En si son una secuencia de elementos. La diferencia en si es que las listas son mucho mas flexibles que los arreglos.

Un arreglo nos pipde que al momento de declararlo le indiquemos cuantos elementos puede tener. Su sintaxis es esta:

tipo[] nombre_arreglo = new tipo[cantidad_de_elemento_maxima];

Ejemplo:

Un arreglo de numeros que tenga como indice maximo 5:

int[] numeros = new int[5];

Para agregarle elementos debemos hacerlo mediante su indice, seria asi:

numeros[0] = 4;
numeros[1] = 45;

y asi por el estilo, pero por lo general se utiliza un ciclo for para llenarlos y vaciarlos dicho de manera simple:

for(int i = 0; i < numeros.Length; i++)
{
    numeros[i] = ... lo que queramos asignar
    // aqui vamos asignando elemento segun se vayan pasando los indices en base a i
}

Pero tambien puedes asignar valores inmediatamente, ejemplo:

string[] cadenas = new string[]{"Fulano", "Fulanito", "Perencejo", "Futanejo", "Maria", "Jose" };

En este caso C# inferira que el indice maximo sera el total de elemento guardados en esta inicializazcion. De manera que para C# sera esto:

string[] cadenas = new string[5];
Ya que 5 es el indice mas alto de los elementos que insertamos.

PARA REDIMENCICONAR UN ARREGLO SOLO USAMOS EL METODO RESIZE:

Por ejemplo si necesitas que el arreglo de string cadenas que definimos hace un momento tenga mas indices solo tienes que hace esto:

Array.Resize<string>(ref cadenas, 8);

El tipo debe ser el mismo, aunque si quieres modificarlo debes pasar parametros del nuevo tipo no del antiguo, luego pasamos la referncia del nombre que le pusimos al arreglos y por ultimo los indices que quieres que tenga.

Otro metodo muy usado en los arreglos es esperar las entradas, y deifnir el arreglo con un total de indices en base a las entradas o datos que llegan, pero si no puedes prehever cuantos son los datos, pues usa el Resize.

Ventajas:

Al ser un tipo primitivo, son mas sencillos, rapidos y tienen mejor performance que las colecciones.

Usa las colecciones cuando necesites flexibilidad, usa arreglos para cunado necesites velocidad y simplicidad.

# Arreglos bidimensionales


# Matrices


# Jagged Arrays o Arreglos de arreglos


# Delegados


# Delegados func y action