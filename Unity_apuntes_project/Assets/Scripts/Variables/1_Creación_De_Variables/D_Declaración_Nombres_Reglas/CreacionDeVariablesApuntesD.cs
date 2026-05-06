using UnityEngine;

public class CreacionDeVariablesApuntesD : MonoBehaviour
{
    // -------------------------------------------------- D. DECLARACIÓN DE VARIABLES (nombres - reglas) --------------------------------------------------


	// El nombre es una de las dos informaciones obligatorias que tenemos que poner al declarar una variable
	// El nombre de una variable sirve para identificarla y distinguirla de otras, y es lo que tendremos que escribir siempre que queramos usarla

	// En los siguientes ejemplos, la primera palabra indica el tipo de la variable y la segunda es el nombre que hemos decidido darle

	int	entero;
	float real;
	char caracter;
	string texto;
	bool booleano;

	// Al darle un nombre a una variable podemos escribir más o menos lo que queramos, pero hay algunas normas que debemos cumplir (de lo contrario, el código no funcionará)
	//		- No debe contener espacios
	//		- No debe llevar ningún carácter especial (asterisco, signo de exclamación, etc.), a excepción del guion bajo
	//		- Puede contener números, pero nunca al principio
	//		- En la mayoría de casos, los nombres deben ser únicos y no coincidir con los de otras variables
	//		- No podemos utilizar como nombres ciertas palabras especiales, como int, float, bool, class, public...

	//int numero entero;	// ¡Error! Un nombre de variable no puede contener espacios
	int numeroEntero;		// Correcto

	//float numero-real;	// ¡Error! Un nombre de variable no puede contener caracteres especiales (como guiones, paréntesis, etc.)
	float numeroReal;		// Correcto

	//char 1caracter;		// ¡Error! Un nombre de variable puede contener números, pero nunca al principio
	char caracter1;			// Correcto

	//string texto;			// ¡Error! Un nombre de variable no debe coincidir con el de otra variable que ya exista en el mismo sitio
	string otroTexto;		// Correcto

	//bool string;			// ¡Error! Hay ciertas palabras especiales que no pueden usarse como nombres de variables
	bool esPublico;			// Correcto


	// ----- Ahora puedes realizar los EJERCICIOS D de creación de variables -----
}
