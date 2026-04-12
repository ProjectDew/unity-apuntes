using UnityEngine;

public class ArraysApuntes : MonoBehaviour
{
	// -------------------------------------------------- ENTENDER LOS ARRAYS --------------------------------------------------


	// Para entender los arrays, podemos imaginar que son como un hotel en el que solo pueden alojarse huéspedes de un determinado tipo (int, char, float, etc.)
	// En ese hotel hay un pasillo que tiene cierta cantidad de habitaciones numeradas (empezando desde 0 y aumentando en uno cada vez) y en cada una de esas habitaciones se aloja un huésped

	// HOTEL DE CARACTERES

	// [0] [1] [2] [3] [4]    	<- habitaciones del hotel y número de cada una
	// 'H' 'o' 't' 'e' 'l'		<- huésped que se aloja en cada habitación


	// -------------------------------------------------- DECLARAR UN ARRAY --------------------------------------------------


	// Los arrays se declaran (o crean) de forma muy parecida a como haríamos con una variable normal, con la única diferencia de que un array lleva corchetes detrás de su tipo

	private char caracter;		// No array
	private char[] caracteres;	// Array (la única diferencia entre declarar un array y declarar una variable normal es que al array se le ponen corchetes detrás del tipo)

	private void Awake()
	{
		// -------------------------------------------------- INICIALIZAR UN ARRAY --------------------------------------------------


		// Al inicializar un array (es decir, al darle un valor por primera vez), lo podemos hacer de una forma u otra según la información que tengamos sobre el array
		// Hay varias posibilidades, pero las principales son dos:
		//		- [Posibilidad 1] Sabemos exactamente qué elementos concretos va a contener el array
		//		- [Posibilidad 2] No sabemos exactamente qué valores va a contener el array, pero sí cuántos va a tener (o cuál es el máximo)

		// [Inicializar array - Posibilidad 1] Sabemos exactamente qué elementos concretos va a contener el array

		// En ese caso, para darle un valor al array se pone la palabra "new" seguida del tipo de array con los corchetes detrás y, a continuación (entre llaves), todos los elementos que va a contener el array separados por coma
		// Lo podemos hacer en una sola línea...

		caracteres = new char[] { 'H', 'o', 't', 'e', 'l' }; // Este array contiene cinco caracteres: 'H', 'o', 't', 'e', 'l', en ese orden

		// ...o lo podemos hacer en varias líneas si lo preferimos

		caracteres = new char[]
		{
			'H',
			'o',
			't',
			'e',
			'l'
		};

		MostrarValoresDelArray();

		// [Inicializar array - Posibilidad 2] No sabemos exactamente qué valores va a contener el array, pero sí cuántos va a tener (o cuál es el máximo)

		// En ese caso, se pone también la palabra "new" seguida del tipo de array con los corchetes detrás, pero esta vez, dentro de los corchetes, indicamos la cantidad de elementos que va a contener el array (y nada más)

		caracteres = new char[5]; // Este array contiene cinco elementos de tipo char (es decir, 5 caracteres), pero todavía no sabemos qué valor van a tener esos caracteres

		// Como no le hemos asignado un valor a ninguno de los elementos que contiene el array, si los mostramos en consola saldrá su valor por defecto, que en el caso de los caracteres es un valor vacío

		MostrarValoresDelArray(); // Esto mostrará cinco mensajes vacíos en consola
		

		// -------------------------------------------------- ACCEDER A LOS ELEMENTOS DE UN ARRAY --------------------------------------------------


		// Al declarar un array de esta manera (poniendo el total de elementos en vez de sus valores), en algún momento vamos a tener que asignarles un valor a sus elementos
		// Para poder asignarle un valor a un elemento de un array, tenemos que acceder a ese elemento
		// Si volvemos de nuevo al ejemplo del hotel, para acceder a un elemento del array lo que tenemos que hacer es ir a la habitación en la que se hospeda
		// Y para poder ir a su habitación tenemos que saber el número de habitación
		// Por tanto, para acceder al elemento de un array tenemos que poner el nombre del array (hotel) seguido de los corchetes (habitación) y dentro de los corchetes el índice al que queremos acceder (número de habitación)

		caracteres[0] = 'H'; // Le asignamos un valor al elemento del array que se encuentra en el índice 0 (alojamos un nuevo huésped en la habitación 0 del array de caracteres)
		caracteres[1] = 'o'; // Le asignamos un valor al elemento del array que se encuentra en el índice 1 (alojamos un nuevo huésped en la habitación 1 del array de caracteres)
		caracteres[2] = 't'; // Le asignamos un valor al elemento del array que se encuentra en el índice 2 (alojamos un nuevo huésped en la habitación 2 del array de caracteres)
		caracteres[3] = 'e'; // Le asignamos un valor al elemento del array que se encuentra en el índice 3 (alojamos un nuevo huésped en la habitación 3 del array de caracteres)
		caracteres[4] = 'l'; // Le asignamos un valor al elemento del array que se encuentra en el índice 4 (alojamos un nuevo huésped en la habitación 4 del array de caracteres)

		MostrarValoresDelArray();

		// Cuando accedemos a un elemento de un array usando un índice, tenemos que estar seguros de que el índice que hemos puesto existe realmente
		// Para ello debemos tener en cuenta dos reglas sencillas:
		//		- El índice nunca va a ser negativo
		//		- El índice siempre va a ser menor que el total de elementos del array

		// Por tanto, si un array contiene 5 elementos, el primero siempre va a estar en el índice 0 (ya que no hay índices negativos)
		// Y, puesto que el primer índice siempre va a ser 0 (y, por tanto, empezamos a contar desde 0), el último va a ser siempre el total de elementos menos uno (en este caso, 5 - 1 = 4)
		// Es decir, que en un array que contenga 5 elementos vamos a poder usar los siguientes índices: 0, 1, 2, 3 y 4

		//caracteres[-1] = 0;	// ¡Error! Un array nunca va a tener índices negativos
		//caracteres[5] = 6;	// ¡Error! El array de caracteres solo tiene 5 elementos y, por tanto, no existe el índice número 5 (ya que, al empezar a contar desde 0, el mayor índice posible en este caso es 4)
		

		// -------------------------------------------------- RECORRER UN ARRAY --------------------------------------------------


		// Una de las principales ventajas de los arrays respecto a otras variables, sin embargo, es que los arrays nos permiten aplicar una misma operación a todos sus elementos sin tener que ir uno por uno de forma individual
		// Por tanto, cuando estamos trabajando con arrays lo habitual no es acceder a cada uno de sus elementos por separado, sino recorrer todo el array usando un bucle y poner dentro del bucle lo que queremos que ocurra
		// Los bucles más utilizados para esto son el for y el foreach (si quisiéramos podríamos utilizar también el while e incluso el do-while, pero no es lo normal)

		RecorrerArrayConBucleFor();

		RecorrerArrayConBucleForeach();
	}

	private void RecorrerArrayConBucleFor()
	{
		// -------------------------------------------------- BUCLE FOR --------------------------------------------------


		// Los bucles for tienen tres partes principales: crear una variable, comprobar esa misma variable usando una condición y actualizar el valor de la variable
		// Al usar un bucle for para recorrer un array, la variable que creamos va a ser el índice (el número de habitación)
		// Por tanto, esa variable va a ser siempre de tipo int
		// Y, si queremos recorrer el array empezando desde el primer elemento (que suele ser lo habitual), el valor que le vamos a dar de primeras será 0

		// int i = 0;

		// A partir de ahí, si lo que queremos es recorrer el array hasta el final (que es lo más común), tendremos que asegurarnos de que el valor de esa variable sea siempre menor que el total de elementos
		// Por tanto, esa será la condición que pongamos en el bucle
		
		// i < 5;	// Suponiendo que el total de elementos es 5

		// Además, como queremos ir uno a uno pasando por todos los elementos del array, por cada vuelta del bucle tendremos que sumar +1 a la variable que hemos creado
		// De esta forma, la variable empezará siendo 0, luego 1, luego 2... y así hasta llegar al último índice del array
		// La forma más resumida de sumar +1 a una variable es la siguiente:

		// i++;

		// Y aquí está el ejemplo completo:

		for (int i = 0; i < 5; i++)
		{
			// Dado que i empieza valiendo 0 y le vamos sumando 1 cada vez (y el bucle no se detiene hasta que llega a 5), esta línea de código va a pasar por todos los índices del array, mostrándonos el valor de cada elemento
			Debug.Log(caracteres[i]);
		}

		// Lo que acabamos de hacer está bien, pero lo podemos mejorar con un ligero cambio
		// Al trabajar con arrays, lo normal no es poner tal cual el total de elementos que hay dentro del array
		// En lugar de eso, lo que suele hacerse es utilizar una propiedad que tienen todos los arrays y que nos proporciona justo esa información
		// Esta propiedad se llama Length y al usarla nos evitamos tener que preocuparnos de recordar o calcular la cantidad de elementos que contiene el array
		// Además, si en el futuro cambiamos el código y hacemos que el array contenga 10 caracteres en vez de 5, con la propiedad Length ese cambio se verá reflejado de forma automática

		for (int i = 0; i < caracteres.Length; i++) // caracteres.Length nos dice la cantidad de elementos que contiene el array de caracteres, que en este caso es 5
		{
			Debug.Log(caracteres[i]);
		}
	}

	private void RecorrerArrayConBucleForeach()
	{
		// -------------------------------------------------- BUCLE FOREACH --------------------------------------------------


		// Los bucles foreach son diferentes del resto de bucles, ya que únicamente se pueden usar para recorrer arrays (y otros tipos de colecciones similares a los arrays)
		// La principal diferencia del bucle foreach respecto al for es que, mientras que con el for tenemos que acceder a cada elemento del array mediante su índice, con el foreach accedemos al elemento directamente
		
		foreach (char caracter in caracteres)	// Por cada carácter que haya en el array de caracteres...
		{
			Debug.Log(caracter);				// ...mostramos en consola ese carácter
		}

		// La estructura del foreach es siempre la misma
		// La única diferencia es que si tenemos un array de números enteros crearemos una variable de tipo int en vez de char, si es de números decimales usaremos float, etc.

		// Ejemplo de foreach con un array de números enteros:

		int[] numerosEnteros = new int[] { 1, 2, 3, 4, 5 };

		foreach (int numeroEntero in numerosEnteros) // La variable numeroEntero es de tipo int porque el array contiene elementos de tipo int
		{
			Debug.Log(numeroEntero);
		}

		// Ejemplo de foreach con un array de números decimales:

		float[] numerosDecimales = new float[] { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f };

		foreach (float numeroDecimal in numerosDecimales) // La variable numeroDecimal es de tipo float porque el array contiene elementos de tipo float
		{
			Debug.Log(numeroDecimal);
		}
	}

	private void MostrarValoresDelArray()
	{
		for (int i = 0; i < caracteres.Length; i++)
		{
			Debug.Log(caracteres[i]);
		}
	}
}
