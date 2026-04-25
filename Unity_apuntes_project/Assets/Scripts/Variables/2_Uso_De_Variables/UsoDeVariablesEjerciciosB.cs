#pragma warning disable

using UnityEngine;

public class UsoDeVariablesEjerciciosB : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre USO DE VARIABLES (SECCIÓN B) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema

	
	int numeroEnteroA;
	float numeroRealA;
	bool booleanoA;
	string textoA;

	void Ejercicio1()
	{
		// Arriba hemos declarado unas variables y aquí abajo otras. Las de arriba funcionan sin problema, pero las de aquí abajo dan error. Haz lo que sea necesario para que ninguna dé error
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		int numeroEnteroB;
		float numeroRealB;
		bool booleanoB;
		string textoB;

		Debug.Log(numeroEnteroA);
		Debug.Log(numeroRealA);
		Debug.Log(booleanoA);
		Debug.Log(textoA);
		
		/* // ---------------------------------------- ELIMINA ESTA LÍNEA ANTES DE EMPEZAR EL EJERCICIO
		Debug.Log(numeroEnteroB);
		Debug.Log(numeroRealB);
		Debug.Log(booleanoB);
		Debug.Log(textoB);
		*/ // ---------------------------------------- ELIMINA ESTA LÍNEA ANTES DE EMPEZAR EL EJERCICIO
	}

	void Ejercicio2()
	{
		// Explica brevemente por qué algunas de las variables que aparecen en el ejecicio anterior funcionan sin problema y otras daban error (escribe tu respuesta abajo entre las comillas)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

		Debug.Log(respuesta);
	}

	void Ejercicio3()
	{
		// Fíjate en los datos que hemos guardado en las siguientes variables
		int numeroEntero = 0;
		float numeroReal = 0.0f;
		bool booleano = false;
		string texto = null;
		// Si las mostrásemos en la consola de Unity, ¿habría alguna diferencia entre estas variables y las que están al principio, justo encima de los ejercicios? (Escribe tu respuesta abajo entre las comillas)
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
