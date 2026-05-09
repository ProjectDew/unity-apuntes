using UnityEngine;

public class UsoDeVariablesApuntesC : MonoBehaviour
{
	// -------------------------------------------------- C. VALORES POR DEFECTO (en métodos) --------------------------------------------------
	

	// Las variables no solo se pueden declarar directamente en una clase (como esta de aquí abajo), sino también dentro de métodos

	string variableClase;		// Esta variable está declarada directamente en la clase

	void Awake()
	{
		string variableMetodo;	// Esta otra variable está declarada dentro de un método
		
		// Al contrario de lo que ocurre con las variables declaradas directamente en una clase, las que se declaran dentro de métodos no tienen un valor por defecto
		// Por tanto, una variable declarada en un método debe inicializarse siempre sin excepciones o de lo contrario no se podrá usar de ninguna manera

		//Debug.Log(variableMetodo); // ¡Error! Esta variable está declarada dentro de un método, así que no tiene un valor por defecto y, por tanto, no se puede usar
		
		variableMetodo = "Variable inicializada"; // Inicializamos la variable

		Debug.Log(variableMetodo); // Ahora que la variable que hemos declarado en el método ya está inicializada, podemos usarla sin ningún problema
		
		// Además, no solo es importante que la variable esté inicializada, sino que también debe estar declarada ANTES de usarse
		// Por ejemplo, esta línea de aquí abajo sería incorrecta, porque estamos intentando usar una variable que todavía no hemos declarado

		//Debug.Log(entero);	// ¡Error! Esta variable aún no está declarada (lo hacemos justo después), así que es como si todavía no existiera y, por tanto, no se puede usar

		int entero = 2; // Declaramos e inicializamos aquí la variable

		Debug.Log(entero);		// Correcto, porque ahora la variable ya sí que está declarada e inicializada y, por tanto, sí se puede usar

		// En el caso de las variables de tipo string, cuando las inicializamos podemos hacer si queremos que su valor sea nulo (aunque no es lo más recomendable)
		// Para ello podemos utilizar la palabra null, que indica que la variable no contiene ningún dato válido
		// Sin embargo, a pesar de no contener un dato válido, en este caso sí que la podemos mostrar en la consola de Unity
		// Eso es porque, aunque el valor de la variable no sea válido (por ser nulo), al menos hay un valor
		// Arriba, sin embargo, cuando la variable estaba aún sin inicializar, el problema es que directamente no había nada

		variableMetodo = null;			// Esta variable ahora no contiene ningún dato válido, pero al menos tiene un valor (aunque sea nulo)

		Debug.Log(variableMetodo);		// No podíamos mostrar esta variable en consola cuando estaba sin inicializar, pero sí que podemos hacerlo cuando su valor es nulo (nos aparecerá la palabra "Null")

		// Sin embargo, por norma general no es recomendable dar valores nulos a las variables, ya que, aunque no nos aparezcan errores al escribir el código, sí que pueden provocar otros más adelante
		// Algo que podríamos hacer si quisiéramos con una variable de tipo string sería escribir un texto vacío, es decir, un texto sin nada dentro, como aquí abajo

		variableMetodo = "";			// Al poner las dobles comillas sin nada dentro estamos creando un texto vacío

		Debug.Log(variableMetodo);		// Al mostrar ahora la variable en la consola de Unity, lo que va a salir es un mensaje en blanco, sin nada escrito


		// ----- Ahora puedes realizar los EJERCICIOS C de uso de variables -----
	}
}
