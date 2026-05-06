using UnityEngine;

public class CreacionDeVariablesApuntesE : MonoBehaviour
{
    // -------------------------------------------------- E. DECLARACIÓN DE VARIABLES (nombres - recomendaciones) --------------------------------------------------


	// Al darle un nombre a una variable hay varias recomendaciones que pueden hacer que nos resulte más sencillo entender nuestro propio código y el de otras personas
	// Si nos acostumbramos a seguir las siguientes pautas, vamos a ser capaces de identificar de inmediato una variable tan solo con ver su nombre
	//		- El nombre debería empezar en general por minúscula, aunque en ciertos casos puede empezar por guion bajo y en rarísimas ocasiones por arroba
	//		- Si el nombre empieza por guion bajo o arroba, la siguiente letra debería ser minúscula
	//		- Si el nombre contiene varias palabras, todas excepto la primera deberían empezar por mayúscula
	//		- Además, si contiene varias palabras no debería usarse guion bajo para separarlas, deberían ir pegadas
	//		- Solo con leer el nombre debería poderse entender con facilidad qué dato es el que estamos guardando en la variable

	string Nombre;			// Incorrecto: los nombres de variables deberían empezar siempre por minúscula (o guion bajo en determinados casos)
	string nombre;			// Correcto

	bool _Apagado;			// Incorrecto: cuando el nombre empieza por guion bajo, la siguiente letra debería ir en minúscula
	bool _apagado;			// Correcto

	int numeropositivo;		// Incorrecto: si un nombre contiene varias palabras, todas salvo la primera deberían empezar por mayúscula
	int numeroPositivo;		// Correcto

	float numero_Decimal;	// Incorrecto: si un nombre contiene varias palabras, no debería usarse guion bajo para separarlas
	float numeroDecimal;	// Correcto

	char ________;			// Incorrecto: con ese nombre es imposible saber qué es lo que hace esta variable, un nombre debería entenderse con facilidad
	char letraInicial;		// Correcto


	// ----- Ahora puedes realizar los EJERCICIOS E de creación de variables -----
}
