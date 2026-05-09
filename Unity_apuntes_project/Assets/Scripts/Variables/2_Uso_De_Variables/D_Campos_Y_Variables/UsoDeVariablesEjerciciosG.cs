#pragma warning disable

using UnityEngine;

public class UsoDeVariablesEjerciciosG : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre USO DE VARIABLES (SECCIÓN G) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema


	int ejercicioActual;
	bool ejerciciosTerminados;

	void Ejercicio1()
	{
		// Añade o cambia lo que sea necesario para que este código de aquí abajo funcione
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/* // ---------------------------------------- ELIMINA ESTA LÍNEA ANTES DE EMPEZAR EL EJERCICIO
		Debug.Log(int numeroPi = 3.14f);
		Debug.Log(string nombre.Length);
		*/ // ---------------------------------------- ELIMINA ESTA LÍNEA ANTES DE EMPEZAR EL EJERCICIO
	}

	void Ejercicio2()
	{
		// Explica brevemente por qué el código del ejercicio anterior daba error (escribe tu respuesta en un string y, cuando la tengas, muéstrala en Unity)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio3()
	{
		// Sin consultarlo en la consola de Unity, indica qué valor crees que tendrán las siguientes cuatro variables (escribe cada respuesta en un string diferente y, cuando las tengas todas, muéstralas en Unity)

		bool ejerciciosAcabados = ejerciciosTerminados;
		int unEjercicio = ejercicioActual;
		ejercicioActual = 3;
		int otroEjercicio = ejercicioActual;
		
		// Cuando ya tengas tus respuestas escritas (¡solo cuando ya las tengas!), muestra en Unity las cuatro variables anteriores para compararlas con tus respuestas (si te has equivocado, intenta pensar por qué)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio4()
	{
		// Aquí abajo usamos varias variables que se han declarado e inicializado antes en este documento, pero algunas dan error. ¿Por qué? (Escribe tu respuesta en un string y, cuando la tengas, muéstrala en Unity)
		
		ejercicioActual = 4;
		//ejerciciosAcabados = true;	// ¡Error!
		ejerciciosTerminados = true;

		//Debug.Log(unEjercicio);		// ¡Error!
		//Debug.Log(otroEjercicio);		// ¡Error!
		Debug.Log(ejercicioActual);
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
