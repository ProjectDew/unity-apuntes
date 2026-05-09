#pragma warning disable

using UnityEngine;

public class UsoDeVariablesEjerciciosE : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre USO DE VARIABLES (SECCIÓN E) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema

	
	void Ejercicio1()
	{
		// A continuación se declaran e inicializan dos variables de tipo string

		string saludoA = "¡Hola!";
		string saludoB = "¡Buenas!";

		// Declara una tercera variable y úsala para intercambiar los dos saludos anteriores, de forma que el A sea "¡Buenas!" y el B sea "¡Hola!" (y después muestra los saludos ya intercambiados en la consola de Unity)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio2()
	{
		// Declaramos dos variables idénticas a las del ejercicio anterior

		string saludoA = "¡Hola!";
		string saludoB = "¡Buenas!";

		// Intenta intercambiar el valor de estas variables, pero sin declarar ninguna más. ¿Qué problema hay? (Escribe tu respuesta en una variable de tipo string y, cuando la tengas, muéstrala en Unity)
		// ¡Ojo! No vale hacer esto de aquí abajo (porque estamos suponiendo que no sabemos los datos de las variables)
		//		saludoA = "¡Buenas!";	// Esto no vale
		//		saludoB = "¡Hola!";		// Esto no vale
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio3()
	{
		// Échale un ojo a las siguientes líneas de código

		int numeroA = 1;
		int numeroB = 2;
		int numeroC = 3;

		int numeroD = numeroA;
		numeroA = numeroC;
		numeroC = numeroB;
		numeroB = numeroD;

		// Sin consultarlo en la consola de Unity, indica cuál es el valor de los números A, B y C (declara tres variables de tipo string, escribe en ellas tus respuestas y a continuación muéstralas en Unity)
		// Cuando ya tengas tus respuestas escritas (¡solo cuando ya las tengas!), muestra en la consola de Unity los números A, B y C para compararlos con tus respuestas (si te has equivocado, intenta pensar por qué)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		
	}

	void Ejercicio4()
	{
		// Vamos a hacer algo muy parecido a lo que hay en el ejercicio anterior, pero con una ligera diferencia

		int numeroA = 1;
		int numeroB = 2;
		int numeroC = 3;

		int numeroD = numeroA;
		numeroA = numeroC;
		numeroB = numeroD; // Esto en el ejercicio anterior ocurría después
		numeroC = numeroB;
		
		Debug.Log(numeroA);
		Debug.Log(numeroB);
		Debug.Log(numeroC);

		// Explica brevemente qué es lo que ha pasado para que el número 1 esté ahora repetido y el 2 haya desaparecido (escribe tu respuesta en una variable de tipo string y, cuando la tengas, muéstrala en Unity)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
		Ejercicio4();
	}
}
