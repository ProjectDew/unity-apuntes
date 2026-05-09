using UnityEngine;

public class UsoDeVariablesApuntesB : MonoBehaviour
{
	// -------------------------------------------------- B. VALORES POR DEFECTO (en clases) --------------------------------------------------


	// Cuando declaramos una variable en una clase y no la inicializamos (no guardamos ningún dato en ella), esa variable recibe un valor por defecto
	//		- El valor por defecto de una variable numérica (como int o float) es 0
	//		- El valor por defecto de un booleano es false
	//		- El valor por defecto de un string es null

	int numeroA = 5;	// En esta variable hemos guardado un dato (el número 5)

	// En las siguientes variables no hemos guardado ningún dato

	int numeroB;		// Al ser de tipo int, su valor por defecto será 0
	float numeroReal;	// Al ser de tipo float, su valor por defecto será 0 (0.0f)
	bool booleano;		// Al ser de tipo bool, su valor por defecto será false
	string texto;		// Al ser de tipo string, su valor por defecto será null

	void Awake()
	{
		Debug.Log("Mostramos los valores de varias variables (la primera está inicializada y las demás no)");
		Debug.Log(numeroA);		// Se muestra el número 5 (que es el valor que le hemos asignado)
		Debug.Log(numeroB);		// Se muestra el número 0 (que es el valor por defecto de un int)
		Debug.Log(numeroReal);	// Se muestra el número 0 (que es el valor por defecto de un float)
		Debug.Log(booleano);	// Se muestra false (que es el valor por defecto de un bool)
		Debug.Log(texto);		// Se muestra la palabra "Null"

		// Al mostrar las variables anteriores en la consola de Unity, tanto los números como los booleanos dan el resultado esperable: en los números sale 0 y en el booleano sale la palabra false
		// En el caso de la variable de tipo string, sin embargo, se muestra la palabra "Null"
		// Eso se debe a que tanto el valor por defecto de un número (0) como el de un booleano (false) son datos perfectamente válidos, es decir, 0 es un número válido y false es un booleano válido
		// El valor por defecto de una variable de tipo string, sin embargo, es null
		// Y null no es un dato válido
		// De hecho, null es un valor especial que se usa precisamente para indicar que ciertos tipos de variables no contienen ningún dato válido
		// Y, como no es posible mostrar en consola algo que no es válido, que es nulo, Unity en su lugar nos muestra la palabra "Null" para indicarnos que la variable tiene valor nulo
		
		Debug.Log("Mostramos una variable de tipo string sin inicializar (su valor por defecto es null)");
		Debug.Log(texto);		// Se muestra la palabra "Null", informándonos de que la variable tiene valor nulo (es decir, no contiene ningún dato válido)

		// Hay que tener en cuenta, sin embargo, que esto ocurre única y exclusivamente cuando queremos mostrar una variable nula en la consola de Unity
		// En muchos otros casos, lo que va a ocurrir al intentar usar una variable nula es que se va a producir un error, ya que sería como pretender utilizar algo que en realidad no existe
		// Por tanto, para evitar esta clase de errores, debemos tener siempre mucho cuidado con las variables que puedan ser nulas y asegurarnos muy bien de que no nos hemos olvidado de darles un valor


		// ----- Ahora puedes realizar los EJERCICIOS B de uso de variables -----
	}
}
