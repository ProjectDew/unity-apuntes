#pragma warning disable

using UnityEngine;

public class OperacionesConVariablesEjerciciosG : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre OPERACIONES CON VARIABLES (SECCIÓN G) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema


	void Ejercicio1()
	{
		// ¿Qué es lo que hace el símbolo de menos (-) cuando lo colocamos delante de una variable de tipo int o float? (Escribe tu respuesta en un string y muéstrala en Unity)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio2()
	{
		// Si a la siguiente variable le ponemos el símbolo de menos delante, ¿el número será positivo o negativo? (Escribe tu respuesta en un string y muéstrala en Unity)

		int numero = -5;
		
		// Cuando ya tengas tu respuesta (¡solo cuando ya la tengas!), muestra en Unity el número con el signo de menos delante para comprobar si es positivo o negativo
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio3()
	{
		// Muestra en la consola de Unity las siguientes variables, pero con sus signos invertidos

		float numeroA = -2.4f;
		int numeroB = 6;
		float numeroC = 3.9f;
		int numeroD = -8;
		float numeroE = -5.17f;

		// A continuación, indica si el cambio de signo que has realizado en las variables anteriores es permanente o no. Para ello, dale al booleano de aquí abajo un valor de true o false (y después muéstralo en Unity)

		bool elCambioEsPermanente;

		// Cuando ya tengas tu respuesta (¡solo cuando ya la tengas!), muestra en la consola de Unity los números de arriba (sin invertir sus signos esta vez) para comprobar si has respondido de forma correcta
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}
}
