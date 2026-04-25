using UnityEngine;

public class UsoDeVariablesApuntes : MonoBehaviour
{
	// -------------------------------------------------- A. VALORES POR DEFECTO (en variables declaradas a nivel de clase) --------------------------------------------------


	// Cuando declaramos una variable a nivel de clase (es decir, fuera de un método) y no guardamos ningún dato en ella, esa variable recibe un valor por defecto
	//		- El valor por defecto de una variable numérica (como int o float) es 0
	//		- El valor por defecto de un booleano es false
	//		- El valor por defecto de un string es null

	int unNumero = 5;	// En esta variable hemos guardado un dato (el número 5)

	// En las siguientes variables no hemos guardado ningún dato

	int otroNumero;		// Al ser de tipo int, tendrá como valor por defecto 0
	float numeroReal;	// Al ser de tipo float, tendrá también como valor por defecto 0 (0.0f)
	bool booleano;		// Al ser de tipo bool, tendrá como valor por defecto false
	string texto;		// Al ser de tipo string, tendrá como valor por defecto null

	// Los valores por defecto de los números y los booleanos se pueden usar sin problema, porque tanto 0 como false son datos perfectamente válidos (0 es un número válido y false es un booleano válido)
	// Con los textos, sin embargo, no pasa lo mismo: si un string tiene valor nulo y lo usamos, por lo general dará error, porque el valor null lo que hace es indicar que en esa variable no hay ningún dato guardado
	// Por tanto, al no haber absolutamente nada en esa variable, en la mayoría de casos no podremos hacer nada con ella


	// ----- Ahora puedes realizar los EJERCICIOS A de uso de variables -----


	void Awake()
	{
		// -------------------------------------------------- B. VALORES POR DEFECTO (en variables declaradas dentro de un método) --------------------------------------------------


		// Al contrario de lo que ocurre con las variables que hemos creado arriba, si declaramos una variable en un método y no guardamos ningún dato en ella, esa variable NO recibe un valor por defecto
		// Por tanto, las variables que están creadas dentro de un método no se pueden usar si no hemos guardado primero algún dato en ellas

		int numeroA; // Hemos declarado esta variable dentro de un método y no la hemos inicializado, así que al intentar utilizarla dará error

		//Debug.Log(numeroA); // ¡Error! La variable numeroA está declarada dentro de un método, por lo que NO recibe ningún valor por defecto y, por tanto, no se puede usar hasta que se haya inicializado

		numeroA = 10; // Inicializamos la variable que hemos creado dentro del método
		
		Debug.Log(numeroA);	// Ahora que la variable está inicializada podemos usarla sin problema


		// ----- Ahora puedes realizar los EJERCICIOS B de uso de variables -----
		

		// -------------------------------------------------- C. USAR VARIABLES (Debug.Log) --------------------------------------------------


		// Una forma de usar variables es ponerlas dentro de los paréntesis de ciertos métodos para que esos métodos hagan algo con ellas (como hemos hecho un poco más arriba)
		// Dentro de los paréntesis de un Debug.Log, por ejemplo, podemos poner todo tipo de datos y variables con el fin de mostrarlos en la consola de Unity

		Debug.Log("Mostramos las variables que han sido declaradas a nivel de clase (solo la primera está inicializada, las demás contienen valores por defecto)");
		Debug.Log(unNumero);	// Se muestra el número 5 (que es el dato que hemos guardado al principio en la variable)
		Debug.Log(otroNumero);	// Se muestra el número 0 (que es el valor por defecto de un int)
		Debug.Log(numeroReal);	// Se muestra el número 0 (que es el valor por defecto de un float)
		Debug.Log(booleano);	// Se muestra false (que es el valor por defecto de un bool)
		Debug.Log(texto);		// Se muestra la palabra "Null", informándonos de que la variable tiene valor nulo (es decir, no contiene ningún dato válido)
		
		// Cuando escribimos el nombre de una variable entre los paréntesis de un método, es como si estuviéramos poniendo el dato que hemos guardado en esa variable
		// Por tanto, si en una variable hemos guardado el número 5, al poner el nombre de esa variable es como si estuviéramos poniendo el número 5
		
		Debug.Log("Mostramos primero el número 5 y a continuación una variable en la que hemos guardado el número 5 (el resultado en ambos casos es el mismo)");
		Debug.Log(5);			// Esto muestra el número 5
		Debug.Log(unNumero);	// Esto también muestra el número 5, porque ese es el dato que está guardado en la variable


		// ----- Ahora puedes realizar los EJERCICIOS C de uso de variables -----
		

		// -------------------------------------------------- D. USAR VARIABLES (transferir datos) --------------------------------------------------


		// Otra cosa que podemos hacer con las variables es usarlas para "transferir" datos, es decir, guardar el dato de una variable en otra distinta, de modo que las dos acaben teniendo el mismo valor

		int numeroB = numeroA; // En la variable numeroA hemos guardado antes el número 10 y ahora ese mismo número lo estamos copiando en la variable numeroB, de modo que las dos variables ahora valen 10
		
		Debug.Log("Mostramos dos variables (en la segunda hemos guardado el dato que había en la primera, así que las dos valen lo mismo)");
		Debug.Log(numeroA);	// Esto muestra el número 10
		Debug.Log(numeroB);	// Esto también muestra el número 10

		// Aunque hayamos guardado el dato de una variable en la otra, las dos variables siguen siendo independientes
		// Por tanto, si ahora queremos guardar un dato distinto en cualquiera de las dos variables, podemos hacerlo sin que la otra se vea afectada

		numeroA = 20; // Esto no afecta para nada al número B
		
		Debug.Log("Mostramos las dos mismas variables de antes, pero en la primera hemos guardado un dato distinto (sin que eso afecte a la segunda)");
		Debug.Log(numeroA);	// Esto ahora muestra el número 20
		Debug.Log(numeroB);	// Esto sigue mostrando el número 10

		// Gracias a eso, podemos hacer cosas como intercambiar el valor de dos variables
		// Por ejemplo, el número A ahora vale 20 y el número B vale 10, pero con la ayuda de una nueva variable podemos hacer que el número A tenga el valor de B y viceversa
		// Para ello tenemos que seguir tres pasos

		int numeroC = numeroA;	// [Paso 1] Creamos una nueva variable (numeroC) y guardamos en ella el número A (por tanto, el número C vale 20)
		numeroA = numeroB;		// [Paso 2] Guardamos el número B en la variable numeroA (ahora tanto el número A como el B valen 10, mientras que el C sigue valiendo 20)
		numeroB = numeroC;		// [Paso 3] Guardamos el número C en la variable numeroB (el número A sigue valiendo 10, pero ahora el número B vale lo mismo que C, es decir, 20)

		// El resultado tras completar los tres pasos anteriores es que los valores de los números A y B se han intercambiado (antes A era 20 y B era 10, y ahora es al revés)
		
		Debug.Log("Mostramos las dos variables de antes con sus valores intercambiados");
		Debug.Log(numeroA);	// Esto muestra el número 10
		Debug.Log(numeroB); // Esto muestra el número 20

		// Esto que hemos estado haciendo aquí (guardar los datos de unas variables en otras) por lo general solo es posible cuando las variables son del mismo tipo
		// Sin embargo, si intentamos guardar un dato de tipo int o float (por ejemplo) en una variable de tipo string, nos va a dar error, porque sus tipos son diferentes

		numeroReal = 3.14f;

		float otroNumeroReal = numeroReal;	// Correcto: estamos guardando el dato de una variable de tipo float en otra variable que también es de tipo float
		//string unTexto = numeroReal;		// ¡Error! No podemos guardar directamente el valor de una variable numérica en un string, porque los tipos no coinciden
		
		Debug.Log("Mostramos dos variables de tipo float que tienen el mismo valor (3.14f)");
		Debug.Log(numeroReal);
		Debug.Log(otroNumeroReal);
		

		// -------------------------------------------------- E. USAR VARIABLES (acceder a ciertas propiedades y funciones) --------------------------------------------------


		// En todas las variables, si ponemos un punto justo detras del nombre, podremos acceder a ciertas características y funcionalidades
		// Al hacer esto tenemos que tener especial cuidado con las variables que puedan ser nulas, porque al tener un valor de null es como si no hubiera nada en ellas
		// Un ejemplo de eso sería la variable de tipo string que creamos al principio de este script (la que se llama texto), ya que al no estar inicializada sigue teniendo aún su valor por defecto, que es null

		//Debug.Log(texto.Length); // ¡Error! La variable texto es nula, por lo que no contiene absolutamente nada y al intentar hacer algo con ella nos aparecerá un error rojo en la consola

		// Un detalle importante aquí es que, cuando hemos mostrado antes esa misma variable en la consola, no ha ocurrido ningún error, simplemente nos ha aparecido en la consola la palabra "Null"
		// La diferencia es que antes simplemente estábamos mostrando el contenido de la variable, pero sin intentar hacer nada con ese contenido (solo mostrarlo y ya)
		// Ahora, sin embargo, sí que estamos intentando usar ese contenido
		// Es por eso por lo que aparece el error: estamos intentando usar algo que en realidad no existe

		// Básicamente es como entrar a una tienda de golosinas, señalar a un estante vacío en una estantería completamente vacía y preguntar: "Disculpe, ¿cuántas golosinas hay en esa bolsa de ahí?"
		// La persona que esté en el mostrador probablemente se quede bastante confusa, porque en ese estante que estás señalando no hay absolutamente nada, está vacío
		// Pues eso mismo es lo que está ocurriendo en este caso: estamos preguntando cuántos caracteres hay en el texto (texto.Length), solo que... no existe ningún texto

		// Por tanto, para poder usar el dato que hemos guardado en una variable sin que nos salga un error tenemos que asegurarnos de que esa variable realmente contiene algo

		texto = "Hola"; // Guardamos un dato en la variable texto

		// Cuando ahora intentemos acceder a alguna propiedad de esa variable (poniendo un punto a continuación del nombre), todo funcionará de manera correcta y sin errores, porque el texto ahora sí contiene un dato válido

		Debug.Log("Mostramos el total de caracteres que hay en la palabra 'Hola' (4)");
		Debug.Log(texto.Length); // Como la variable texto ya está inicializada, ha dejado de tener un valor nulo y, por tanto, podemos acceder a todas sus características y funcionalidades sin que aparezcan errores
	}

	void Update()
	{
		// -------------------------------------------------- F. APUNTES ADICIONALES --------------------------------------------------


		// Las variables se declaran poniendo primero su tipo y luego su nombre, pero a la hora de usarlas se escribe tan solo el nombre y ya
		// Además, para poder usarlas es necesario haberlas declarado previamente (es decir, que no podemos usar una variable a la vez que la declaramos, por ejemplo)
		// Por tanto, estos dos ejemplos de aquí abajo serían incorrectos

		//Debug.Log(int numero = 4);	// ¡Error! La variable numero ya debería estar declarada (e inicializada) antes de ponerla en el Debug.Log
		//string hola.Length;			// ¡Error! La variable hola ya debería estar declarada (e inicializada) antes de acceder a sus propiedades

		// En ambos casos estamos intentando declarar y usar una variable al mismo tiempo, cosa que no es posible

		// Y algo que tampoco podemos hacer es usar en un método una variable que hemos declarado en otro método diferente
		// Por tanto, esto de aquí abajo tampoco es correcto

		//Debug.Log(numeroA); // ¡Error! La variable numeroA está declarada en el método Awake y, por tanto, no existe aquí: si quisiéramos usar en este método una variable con ese nombre, tendríamos que declararla primero

		// Ese problema no ocurre, sin embargo, con las variables declaradas a nivel de clase: esas variables se pueden utilizar en cualquier método, porque no pertenecen a ninguno en particular
		// Además, al hacer eso comprobaremos que las variables contienen el último dato que hayamos guardado en ellas

		numeroReal = 3.14159f;
		booleano = true;
		
		Debug.Log("Mostramos de nuevo todas las variables que han sido declaradas a nivel de clase (con sus valores actualizados)");
		Debug.Log(unNumero);	// Se muestra el número 5 (el mismo del principio, porque en ningún momento lo hemos cambiado)
		Debug.Log(otroNumero);	// Se muestra el número 0 (el mismo del principio, porque tampoco lo hemos cambiado)
		Debug.Log(numeroReal);	// Se muestra el número 3.14159 (al principio era 0 y en el método Awake lo cambiamos a 3.14, pero lo hemos vuelto a cambiar de nuevo aquí)
		Debug.Log(booleano);	// Se muestra true (al principio era false, pero lo hemos cambiado aquí)
		Debug.Log(texto);		// Se muestra la palabra "Hola" (al principio no tenía ningún valor, pero le dimos uno en el método Awake)
	}
}
