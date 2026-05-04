using UnityEngine;

public class CreacionDeVariablesApuntesC : MonoBehaviour
{
    // -------------------------------------------------- C. DECLARACIÓN DE VARIABLES (nombres) --------------------------------------------------


	// El nombre es una de las dos informaciones obligatorias que tenemos que poner al declarar una variable (tipo y nombre)
	// El nombre de una variable sirve para identificarla y distinguirla de otras, y es lo que tendremos que escribir siempre que queramos usarla

	// En los siguientes ejemplos, la primera palabra indica el tipo de la variable y la segunda es el nombre que hemos decidido darle:

	int	entero;
	float real;
	char caracter;
	string texto;
	bool booleano;

	// Al darle un nombre a una variable podemos escribir más o menos lo que queramos, pero hay algunas normas que debemos cumplir (de lo contrario, el código no funciona):
	//		- No debe contener espacios
	//		- No debe llevar ningún carácter especial (como asteriscos, signos de exclamación, etc.), con la única excepción del guion bajo
	//		- Puede contener números, pero nunca al principio
	//		- Por lo general, sus nombres deben ser únicos y no coincidir unos con otros
	//		- No podemos utilizar como nombres ciertas palabras especiales, como int, float, bool, class, public, etc.

	//int numero entero;	// ¡Error! Un nombre de variable no puede contener espacios
	int numeroEntero;		// Correcto

	//float numero-real;	// ¡Error! Un nombre de variable no puede contener caracteres especiales (como guiones, paréntesis, etc.)
	float numeroReal;		// Correcto

	//char 1caracter;		// ¡Error! Un nombre de variable puede contener números, pero nunca al principio
	char caracter1;			// Correcto

	//string texto;			// ¡Error! Esta variable se llama igual que otra que hemos declarado arriba, los nombres no deben coincidir
	string otroTexto;		// Correcto

	//bool string;			// ¡Error! Hay ciertas palabras especiales que no pueden usarse como nombres de variables
	bool esPublico;			// Correcto

	// Al darle un nombre a una variable hay ciertas recomendaciones que deberíamos seguir (si no se siguen, el código funciona, pero no es del todo correcto y puede crear confusión):
	//		- El nombre debería empezar casi siempre por minúscula, aunque en ciertos casos se puede usar guion bajo y en rarísimas ocasiones una arroba
	//		- Si el nombre empieza por guion bajo o arroba, la siguiente letra debería ser siempre minúscula
	//		- Si el nombre contiene varias palabras, todas excepto la primera deberían empezar por mayúscula (y deberían ir pegadas unas a otras, sin separarse de ninguna forma)
	//		- Debería poder entenderse con facilidad qué es lo que estamos guardando en la variable

	string Nombre;			// Incorrecto: los nombres de variables deberían empezar siempre por minúscula (o guion bajo en determinados casos)
	string nombre;			// Correcto

	bool _Apagado;			// Incorrecto: cuando el nombre empieza por guion bajo, la siguiente letra debería ir en minúscula
	bool _apagado;			// Correcto

	int numeropositivo;		// Incorrecto: si un nombre contiene varias palabras, todas salvo la primera deberían empezar por mayúscula
	int numeroPositivo;		// Correcto

	float numero_Decimal;	// Incorrecto: todas las palabras que formen parte del nombre deberían ir juntas (sin caracteres que las separen)
	float numeroDecimal;	// Correcto

	char ________;			// Incorrecto: con ese nombre es imposible saber qué es lo que hace esta variable
	char letraInicial;		// Correcto


	// ----- Ahora puedes realizar los EJERCICIOS C de creación de variables -----
}
