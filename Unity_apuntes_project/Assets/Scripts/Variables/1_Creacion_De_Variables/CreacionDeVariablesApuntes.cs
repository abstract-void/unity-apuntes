using UnityEngine;

public class CreacionDeVariablesApuntes : MonoBehaviour
{
	// Las variables sirven para almacenar o guardar datos (números, textos...) mientras el programa se está ejecutando
	// Las variables son importantes por dos motivos:
	//		- Nos permiten darles un nombre a todos los datos que vamos a usar, lo que nos ayuda a identificar con facilidad qué es cada cosa
	//		- Se crean una única vez, pero se pueden usar tantas veces como queramos (y, si modificamos el dato de una variable, ese dato cambiará en todos los sitios donde estemos usando la variable)

	// Antes de poder usar una variable, tenemos que crearla e inicializarla (inicializar una variable es guardar un dato en ella por primera vez)
	// A la hora de crearla, necesitamos poner (al menos) dos informaciones: de qué tipo es la variable y qué nombre le vamos a dar
	//		- El tipo de una variable indica qué clase de dato podemos guardar en ella (no es lo mismo un texto que un número, por ejemplo)
	//		- El nombre de una variable es lo que tendremos que escribir cuando queramos usar el dato que hemos guardado en ella

	// Respecto al tipo, en C# hay una serie de tipos básicos que sirven para guardar datos más o menos simples
	// Algunos de los más usados en Unity son los siguientes:
	//		- int: un número entero (no puede tener decimales)
	//		- float: un número real (puede o no tener decimales)
	//		- char: un carácter, es decir, una letra ('a', 'J'), un símbolo ('*', '$') o un número de una sola cifra ('0', '9')
	//		- string: un texto o cadena de caracteres (es decir, cero o más caracteres colocados uno detrás de otro formando un texto)
	//		- bool: solo puede guardar dos valores, que son verdadero (true) o falso (false)

	// En cuanto al nombre, podemos escribir más o menos lo que queramos, pero debemos seguir algunas normas o recomendaciones
	//		- No debe contener espacios
	//		- Exceptuando el guion bajo (y en muy raras ocasiones la arroba), no debe llevar ningún carácter especial (como asteriscos, signos de exclamación, etc.)
	//		- Debería empezar siempre por minúscula o guion bajo (en caso de que empiece por guion bajo, la siguiente letra debería ser siempre minúscula)
	//		- Si el nombre de la variable contiene varias palabras, todas excepto la primera deberían empezar por mayúscula
	//		- Cuando dos o más variables se encuentran en la misma "zona" de una clase (el mismo ámbito), sus nombres deben ser únicos y no coincidir unos con otros

	// Algunas variables de ejemplo:

	int entero;		// Número sin decimales
	float real;		// Número con o sin decimales
	char caracter;	// Letra, símbolo o número de una sola cifra
	string texto;	// Conjunto de caracteres que forman un texto
	bool booleano;	// Verdadero o falso
	
	// Esto que acabamos de hacer aquí arriba se llama "declarar" (crear) variables, pero sin inicializarlas (es decir, sin guardar ningún dato en ellas)
	// Sin embargo, las variables también se pueden inicializar al mismo tiempo que se declaran
	// Para inicializar una variable se utiliza el símbolo de igual =
	// Según el tipo que tenga la variable, podremos asignarle unos datos u otros
	// Y a esos datos a veces es necesario añadirles ciertas "marcas" para distinguirlos
	//		- Los datos de tipo float llevan detrás una letra 'f' (o 'F')
	//		- Los datos de tipo char se escriben entre comillas simples
	//		- Los datos de tipo string se escriben entre comillas dobles
	//		- Los booleanos no llevan ningún tipo de marca especial, pero su valor solo puede ser "true" o "false"

	// Ejemplos:

	int numeroEntero = 1;				// Los números int no llevan nada especial
	float numeroReal = 3.14159f;		// Los números float llevan detrás una letra 'f' (o 'F')
	char caracter2 = 'a';				// Los caracteres se escriben siempre entre comillas simples
	string holaMundo = "¡Hola, mundo!";	// Los textos se escriben siempre entre comillas dobles
	bool encendido = true;				// En los booleanos se pone simplemente "true" o "false" sin ningún tipo de marca adicional

	// Las cinco variables anteriores están declaradas e inicializadas (es decir, están creadas y además se ha guardado algún dato en ellas)
	// Aparte, hemos tenido cuidado de darle a cada variable un nombre único: ninguna de las variables (ni estas ni las cinco anteriores) se llama igual que el resto, todos los nombres son diferentes entre sí

	//int entero; // ¡Error! Esto no se puede hacer porque arriba ya existe una variable con este mismo nombre

	// Como nota final, siempre que se declare o se inicialice una variable, al final de la línea tendremos que poner sí o sí un punto y coma
}
