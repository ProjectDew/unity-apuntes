#pragma warning disable

using UnityEngine;

public class OperacionesConVariablesEjerciciosE : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre OPERACIONES CON VARIABLES (SECCIÓN E) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema


	void Ejercicio1()
	{
		// Aquí abajo aparecen varias operaciones matemáticas con los números A y B

		int numeroA = 5;
		int numeroB = 4;
		
		numeroA = numeroA + numeroB;
		numeroA = numeroA - numeroB;
		numeroA = numeroA * numeroB;
		numeroA = numeroA / numeroB;
		numeroA = numeroA % numeroB;

		// Realiza las mismas operaciones que arriba, pero de forma más resumida, sin que se repita el nombre de la variable (ve mostrando cada uno de los resultados en Unity)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio2()
	{
		// Explica brevemente por qué la operación de aquí abajo entre los números A y B da error (escribe tu respuesta en un string y muéstrala en Unity)

		int numeroA = 3;
		int numeroB = 2;

		//numeroA + = numeroB;
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio3()
	{
		// Abajo aparecen una variable principal y seis secundarias
		// Realiza seis operaciones matemáticas con el número principal, usando una de las variables secundarias en cada operación (en el orden que te parezca correcto, pero sin que se repita ninguna)
		// Además, debes seguir estas pautas:
		//		- Debes usar los siguientes operadores: +=, -=, *=, /= y %=
		//		- El número principal debe ser distinto después de cada operación (ve mostrando cada resultado en Unity)
		//		- El número principal debe ser 7 al final
		
		// Variable principal
		int numeroPrincipal = 5;

		// Variables secundarias
		int numeroA = 3;
		int numeroB = 6;
		int numeroC = 6;
		int numeroD = 2;
		int numeroE = 6;
		int numeroF = 1;
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}
}
