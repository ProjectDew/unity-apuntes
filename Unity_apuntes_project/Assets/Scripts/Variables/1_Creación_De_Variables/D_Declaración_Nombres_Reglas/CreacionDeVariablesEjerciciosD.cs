#pragma warning disable

using UnityEngine;

public class CreacionDeVariablesEjerciciosD : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre CREACIÓN DE VARIABLES (SECCIÓN D) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema


	void Ejercicio1()
	{
		// Imagina que tenemos las siguientes variables creadas tal cual se muestran aquí. ¿Qué problema crees que puede haber con ellas? (Escribe tu respuesta abajo entre las comillas)
		// int numero;
		// float numero;
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

		Debug.Log(respuesta);
	}

	void Ejercicio2()
	{
		// La frase que aparece aquí abajo no es del todo correcta. ¿Qué dos matices le añadirías para que lo sea? (Escribe tus respuestas abajo entre las comillas)

		// Un nombre de variable no debe repetirse ni tampoco contener espacios, caracteres especiales, números o ciertas palabras reservadas
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string matiz1 = "";
		string matiz2 = "";

		Debug.Log(matiz1);
		Debug.Log(matiz2);
	}

	void Ejercicio3()
	{
		// Todos los nombres de variables que aparecen entrecomillados aquí abajo provocarían errores si se usaran tal cual están ahí. Ajústalos para que sean correctos
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string nombre1 =  "numero entero";
		string nombre2 =  "Puede'volar";
		string nombre3 =  "esCorrecto?";
		string nombre4 =  "1Up";
		string nombre5 =  "numero-decimal";
		string nombre6 =  "bienHecho=)";
		string nombre7 =  "_totalPower-Ups";
		string nombre8 =  "un,Dos,Tres";
		string nombre9 =  "Nombre Jugador";
		string nombre10 = "enemigo#1";
		string nombre11 = "2letras";
		string nombre12 = "_esta-saltando";
		string nombre13 = "jugador 2";
		string nombre14 = "pulsarTecla/Boton";
		string nombre15 = "¡hasGanado!";

		Debug.Log(nombre1);
		Debug.Log(nombre2);
		Debug.Log(nombre3);
		Debug.Log(nombre4);
		Debug.Log(nombre5);
		Debug.Log(nombre6);
		Debug.Log(nombre7);
		Debug.Log(nombre8);
		Debug.Log(nombre9);
		Debug.Log(nombre10);
		Debug.Log(nombre11);
		Debug.Log(nombre12);
		Debug.Log(nombre13);
		Debug.Log(nombre14);
		Debug.Log(nombre15);
	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}
}
