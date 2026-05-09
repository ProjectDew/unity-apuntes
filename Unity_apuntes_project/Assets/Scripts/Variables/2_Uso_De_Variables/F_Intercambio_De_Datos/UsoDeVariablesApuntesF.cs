using UnityEngine;

public class UsoDeVariablesApuntesF : MonoBehaviour
{
	// -------------------------------------------------- F. INTERCAMBIO DE DATOS --------------------------------------------------


	void Awake()
	{
		int numeroA = 20;
		int numeroB = 10;

		// Si tenemos dos variables del mismo tipo, como aquí arriba, algo que podemos hacer con ellas es copiar el valor de una en la otra
		// Al hacer eso, las dos variables van a acabar teniendo el mismo valor, pero sin dejar de ser totalmente independientes entre sí
		// Otra cosa que también podemos hacer partiendo de lo anterior es intercambiar los datos de dos o más variables
		// Para ello, suponiendo que no sabemos qué valor tiene cada variable, debemos seguir tres pasos

		int numeroC = numeroA;	// [Paso 1] Declaramos una variable nueva (numeroC) y copiamos el número A en la nueva variable

		Debug.Log("Intercambio de datos entre variables, paso 1:");
		Debug.Log(numeroA);		// El número A vale 20
		Debug.Log(numeroB);		// El número B vale 10
		Debug.Log(numeroC);		// El número C vale 20

		numeroA = numeroB;		// [Paso 2] Copiamos el número B en la variable numeroA

		Debug.Log("Intercambio de datos entre variables, paso 2:");
		Debug.Log(numeroA);		// El número A vale 10
		Debug.Log(numeroB);		// El número B vale 10
		Debug.Log(numeroC);		// El número C vale 20

		numeroB = numeroC;		// [Paso 3] Copiamos el número C en la variable numeroB

		Debug.Log("Intercambio de datos entre variables, paso 3:");
		Debug.Log(numeroA);		// El número A vale 10
		Debug.Log(numeroB);		// El número B vale 20
		Debug.Log(numeroC);		// El número C vale 20

		// Por tanto, al completar los tres pasos anteriores el resultado es que los valores de los números A y B se han intercambiado
		//		- Antes el número A era 20 y el B era 10
		//		- Ahora el número A es 10 y el B es 20
		
		Debug.Log("Mostramos solo las dos primeras variables con sus valores intercambiados");
		Debug.Log(numeroA);		// Esto muestra el número 10
		Debug.Log(numeroB);		// Esto muestra el número 20

		// A continuación, volvemos a repetir los mismos pasos para intercambiar de nuevo los datos de las variables y dejarlos como estaban al principio
		
		numeroC = numeroA;		// [Paso 1] Copiamos el número A en la variable numeroC (como la variable ya la teníamos declarada de antes no es necesario hacerlo de nuevo)
		numeroA = numeroB;		// [Paso 2] Copiamos el número B en la variable numeroA
		numeroB = numeroC;		// [Paso 3] Copiamos el número C en la variable numeroB
		
		Debug.Log("Mostramos las dos primeras variables con sus valores intercambiados por segunda vez");
		Debug.Log(numeroA);		// Esto muestra el número 20
		Debug.Log(numeroB);		// Esto muestra el número 10


		// ----- Ahora puedes realizar los EJERCICIOS F de uso de variables -----
	}
}
