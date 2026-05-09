using UnityEngine;

public class UsoDeVariablesApuntesD : MonoBehaviour
{
	// -------------------------------------------------- D. CAMPOS Y VARIABLES --------------------------------------------------

	
	// Las variables que se declaran directamente en una clase reciben el nombre de campos y se suelen declarar siempre al principio, antes de (casi) todo lo demás
	// Por tanto, cuando en una clase tenemos variables y métodos, lo normal es poner primero todas las variables (es decir, los campos) y después todos los métodos

	// Campos

	int numeroEntero = 5;
	float numeroReal = 2.718f;
	char caracter = '&';
	string texto = "¡Hola, mundo! =D";
	bool booleano = false;

	// Métodos

	void Awake() // Método Awake
	{
		Debug.Log("Mostramos los campos (variables declaradas directamente en la clase)");
		Debug.Log(numeroEntero);		// Correcto
		Debug.Log(numeroReal);			// Correcto
		Debug.Log(caracter);			// Correcto
		Debug.Log(booleano);			// Correcto
		Debug.Log(texto);				// Correcto

		// Al contrario de lo que ocurre con los campos, las variables declaradas dentro de métodos no reciben ningún nombre especial, son simplemente variables

		string variableMetodo = "Esta variable está declarada dentro de un método";

		Debug.Log("Mostramos la variable declarada dentro del método");
		Debug.Log(variableMetodo);		// Correcto
		
	}

	void Update() // Método Update
	{
		// La principal diferencia entre las variables declaradas en un método y los campos (aparte de que los campos reciben un valor por defecto y las variables declaradas en métodos no) es el sitio donde se pueden usar
		// Mientras que los campos se pueden usar en cualquier parte, las variables declaradas en un método solo se pueden usar en el método donde se han declarado

		//Debug.Log(variableMetodo);	// ¡Error! Esta variable solo existe en el método Awake, así que no la podemos utilizar en ningún otro método que no sea Awake

		Debug.Log(numeroEntero);		// Correcto, los campos los podemos usar donde queramos
		Debug.Log(numeroReal);			// Correcto, los campos los podemos usar donde queramos
		Debug.Log(caracter);			// Correcto, los campos los podemos usar donde queramos
		Debug.Log(booleano);			// Correcto, los campos los podemos usar donde queramos
		Debug.Log(texto);				// Correcto, los campos los podemos usar donde queramos


		// ----- Ahora puedes realizar los EJERCICIOS D de uso de variables -----
	}
}
