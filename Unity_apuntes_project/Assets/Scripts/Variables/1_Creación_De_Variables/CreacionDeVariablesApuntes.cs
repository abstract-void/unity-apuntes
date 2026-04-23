using UnityEngine;

public class CreacionDeVariablesApuntes : MonoBehaviour
{
	// -------------------------------------------------- A. VARIABLES --------------------------------------------------


	// Las variables sirven para almacenar o guardar datos (números, textos...) mientras el programa se está ejecutando
	// Las variables son importantes por dos motivos:
	//		- Nos permiten darles un nombre único a todos los datos que vamos a usar, lo que nos ayuda a identificar con facilidad qué es cada cosa
	//		- Se crean una sola vez, pero se pueden usar tantas veces como queramos (y, si modificamos el dato de una variable, ese dato cambiará en todos los sitios donde estemos usando la variable)


	// ----- Realiza los ejercicios del siguiente documento: CreacionDeVariablesEjerciciosA -----
	

	// -------------------------------------------------- B. DECLARACIÓN DE VARIABLES (tipos) --------------------------------------------------


	// Antes de poder usar una variable, tenemos que declararla (crearla) e inicializarla (guardar un dato en ella por primera vez)
	// Al crearla, necesitamos poner (al menos) dos informaciones: de qué tipo es la variable y qué nombre le vamos a dar (en ese orden)
	//		- El tipo de una variable indica qué clase de dato podemos guardar en ella (no es lo mismo un texto que un número, por ejemplo)
	//		- El nombre de una variable es lo que tendremos que escribir cada vez que queramos usar el dato que hemos guardado en ella

	// Respecto al tipo, en C# hay una serie de tipos básicos que sirven para guardar datos más o menos simples
	// Algunos de los más usados en Unity son los siguientes:
	//		- int: un número entero (no puede tener decimales)
	//		- float: un número real (puede o no tener decimales)
	//		- char: un carácter, es decir, una letra ('a', 'J'), un símbolo ('*', '$') o una cifra ('0', '9')
	//		- string: un texto o cadena de caracteres (es decir, cero o más caracteres colocados uno detrás de otro formando un texto)
	//		- bool: solo puede guardar dos valores, que son verdadero (true) o falso (false)

	// Algunas variables de ejemplo:

	int entero;		// Número sin decimales
	float real;		// Número con o sin decimales
	char caracter;	// Letra, símbolo o número de una sola cifra
	string texto;	// Conjunto de caracteres que forman un texto
	bool booleano;	// Verdadero o falso
	

	// -------------------------------------------------- C. DECLARACIÓN DE VARIABLES (nombres) --------------------------------------------------


	// En cuanto al nombre de las variables, podemos escribir más o menos lo que queramos, pero debemos seguir algunas normas o recomendaciones

	// Normas al escribir un nombre de variable (si no se cumplen, el código no funciona):
	//		- No debe contener espacios
	//		- Exceptuando el guion bajo, no debe llevar ningún carácter especial (como asteriscos, signos de exclamación, etc.)
	//		- Puede contener números, pero nunca al principio
	//		- Cuando dos o más variables se encuentran en la misma "zona" de una clase (el mismo ámbito), sus nombres deben ser únicos y no coincidir unos con otros

	//int numero entero;	// ¡Error! Un nombre de variable no puede contener espacios
	int numeroEntero;		// Correcto

	//float numero-real;	// ¡Error! Un nombre de variable no puede contener caracteres especiales (como guiones, paréntesis, etc.)
	float numeroReal;		// Correcto

	//string 1texto;		// ¡Error! Un nombre de variable puede contener números, pero nunca al principio
	string texto1;			// Correcto

	//char caracter;		// ¡Error! Esta variable se llama igual que otra que hemos declarado arriba, los nombres no deben coincidir
	char otroCaracter;		// Correcto

	// Recomendaciones al escribir un nombre de variable (el código funciona aunque no se sigan, pero no es del todo correcto):
	//		- El nombre debería empezar siempre por minúscula, guion bajo (en ciertos casos) o arroba (en muy raras ocasiones)
	//		- Si el nombre empieza por guion bajo o arroba, la siguiente letra debería ser siempre minúscula
	//		- Si el nombre contiene varias palabras, todas excepto la primera deberían empezar por mayúscula (y no deberían separarse de ninguna forma)
	//		- Debería poder entenderse con facilidad qué es lo que estamos guardando en la variable

	string Nombre;			// Esto funciona, pero no es lo recomendado: los nombres de variables deberían empezar siempre por minúscula (o guion bajo en determinados casos)
	string nombre;			// Correcto

	bool _Apagado;			// Esto funciona, pero no es lo recomendado: cuando el nombre empieza por guion bajo, la siguiente letra debería ir en minúscula
	bool _apagado;			// Correcto

	int numeropositivo;		// Esto funciona, pero no es lo recomendado: si un nombre contiene varias palabras, todas salvo la primera deberían empezar por mayúscula
	int numeroPositivo;		// Correcto

	float numero_Decimal;	// Esto funciona, pero no es lo recomendado: todas las palabras que formen parte del nombre deberían ir juntas (sin caracteres que las separen)
	float numeroDecimal;	// Correcto

	char ________;			// Esto funciona, pero no es lo recomendado: con ese nombre es imposible saber qué es lo que hace esta variable
	char letraInicial;		// Correcto
	

	// -------------------------------------------------- D. INICIALIZACIÓN DE VARIABLES --------------------------------------------------

	
	// Esto que acabamos de hacer aquí arriba se llama declarar (crear) variables, pero sin inicializarlas (es decir, sin guardar ningún dato en ellas)
	// Aunque declarar una variable sin inicializarla puede ser correcto y a veces nos interesará hacerlo así, en otras ocasiones nos va a venir mejor declararlas e inicializarlas a la vez
	// Para inicializar una variable (guardar un dato en ella) tendremos que utilizar el símbolo de igual (=) seguido del dato que queramos guardar en la variable

	// Según el tipo que tenga la variable, podremos asignarle unos datos u otros
	// Y a esos datos a veces es necesario añadirles ciertas "marcas" para distinguirlos
	//		- Los datos de tipo float llevan detrás una letra 'f' (o 'F') y, en caso de tener decimales, se separan con un punto (no una coma)
	//		- Los datos de tipo char se escriben entre comillas simples
	//		- Los datos de tipo string se escriben entre comillas dobles
	//		- Los booleanos no llevan ningún tipo de marca especial, pero su valor solo puede ser true o false

	// Ejemplos:

	int ejemploNumeroEntero = 1;			// Los números int no llevan nada especial
	float ejemploNumeroReal = 3.14f;		// Los números float llevan detrás una letra 'f' (o 'F') y, en caso de tener decimales, se separan con un punto (no una coma)
	char ejemploCaracter = 'a';				// Los caracteres se escriben siempre entre comillas simples
	string ejemploTexto = "¡Hola, mundo!";	// Los textos se escriben siempre entre comillas dobles
	bool ejemploBooleano = true;			// En los booleanos se pone simplemente true o false sin ningún tipo de marca adicional

	// Las cinco variables anteriores están declaradas e inicializadas (es decir, están creadas y además se ha guardado algún dato en ellas)
	// Aparte, hemos tenido cuidado de darle a cada variable un nombre único: ninguna de las variables (ni estas ni las cinco anteriores) se llama igual que el resto, todos los nombres son diferentes entre sí

	//int entero; // ¡Error! Esto no se puede hacer porque arriba ya existe una variable con este mismo nombre

	// Como nota final, siempre que se declare o se inicialice una variable, al final de la línea tendremos que poner sí o sí un punto y coma

	void Awake()
	{
		Debug.Log(ejemploNumeroEntero);
		Debug.Log(ejemploNumeroReal);
		Debug.Log(ejemploCaracter);
		Debug.Log(ejemploTexto);
		Debug.Log(ejemploBooleano);
	}
}
