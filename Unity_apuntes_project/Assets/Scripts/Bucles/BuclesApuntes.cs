using UnityEngine;

public class BuclesApuntes : MonoBehaviour
{
	private void Awake()
	{
		Debug.Log("Bucle while:");
		BucleWhile();

		Debug.Log("Bucle for:");
		BucleFor();

		Debug.Log("Bucle do-while:");
		BucleDoWhile();

		Debug.Log("Comparación while vs. do-while cuando la condición no se cumple:");
		ComparacionWhileDoWhile();
	}

	// Hay tres tipos principales de bucles: while, for y do-while (también está el foreach, pero ese va un poco aparte)
	// Los bucles while, for y do-while pueden tener hasta tres partes principales (no siempre tienen las tres, pero en general se puede decir que sí):
	//		- [Parte 1] Declaración e inicialización de una variable: creamos una variable (si no la tenemos ya creada de antes) y le damos un valor
	//		- [Parte 2] Comprobación de la variable usando un condicional: comprobamos si la variable que hemos creado cumple una determinada condición o no
	//		- [Parte 3] Actualización del valor de la variable: cambiamos el valor de la variable con el fin de que la condición anterior deje de cumplirse en algún momento

	private void BucleWhile()
	{
		int i = 0; // Declaración e inicialización de una variable (parte 1 del bucle)
		
		while (i < 3) // Comprobación de la variable usando un condicional (parte 2 del bucle)
		{
			Debug.Log(i);
			i++; // Actualización del valor de la variable (parte 3 del bucle)
		}
			
		// En un bucle while, primero se comprueba la condición (en este caso, que i sea menor que 3)
		// Mientras esa condición se siga cumpliendo, ocurrirá una y otra vez lo que hayamos puesto dentro del bucle
		// Una de las cosas que debería ocurrir dentro del bucle es que se cambie el valor de la variable que hemos creado al principio
		// Como esa variable la estamos usando en la condición del bucle, la idea es que al cambiar su valor la condición deje de cumplirse antes o después
		// Y, cuando eso ocurra, el bucle terminará y el programa seguirá avanzando y ejecutando el código que haya después del bucle (si hay alguno)
		// En caso de que la condición nunca deje de cumplirse, el bucle será infinito, por lo que el programa nunca saldrá de él y crasheará
	}

	// El bucle for es 100% equivalente al bucle while, los dos hacen exactamente lo mismo, así que se pueden usar de forma intercambiable
	// En la práctica, sin embargo, el bucle for se suele usar principalmente en dos situaciones:
	//		- Cuando recorremos arrays
	//		- Cuando sabemos de antemano en qué momento va a terminar el bucle (es decir, sabemos el valor que va a tener la variable al terminar el bucle)

	private void BucleFor()
	{
		// El bucle for de primeras puede parecer más complicado que el while, pero en realidad tiene exactamente las tres mismas partes:
		//		int i = 0;	// Declaración e inicialización de una variable (parte 1 del bucle)
		//		i < 3		// Comprobación de la variable usando un condicional (parte 2 del bucle)
		//		i++			// Actualización del valor de la variable (parte 3 del bucle)
		// La diferencia del bucle for con el while es que esas tres partes están comprimidas en una única línea, pero el funcionamiento es exactamente el mismo

		for (int i = 0; i < 3; i++) // Las tres partes del bucle están todas en la misma línea separadas por punto y coma
		{
			Debug.Log(i);
		}
	}

	// El bucle do-while es parecido al while, con la diferencia de que el do-while está invertido, es decir, la condición va al final en vez de al principio
	// Eso tiene un efecto, y es que en los bucles do-while la condición no se comprueba hasta que se ha ejecutado todo lo que hemos puesto dentro del bucle
	// Es decir, que primero ocurre todo y a continuación se comprueba la condición (primero disparamos y luego preguntamos, por así decirlo)
	// Entonces, si la condición se cumple, sigue ocurriendo una y otra vez lo que hay dentro del bucle (exactamente igual que en el while y el for)
	// Pero la diferencia es que, incluso cuando la condición no se cumple, con el do-while nos aseguramos de que todo lo que hemos puesto dentro va a ocurrir siempre al menos una vez
	// Quitando eso, el funcionamiento es exactamente el mismo

	private void BucleDoWhile()
	{
		int i = 0; // Declaración e inicialización de una variable (parte 1 del bucle)

		do
		{
			Debug.Log(i);
			i++; // Actualización del valor de la variable (parte 3 del bucle, que aquí es la segunda)
		} while (i < 3); // Comprobación de la variable usando una condición (parte 2 del bucle, que aquí es la tercera)
	}

	private void ComparacionWhileDoWhile()
	{
		int i;

		// WHILE
		
		i = 10; // Parte 1

		while (i < 3) // Parte 2
		{
			Debug.Log("[Bucle while] Este mensaje NO se va a mostrar, porque la condición del bucle no se cumple");
			i++; // Parte 3
		}

		// DO-WHILE
		
		i = 10; // Parte 1

		do
		{
			Debug.Log("[Bucle do-while] Este mensaje SÍ se va a mostrar, pero solo una vez, porque la condición del bucle no se cumple");
			i++; // Parte 3
		} while (i < 3); // Parte 2
	}
}
