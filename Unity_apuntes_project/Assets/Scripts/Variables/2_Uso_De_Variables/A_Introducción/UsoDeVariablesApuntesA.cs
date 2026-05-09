using UnityEngine;

public class UsoDeVariablesApuntesA : MonoBehaviour
{
	// -------------------------------------------------- A. INTRODUCCIÓN --------------------------------------------------

		
	// Para declarar una variable ponemos su tipo seguido de su nombre

	int numeroEntero = 1;
	float numeroReal = 3.14f;
	char caracter = 'a';
	string texto = "¡Hola, mundo!";
	bool booleano = true;
	
	// Cuando queremos usar una variable, sin embargo, tenemos que poner tan solo su nombre, en ningún caso su tipo

	// A modo de ejemplo, vamos a mostrar en la consola de Unity las variables que hemos creado arriba
	// Para eso tenemos que escribir Debug.Log() y poner entre los paréntesis el nombre de la variable que queremos mostrar (¡solo el nombre!)
	// Al hacer eso, estaríamos usando esa variable

	// Sin embargo, las variables no se pueden usar aquí directamente en la clase

	//Debug.Log(numero); // Esta línea de código es perfectamente correcta, no hay nada malo en ella, pero al escribirla directamente en la clase se nos marca como error

	// Por tanto, siempre que queramos usar una variable tendremos que hacerlo dentro de algún método (por ejemplo, los de Unity: Awake, Update...)

	void Awake() // Siempre que queramos usar una variable tendremos que hacerlo dentro de un método
	{
		// Además, cuando usamos una variable tenemos que tener en cuenta que lo que estamos usando en realidad es su valor, es decir, el dato que hemos guardado en ella
		// Por tanto, cada vez que escribimos el nombre de la variable en realidad es como si estuviéramos escribiendo el valor que tiene esa variable

		Debug.Log("Mostramos diversas variables en Unity (para ello escribimos su nombre, pero lo que se muestra no es el nombre, sino el valor)");
		Debug.Log(numeroEntero);	// 1
		Debug.Log(numeroReal);		// 3.14
		Debug.Log(caracter);		// a
		Debug.Log(texto);			// ¡Hola, mundo! =D
		Debug.Log(booleano);		// true
		
		Debug.Log("Mostramos los mismos valores que arriba sin usar variables (el resultado es el mismo)");
		Debug.Log(1);				// 1
		Debug.Log(3.14f);			// 3.14
		Debug.Log('a');				// a
		Debug.Log("¡Hola, mundo!");	// ¡Hola, mundo! =D
		Debug.Log(true);			// true


		// ----- Ahora puedes realizar los EJERCICIOS A de uso de variables -----
	}
}
