using UnityEngine;

public class CreacionDeVariablesApuntesC : MonoBehaviour
{
	// -------------------------------------------------- C. DECLARACIÓN DE VARIABLES (tipos) --------------------------------------------------


	// El tipo es una de las dos informaciones obligatorias que tenemos que poner al declarar una variable
	// El tipo de una variable es lo que indica qué clase de dato vamos a guardar en ella (no es lo mismo un texto que un número, por ejemplo)

	// En C# hay una serie de tipos básicos que sirven para guardar datos más o menos simples
	// Algunos de los más usados en Unity son los siguientes:
	//		- int: un número entero (no puede tener decimales)
	//		- float: un número real, es decir, que puede tener decimales o no
	//		- char: un carácter (y solo uno), que puede ser una letra ('a', 'J'), un símbolo ('*', '$') o una cifra ('0', '9')
	//		- string: un texto o cadena de caracteres (es decir, cero o más caracteres colocados uno detrás de otro formando un texto)
	//		- bool: solo puede guardar dos valores, que son verdadero (true) o falso (false)

	// A la hora de declarar una variable, elegiremos un tipo u otro en función de los datos que necesitemos (string si es un texto, float si es un número que puede tener decimales, etc.)
	// En los siguientes ejemplos, la primera palabra es la que indica el tipo de la variable

	int	entero;		// int		-> Número sin decimales
	float real;		// float	-> Número con o sin decimales
	char caracter;	// char		-> Letra, símbolo o número (solo uno)
	string texto;	// string	-> Conjunto de caracteres que forman un texto
	bool booleano;	// bool		-> Verdadero o falso


	// ----- Ahora puedes realizar los EJERCICIOS C de creación de variables -----
}
