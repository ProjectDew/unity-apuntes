#pragma warning disable

using UnityEngine;

public class UsoDeVariablesEjerciciosA : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre USO DE VARIABLES (SECCIÓN A) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema


	int numeroEntero;
	float numeroReal;
	bool booleano;
	string texto;

	void Ejercicio1()
	{
		// Las variables de aquí arriba están sin inicializar, pero en este caso reciben un valor por defecto. ¿Sabrías explicar brevemente por qué? (Escribe tu respuesta abajo entre las comillas)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

		Debug.Log(respuesta);
	}

	void Ejercicio2()
	{
		// ¿Cuál es el valor por defecto de un int, un float y un bool? (Escribe tus respuestas abajo, detrás de los signos de igual)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/* // ---------------------------------------- ELIMINA ESTA LÍNEA ANTES DE EMPEZAR EL EJERCICIO
		int valorPorDefectoInt = ;
		float valorPorDefectoFloat = ;
		bool valorPorDefectoBool = ;
		
		Debug.Log(valorPorDefectoInt);
		Debug.Log(valorPorDefectoFloat);
		Debug.Log(valorPorDefectoBool);
		*/ // ---------------------------------------- ELIMINA ESTA LÍNEA ANTES DE EMPEZAR EL EJERCICIO
	}

	void Ejercicio3()
	{
		// El valor por defecto de una variable de tipo string no funciona igual que el de un int, un float o un bool. ¿Qué es lo que lo hace especial o distinto? (Escribe tu respuesta abajo entre las comillas)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

		Debug.Log(respuesta);
	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}
}
