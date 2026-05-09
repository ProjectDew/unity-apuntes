using UnityEngine;

public class UsoDeVariablesApuntesE : MonoBehaviour
{
	// -------------------------------------------------- E. COPIA DE DATOS --------------------------------------------------


	void Awake()
	{
		// Un uso habitual de las variables es el de copiar datos, es decir, guardar el dato de una variable en otra de modo que las dos acaben teniendo el mismo valor
		// Para hacer eso bastaría con usar el símbolo de igual, como cuando asignamos un valor

		int numeroA = 10;		// Declaramos la variable numeroA y la inicializamos dándole un valor de 10
		int numeroB = numeroA;	// Declaramos la variable numeroB y la inicializamos copiando el valor de la variable numeroA, es decir, 10
		
		// El resultado de lo que hemos hecho aquí arriba es que tanto el número A como el número B tienen un valor de 10
		
		Debug.Log("Mostramos dos variables (hemos copiado el valor de una en la otra, así que las dos valen lo mismo)");
		Debug.Log(numeroA); // Esto muestra el número 10
		Debug.Log(numeroB); // Esto también muestra el número 10

		// Aunque hayamos copiado una variable en la otra, las dos variables siguen siendo independientes
		// Por tanto, si ahora queremos guardar un dato distinto en cualquiera de las dos variables, podemos hacerlo sin que la otra se vea afectada

		numeroA = 20; // Cambiar el valor del número A no afecta para nada al número B
		
		Debug.Log("Mostramos las dos mismas variables de antes, pero en la primera hemos guardado un dato distinto (sin que eso afecte a la segunda)");
		Debug.Log(numeroA);	// Esto ahora muestra el número 20
		Debug.Log(numeroB);	// Esto sigue mostrando el número 10

		// Por lo general, esto que acabamos de hacer de copiar el dato de una variable en la otra solo es posible cuando las dos variables son del mismo tipo
		// Si intentamos, por ejemplo, copiar un dato de tipo int o float en una variable de tipo bool nos va a dar error, porque sus tipos son diferentes

		float numeroReal = 3.14f;

		//bool booleano = numeroReal;		// ¡Error! No podemos copiar el valor de una variable numérica en un bool, porque los tipos no coinciden
		float otroNumeroReal = numeroReal;	// Correcto, estamos copiando el dato de una variable de tipo float en otra variable que también es de tipo float
		
		Debug.Log("Mostramos dos variables de tipo float (hemos copiado el valor de una en la otra, así que las dos valen lo mismo)");
		Debug.Log(numeroReal);		// Esto muestra el número 3.14
		Debug.Log(otroNumeroReal);	// Esto también muestra el número 3.14


		// ----- Ahora puedes realizar los EJERCICIOS E de uso de variables -----
	}
}
