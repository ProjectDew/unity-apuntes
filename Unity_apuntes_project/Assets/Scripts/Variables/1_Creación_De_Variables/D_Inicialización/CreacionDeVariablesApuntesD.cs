using UnityEngine;

public class CreacionDeVariablesApuntesD : MonoBehaviour
{
	// -------------------------------------------------- D. INICIALIZACIÓN DE VARIABLES --------------------------------------------------

	
	// Esto que hemos hecho arriba se llama declarar (crear) variables, pero sin inicializarlas (es decir, sin guardar ningún dato en ellas)
	// Aunque declarar una variable sin inicializarla puede ser correcto y a veces nos interesará hacerlo así, en otras ocasiones nos va a venir mejor declararlas e inicializarlas a la vez
	// Para inicializar una variable (guardar un dato en ella) tendremos que utilizar el símbolo de igual (=) seguido del dato que queramos guardar en la variable

	// Según el tipo que tenga la variable, podremos asignarle unos datos u otros
	// Y a esos datos a veces es necesario añadirles ciertas "marcas" para distinguirlos
	//		- Los datos de tipo float llevan detrás una letra 'f' (o 'F') y, en caso de tener decimales, se separan con un punto (no una coma)
	//		- Los datos de tipo char se escriben entre comillas simples
	//		- Los datos de tipo string se escriben entre comillas dobles
	//		- Los booleanos no llevan ningún tipo de marca especial, pero su valor solo puede ser true o false

	// Ejemplos:

	int entero = 1;						// Los números int no llevan nada especial
	float real = 3.14f;					// Los números float llevan detrás una letra 'f' (o 'F') y, en caso de tener decimales, se separan con un punto (no una coma)
	char caracter = 'a';				// Los caracteres se escriben siempre entre comillas simples
	string texto = "¡Hola, mundo! =D";	// Los textos se escriben siempre entre comillas dobles
	bool booleano = true;				// En los booleanos se pone simplemente true o false sin ningún tipo de marca adicional

	// Las cinco variables anteriores están declaradas e inicializadas (es decir, están creadas y además se ha guardado algún dato en ellas)
	// Aparte, hemos tenido cuidado de darle a cada variable un nombre único: ninguna de las variables se llama igual que las demás, todos los nombres son diferentes entre sí

	//int entero; // ¡Error! Esto no se puede hacer porque arriba ya existe una variable con este mismo nombre

	// Como nota final, siempre que se declare o se inicialice una variable, al final de la línea tendremos que poner sí o sí un punto y coma

	void Awake()
	{
		Debug.Log(entero);
		Debug.Log(real);
		Debug.Log(caracter);
		Debug.Log(texto);
		Debug.Log(booleano);
	}


	// ----- Ahora puedes realizar los EJERCICIOS D de creación de variables -----
}
