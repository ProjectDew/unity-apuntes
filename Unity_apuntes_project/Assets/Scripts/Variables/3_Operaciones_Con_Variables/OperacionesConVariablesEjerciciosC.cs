#pragma warning disable

using UnityEngine;

public class OperacionesConVariablesEjerciciosC : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre OPERACIONES CON VARIABLES (SECCIÓN C) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema


	void Ejercicio1()
	{
		// A continuación declaramos tres variables, dos de ellas inicializadas

		int numeroA = 3;
		int numeroB = 2;
		int resultado;

		//numeroA + numeroB = resultado;	// 3 + 2 = 5

		// Esta línea de aquí arriba es incorrecta, explica brevemente por qué (escribe tu respuesta en un string y muéstralo en Unity)
		// A continuación suma los números A y B, guardando el resultado en la variable sin inicializar (muéstralo en Unity)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio2()
	{
		// Aquí abajo hay una lista de variables

		int numeroA = 27;
		int numeroB = 6;

		int resultadoDivision;
		int resultadoModulo;
		int resultadoMultiplicacion;
		int resultadoSuma;

		// Realiza las siguientes operaciones con las variables anteriores
		//		- Divide A entre B (guarda el resultado en la variable que corresponda)
		//		- Calcula el módulo de A entre B (guarda el resultado en la variable que corresponda)
		//		- Multiplica el resultado de la división por el número B (guarda el resultado en la variable que corresponda)
		//		- Suma el resultado del módulo y el de la multiplicación (guarda el resultado en la variable que corresponda)
		// Por último, muestra en Unity el número A, el B y los resultados de todas las operaciones
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}

	void Ejercicio3()
	{
		// Si te fijas de nuevo en el ejercicio anterior, verás que el resultado de la última suma es igual al número A. Intenta pensar por qué (no es necesario que lo escribas)

		int numeroA = 27;
		int numeroB = 6;

		int resultadoDivision;
		int resultadoModulo;
		int resultadoMultiplicacion;
		int resultadoSuma;

		// Realiza a continuación las mismas operaciones que has hecho en el ejercicio anterior, pero esta vez intenta que el resultado de la última suma sea igual al número B en vez de al A
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}
}
