using UnityEngine;

public class CreacionDeVariablesApuntesB : MonoBehaviour
{
	// -------------------------------------------------- B. DECLARACIÓN DE VARIABLES (tipos) --------------------------------------------------


	// Siempre que vayamos a usar una variable, tenemos que crearla primero
	// Cuando creamos una variable decimos que estamos "declarando" la variable (declarar variables = crear variables)

	// Al declarar una variable, tenemos que poner (al menos) dos informaciones: de qué tipo es y qué nombre le vamos a dar (en ese orden)
	//		- El tipo de una variable indica qué clase de dato vamos a guardar en ella (no es lo mismo un texto que un número, por ejemplo)
	//		- El nombre de una variable sirve para identificarla y distinguirla de otras, y es lo que tendremos que escribir siempre que queramos usarla

	// Respecto al tipo, en C# hay una serie de tipos básicos que sirven para guardar datos más o menos simples
	// Algunos de los más usados en Unity son los siguientes:
	//		- int: un número entero (no puede tener decimales)
	//		- float: un número real, es decir, que puede o no tener decimales
	//		- char: un carácter (y solo uno), que puede ser una letra ('a', 'J'), un símbolo ('*', '$') o una cifra ('0', '9')
	//		- string: un texto o cadena de caracteres (es decir, cero o más caracteres colocados uno detrás de otro formando un texto)
	//		- bool: solo puede guardar dos valores, que son verdadero (true) o falso (false)

	// Algunas variables de ejemplo:

	int	entero;		// Número sin decimales
	float real;		// Número con o sin decimales
	char caracter;	// Letra, símbolo o número (pero solo uno)
	string texto;	// Conjunto de caracteres que forman un texto
	bool booleano;	// Verdadero o falso

	// Fíjate bien en la estructura de las variables anteriores

	// TIPO		NOMBRE

	// int		entero;
	// float	real;
	// char		caracter;
	// string	texto;
	// bool		booleano;

	// Esta estructura es la que tendremos que usar cada vez que vayamos a declarar (crear) una nueva variable: primero ponemos su tipo y a continuación su nombre
	// Y en el caso del tipo elegiremos uno u otro en función del dato que vayamos a guardar (string si es un texto, float si es un número que puede tener decimales, etc.)


	// ----- Ahora puedes realizar los EJERCICIOS B de creación de variables -----
}
