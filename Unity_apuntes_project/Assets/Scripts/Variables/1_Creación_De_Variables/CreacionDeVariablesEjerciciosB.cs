#pragma warning disable

using UnityEngine;

public class CreacionDeVariablesEjerciciosB : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------

	// Haz los ejercicios en orden
	// Intenta siempre hacer primero todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si te ves con la confianza suficiente, abre este documento en un bloc de notas e intenta hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si al acabar te ha quedado algún ejercicio por hacer o por completar, échale un ojo a los apuntes (aquí abajo se indica a qué apuntes y a qué sección corresponden estos ejercicios)
	// Si aun así sigues con alguna duda o tienes problemas con algún ejercicio concreto, recurre a las herramientas que necesites (o pregúntame), procurando siempre entenderlo todo bien


	// ----- Si tienes dudas, puedes consultar los apuntes sobre CREACIÓN DE VARIABLES (SECCIÓN B) -----


	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}

	void Ejercicio1()
	{
		// ¿Qué dos informaciones tenemos que poner siempre que creamos una variable y en qué orden tenemos que escribirlas? (Escribe tu respuesta entre las comillas)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

		Debug.Log(respuesta);
	}

	void Ejercicio2()
	{
		// A continuación se muestra una lista de tipos de variables. ¿Qué clase de datos podemos guardar en cada uno de ellos? (Escribe tus respuestas abajo entre las comillas)
		//		Tipo 1. string
		//		Tipo 2. float
		//		Tipo 3. bool
		//		Tipo 4. char
		//		Tipo 5. int
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuestaString = "";
		string respuestaFloat = "";
		string respuestaBool = "";
		string respuestaChar = "";
		string respuestaInt = "";

		Debug.Log(respuestaString);
		Debug.Log(respuestaFloat);
		Debug.Log(respuestaBool);
		Debug.Log(respuestaChar);
		Debug.Log(respuestaInt);
	}

	void Ejercicio3()
	{
		// Cambia el tipo de cada una de las siguientes variables por el que creas que mejor encaja con su nombre (si el tipo que mejor encaja es string, deja la variable como está)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string entero;
		string caracter;
		string decimales;
		string texto;
		string apagado;
		string velocidad;
		string simbolo;
		string edad;
		string correcto;
		string nombre;
	}
}
