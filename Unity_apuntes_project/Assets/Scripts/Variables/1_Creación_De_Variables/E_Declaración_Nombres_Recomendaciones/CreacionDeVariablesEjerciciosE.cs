#pragma warning disable

using UnityEngine;

public class CreacionDeVariablesEjerciciosE : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre CREACIÓN DE VARIABLES (SECCIÓN E) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema


	void Ejercicio1()
	{
		// En orden de más a menos frecuente, indica qué caracteres deberíamos poner al principio del nombre de una variable (escribe tu respuesta abajo entre las comillas)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

		Debug.Log(respuesta);
	}

	void Ejercicio2()
	{
		// ¿Sabrías explicar qué vamos a hacer con la siguiente variable de tipo float? ¿Cómo podemos mejorar el nombre que le hemos dado? (Escribe tu respuesta abajo entre las comillas)

		float v;
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

		Debug.Log(respuesta);
	}

	void Ejercicio3()
	{
		// Identifica cuáles de las siguientes nombres de variables siguen todas las recomendaciones y cuáles se podrían mejorar
		// Al final de cada línea, escribe una letra C de 'Correcto' o una M de 'Mejorable'
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		float _Velocidad;			//
		char  _tecla;				//
		int Numerovidas;			//
		bool algo;					//
		float numeroPi;				//
		string _NombrePersonaje;	//
		bool esta_encendido;		//
		char letraJugador1;			//
		float NumeroReal;			//
		int cosa;					//
		string ID;					//
		bool esAlgo;				//
		int total_Intentos;			//
		float _contadorTiempo;		//
		string tituloJuego;			//

		// Las variables que tengan nombres mejorables decláralas de nuevo aquí abajo usando nombres que sí que sean del todo correctos (si en algún caso no sabes qué nombre poner, invéntate uno que pudiera tener sentido)

		// ...
	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}
}
