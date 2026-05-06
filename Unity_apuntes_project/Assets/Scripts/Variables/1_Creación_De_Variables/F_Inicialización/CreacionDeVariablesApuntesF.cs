using UnityEngine;

public class CreacionDeVariablesApuntesF : MonoBehaviour
{
	// -------------------------------------------------- F. INICIALIZACIÓN DE VARIABLES --------------------------------------------------

	
	// Cuando declaramos una variable, en muchas ocasiones vamos a tener que guardar un dato en ella (darle un valor) antes de poder utilizarla
	// Al guardar un dato en una variable por primera vez decimos que la estamos inicializando (inicializar una variable = darle un valor por primera vez o guardar un dato por primera vez)
	// Para inicializar una variable (guardar un dato en ella) tenemos que utilizar el símbolo de igual (=) seguido del dato que vamoa a guardar en la variable

	// Según el tipo que tenga la variable, podremos asignarle unos datos u otros
	// Y a esos datos a veces es necesario añadirles ciertas "marcas" para distinguirlos
	//		- Los datos de tipo float llevan detrás una letra 'f' (o 'F') y, en caso de tener decimales, se separan con un punto (¡ojo!, no sirve una coma, solo punto)
	//		- Los datos de tipo char se escriben entre comillas simples
	//		- Los datos de tipo string se escriben entre comillas dobles
	//		- Los booleanos (bool) no llevan ningún tipo de marca especial, pero su valor solo puede ser true o false

	// Ejemplos:

	int entero = 1;						// Los números int no llevan nada especial
	float real = 3.14f;					// Los números float llevan detrás una letra 'f' (o 'F') y, en caso de tener decimales, se separan con un punto (no una coma)
	char caracter = 'a';				// Los caracteres se escriben siempre entre comillas simples
	string texto = "¡Hola, mundo! =D";	// Los textos se escriben siempre entre comillas dobles
	bool booleano = true;				// En los booleanos se pone simplemente true o false sin ningún tipo de marca adicional

	// Las cinco variables anteriores están declaradas e inicializadas (es decir, las hemos creado y además les hemos dado un valor)

	// Aquí abajo mostramos en Unity el valor de cada variable

	void Awake()
	{
		Debug.Log(entero);
		Debug.Log(real);
		Debug.Log(caracter);
		Debug.Log(texto);
		Debug.Log(booleano);
	}


	// ----- Ahora puedes realizar los EJERCICIOS F de creación de variables -----
}
