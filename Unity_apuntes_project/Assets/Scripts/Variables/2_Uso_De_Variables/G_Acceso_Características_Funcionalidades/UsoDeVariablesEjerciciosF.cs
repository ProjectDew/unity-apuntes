#pragma warning disable

using UnityEngine;

public class UsoDeVariablesEjerciciosF : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre USO DE VARIABLES (SECCIÓN F) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema

	
	void Ejercicio1()
	{
		// El código de aquí abajo provoca un error al probarlo en Unity. Cambia o añade lo que sea necesario para que deje de dar error (sin eliminar ninguna línea del código)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string texto = null;

		Debug.Log(texto);
		Debug.Log(texto.Length);
	}

	void Ejercicio2()
	{
		// Explica brevemente por qué un Debug.Log del ejercicio anterior daba error y el otro no, si en los dos está la misma variable (escribe tu respuesta en un string y, cuando la tengas, muéstrala en Unity)
		// Una vez que hayas terminado, muestra en Unity también la cantidad de caracteres que tiene tu respuesta
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		
	}

	void Ejercicio3()
	{
		// Inventa una conversación de al menos 6 o 7 líneas entre dos personajes. Muestra en Unity cada línea de la conversación y, aparte, la cantidad de caracteres que tiene cada una
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}
}
