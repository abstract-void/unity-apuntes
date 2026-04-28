using UnityEngine;

public class OperacionesConVariablesApuntes : MonoBehaviour
{
	// -------------------------------------------------- A. OPERADORES --------------------------------------------------


	// Algunos tipos de variables permiten realizar determinadas operaciones con ellas usando una serie de operadores
	// Las más comunes son las variables numéricas (int, float...), con las que es posible realizar una amplia variedad de operaciones matemáticas, como las siguientes:
	//		- Suma:				a + b
	//		- Resta:			a - b
	//		- Multiplicación:	a * b
	//		- División:			a / b
	//		- Módulo:			a % b

	// De todas las operaciones anteriores, la menos familiar quizá sea la del módulo
	// Sin embargo, el módulo no es más que una división normal y corriente, con la diferencia de que, en vez de obtener el resultado, con el módulo obtenemos el resto
	// Por ejemplo, si dividimos el número 6 entre 2, el resultado va a ser 3 y el resto va a ser 0
	// En ese caso, si la división la hemos realizado con el operador de división (/) el resultado será 3, pero si la hemos realizado con el operador de módulo (%) será 0

	// El módulo, por tanto, puede usarse para cosas como comprobar si un número es par o impar
	//		- Si dividimos un número entre 2 y el resto es 0, entonces ese número es par:	4 % 2 = 0
	//		- Si dividimos un número entre 2 y el resto es 1, entonces ese número es impar:	3 % 2 = 1

	// En general, podemos usar el módulo cada vez que necesitemos saber si un número se puede dividir entre otro
	//		- 18 % 9 = 0	// El resto es 0, así que 18 se puede dividir entre 9 (18 es múltiplo de 9)
	//		- 32 % 4 = 0	// El resto es 0, así que 32 se puede dividir entre 4 (32 es múltiplo de 4)
	//		- 11 % 5 = 1	// El resto es 1, así que 11 NO se puede dividir entre 5 (11 NO es múltiplo de 5)


	// ----- Ahora puedes realizar los EJERCICIOS A de operaciones con variables -----

	
	void Awake()
	{
		// -------------------------------------------------- B. OPERACIONES MATEMÁTICAS (usándolas sin guardar el resultado en una variable) --------------------------------------------------


		int numeroA = 4;
		int numeroB = 2;

		// Cuando realizamos una operación matemática, no podemos escribirla sin más en el código y dejarla ahí, sino que tenemos que utilizarla de algún modo

		//numeroA + numeroB; // ¡Error! Estamos realizando una operación matemática con dos números, pero no estamos haciendo nada con esa operación, simplemente está ahí

		// Algo que podríamos hacer con esa operación, por ejemplo, sería ponerla entre los paréntesis de un método para que ese método reciba el resultado de la operación, como aquí abajo
		// Al hacer eso, algo que tenemos que tener en cuenta es que el método no va a recibir los números A y B por separado, sino el resultado de la operación

		Debug.Log("Mostramos los resultados de realizar diversas operaciones con los números 4 y 2 (suma, resta, multiplicación, división y módulo)");

		Debug.Log(numeroA + numeroB); // Esto muestra el resultado de la suma					= 6
		Debug.Log(numeroA - numeroB); // Esto muestra el resultado de la resta					= 2
		Debug.Log(numeroA * numeroB); // Esto muestra el resultado de la multiplicación			= 8
		Debug.Log(numeroA / numeroB); // Esto muestra el resultado de la división				= 2
		Debug.Log(numeroA % numeroB); // Esto muestra el resultado de la operación de módulo	= 0


		// ----- Ahora puedes realizar los EJERCICIOS B de operaciones con variables -----
		

		// -------------------------------------------------- C. OPERACIONES MATEMÁTICAS (guardando el resultado en una nueva variable) --------------------------------------------------


		// Otra cosa que también podemos hacer es guardar en una variable el resultado de la operación y entonces utilizar esa variable donde queramos
		// Algo que debemos tener en cuenta es que, cuando guardamos el resultado de una operación matemática en una variable, la manera de escribir esa línea de código es opuesta a cómo lo haríamos en el mundo real
		// Es decir, que, mientras que en el mundo real haríamos algo como esto: 1 + 1 = 2, al programar lo haríamos justo al revés: 2 = 1 + 1

		int resultado;

		//numeroA + numeroB = resultado;	// ¡Error! En el mundo real pondríamos la operación en este orden, pero al escribir código esto es incorrecto y da error
		resultado = numeroA + numeroB;		// Correcto: siempre que guardemos algo en una variable, la variable va a la izquierda y lo que queremos guardar va a la derecha

		// Más ejemplos:
		
		int resultadoSuma = numeroA + numeroB;				// 6 = 4 + 2
		int resultadoResta = numeroA - numeroB;				// 2 = 4 - 2
		int resultadoMultiplicacion = numeroA * numeroB;	// 8 = 4 * 2
		int resultadoDivision = numeroA / numeroB;			// 2 = 4 / 2
		int resultadoModulo = numeroA % numeroB;			// 0 = 4 % 2
		
		Debug.Log("Mostramos de nuevo los resultados de realizar diversas operaciones con los números 4 y 2 (suma, resta, multiplicación, división y módulo)");

		Debug.Log(resultadoSuma);			// 6
		Debug.Log(resultadoResta);			// 2
		Debug.Log(resultadoMultiplicacion);	// 8
		Debug.Log(resultadoDivision);		// 2
		Debug.Log(resultadoModulo);			// 0


		// ----- Ahora puedes realizar los EJERCICIOS C de operaciones con variables -----
		

		// -------------------------------------------------- D. OPERACIONES MATEMÁTICAS (guardando el resultado en la misma variable) --------------------------------------------------


		int numeroImportante = 3;
		int otroNumero = 2;

		// Cuando obtenemos el resultado de una operación matemática, no siempre vamos a querer crear una variable nueva para guardar ese dato
		// Hay veces que nos interesa que el resultado final se guarde en una de las variables que ya estamos usando para la operación
		// Eso se puede conseguir de un par de maneras diferentes, y una de ellas es muy parecida a lo que haríamos si creáramos una variable nueva

		Debug.Log("Mostramos la misma variable después de ir realizando diversas operaciones con ella y guardando todos los resultados en la propia variable");
		Debug.Log(numeroImportante); // El número importante vale 3

		// Realizamos una operación con dos variables y al mismo tiempo guardamos el resultado en una de esas dos variables

		numeroImportante = numeroImportante + otroNumero; // 3 + 2 = 5
		Debug.Log(numeroImportante); // El número importante ahora vale 5

		numeroImportante = numeroImportante - otroNumero; // 5 - 2 = 3
		Debug.Log(numeroImportante); // El número importante ahora vale 3

		numeroImportante = numeroImportante * otroNumero; // 3 * 2 = 6
		Debug.Log(numeroImportante); // El número importante ahora vale 6

		numeroImportante = numeroImportante / otroNumero; // 6 / 2 = 3
		Debug.Log(numeroImportante); // El número importante ahora vale 3

		numeroImportante = numeroImportante % otroNumero; // 3 % 2 = 1
		Debug.Log(numeroImportante); // El número importante ahora vale 1

		// Es importante intentar pensar siempre cuándo nos viene mejor hacer esto (es decir, usar la misma variable que ya tenemos) o cuándo nos conviene más crear una variable nueva, como habíamos hecho anteriormente
		//		- Si queremos que las variables que ya existen mantengan el valor que tienen ahora (porque lo vamos a usar más adelante), entonces vamos a necesitar una variable nueva
		//		- Si los datos que teníamos guardados en las variables antes de la operación nos dan igual y lo único que nos interesa es el resultado, entonces podemos usar una de las variables que ya tenemos

		// Por ejemplo, si tenemos un personaje que tiene cierta cantidad de vida y recibe daño, ese daño se lo tenemos que restar a la vida
		// Y, al hacer esa operación, nos da igual la vida que tuviera el personaje antes, porque ya no la vamos a necesitar para nada: lo único que nos importa es la vida que tiene ahora
		// Por tanto, no vamos a crear una variable nueva para guardar la vida que le queda ahora al personaje, sino que usaremos la misma variable que ya teníamos de antes

		int vida = 100;
		int daño = 20;
		
		Debug.Log("Vida del personaje antes de recibir daño");
		Debug.Log(vida);

		vida = vida - daño; // La vida que tenía el personaje antes nos da igual, solo nos interesa la que tiene ahora, así que no hace falta crear una variable nueva

		Debug.Log("Vida del personaje después de recibir daño");
		Debug.Log(vida);

		// Ahora imagina que el personaje pasa por un punto de control y según la vida que tenga le vamos a dar más puntuación o menos
		// Así que lo que vamos a hacer es multipliar la vida del personaje por los puntos de bonus, pero en este caso sí nos interesa seguir manteniendo la vida que le queda al personaje, no queremos cambiarla
		// Por tanto, lo que haremos aquí será crear una variable nueva, porque así podemos tener la vida por un lado y la puntuación por otro
		
		int bonus = 10;
		
		Debug.Log("Vida del personaje antes de calcular la puntuación");
		Debug.Log(vida);
		
		int puntuacion = vida * bonus; // Como queremos que la vida del personaje se mantenga igual, no queremos cambiarla, tenemos que crear una variable nueva

		Debug.Log("Vida y puntuación del personaje después de calcular la puntuación");
		Debug.Log(vida);		// La vida no ha cambiado, seguimos teniéndola guardada aquí
		Debug.Log(puntuacion);	// Pero ahora además tenemos la puntuación


		// ----- Ahora puedes realizar los EJERCICIOS D de operaciones con variables -----
		

		// -------------------------------------------------- E. OPERACIONES MATEMÁTICAS (guardando el resultado en la misma variable de forma resumida) --------------------------------------------------
		

		// Arriba hemos visto cómo guardar el resultado de una operación en la misma variable en vez de crear otra nueva
		// Sin embargo, existe otra manera de hacer eso mismo de un modo más resumido, escribiendo un poquito menos de código y sin repetir el nombre de la variable
		// Para ello tenemos que usar los siguientes operadores:
		//		- Suma:				+=
		//		- Resta:			-=
		//		- Multiplicación:	*=
		//		- División:			/=
		//		- Módulo:			%=

		Debug.Log("Mostramos de nuevo la misma variable de antes después de ir realizando diversas operaciones con ella y guardando todos los resultados en la propia variable");

		// Esta línea de abajo es como hemos realizado las operaciones hasta ahora (en este caso, una suma)

		numeroImportante = numeroImportante + otroNumero; // 1 + 2 = 3
		Debug.Log(numeroImportante); // El número importante ahora vale 3

		// Y esta línea de aquí abajo es como se haría la misma operación de arriba, pero de forma más resumida

		numeroImportante += otroNumero; // 3 + 2 = 5
		Debug.Log(numeroImportante); // El número importante ahora vale 5

		// Y lo mismo valdría para cualquiera de las otras operaciones matemáticas

		numeroImportante -= otroNumero; // 5 - 2 = 3
		Debug.Log(numeroImportante); // El número importante ahora vale 3

		numeroImportante *= otroNumero; // 3 * 2 = 6
		Debug.Log(numeroImportante); // El número importante ahora vale 6

		numeroImportante /= otroNumero; // 6 / 2 = 3
		Debug.Log(numeroImportante); // El número importante ahora vale 3

		numeroImportante %= otroNumero; // 3 % 2 = 1
		Debug.Log(numeroImportante); // El número importante ahora vale 1

		// Cuando realicemos las operaciones de esta manera, es importante que los dos símbolos (el de la operación matemática y el igual) vayan pegados

		//numeroImportante * = otroNumero;	// ¡Error! El símbolo de la operación y el igual deben ir pegados
		numeroImportante *= otroNumero;		// Correcto


		// ----- Ahora puedes realizar los EJERCICIOS E de operaciones con variables -----
		

		// -------------------------------------------------- F. OPERACIONES MATEMÁTICAS (sumando 1 y restando 1 a la misma variable) --------------------------------------------------


		// Además de lo anterior, hay un par de operadores más específicos que son los siguientes:
		//		- Operador ++	Le suma 1 a una variable
		//		- Operador --	Le resta 1 a una variable
		// Por ejemplo:

		numeroImportante++; // 1 + 1 = 2
		Debug.Log(numeroImportante); // El número importante ahora vale 2

		numeroImportante--; // 2 - 1 = 1
		Debug.Log(numeroImportante); // El número importante ahora vale 1

		// A modo de comparación, aquí aparecen las tres maneras distintas que existen de sumarle 1 a un número

		numeroImportante = numeroImportante + 1;	// 1 + 1 = 2
		numeroImportante += 1;						// 2 + 1 = 3
		numeroImportante++;							// 3 + 1 = 4

		Debug.Log(numeroImportante); // El número importante ahora vale 4

		// Y aquí aparecen las tres maneras que existen de restarle 1 a un número

		numeroImportante = numeroImportante - 1;	// 4 - 1 = 3
		numeroImportante -= 1;						// 3 - 1 = 2
		numeroImportante--;							// 2 - 1 = 1

		Debug.Log(numeroImportante); // El número importante ahora vale 1

		// Cuando usamos estos operadores, tenemos que tener en cuenta que los dos símbolos deben estar pegados el uno al otro

		//numeroImportante- -;		// ¡Error! Los dos símbolos deben ir pegados
		numeroImportante--;			// Correcto

		// Además, como estos operadores están creados específicamente para sumar o restar 1, no es necesario poner el número detrás

		//numeroImportante++ 1;		// ¡Error! No se pone el 1 detrás de los dos símbolos
		//numeroImportante++= 1;	// ¡Error! No funciona tampoco poniendo un símbolo de igual
		numeroImportante++;			// Correcto


		// ----- Ahora puedes realizar los EJERCICIOS F de operaciones con variables -----
		

		// -------------------------------------------------- G. NÚMEROS NEGATIVOS --------------------------------------------------


		// En todos los ejemplos anteriores hemos usado únicamente números positivos (por simplificar), pero las operaciones matemáticas se pueden realizar también con números negativos
		// Además, si queremos es posible usar el símbolo de menos (-) para invertir el signo de una variable

		int numeroPositivo = 1;
		int numeroNegativo = -1;

		Debug.Log("Mostramos números positivos y negativos");

		Debug.Log(numeroPositivo);	// Esto muestra 1
		Debug.Log(numeroNegativo);	// Esto muestra -1
		Debug.Log(-numeroPositivo);	// Esto muestra -1	Al poner el símbolo - delante del nombre de la variable invertimos su signo: si es positiva, se muestra como negativa
		Debug.Log(-numeroNegativo);	// Esto muestra 1	Al poner el símbolo - delante del nombre de la variable invertimos su signo: si es negativa, se muestra como positiva

		// Al usar el símbolo de menos (-) delante del nombre de una variable, la variable no cambia su signo de forma permanente, solo en ese caso concreto

		Debug.Log(numeroPositivo);	// Esto muestra 1, porque la variable numeroPositivo sigue siendo positiva
		Debug.Log(numeroNegativo);	// Esto muestra -1, porque la variable numeroNegativo sigue siendo negativa
		

		// -------------------------------------------------- H. UNIÓN DE TEXTOS (STRING) --------------------------------------------------


		// Las variables numéricas no son las únicas con las que se pueden utilizar operadores
		// Los textos, por ejemplo, se pueden también "sumar" entre sí, aunque el resultado es diferente del que obtendríamos si sumáramos dos números
		// Eso se debe a que en realidad no estamos sumando textos como tal (porque eso no se puede hacer), sino que simplemente los estamos concatenando (es decir, uniendo)

		string textoA = "4";	// Aquí tenemos un texto A que solo contiene el número 4
		string textoB = "2";	// Aquí tenemos un texto B que solo contiene el número 2

		// Si las dos variables que acabamos de declarar fuesen de tipo int (o float) y las sumásemos, el resultado sería 6 (4 + 2 = 6)
		// Sin embargo, las variables son textos y no números, por lo que al sumarlas no se comportan como números y, por tanto, el resultado es diferente

		string resultadoTexto = textoA + textoB; // 4 + 2 = 42

		Debug.Log("Mostramos los resultados de 'sumar' (es decir, unir o concatenar) dos o más textos");

		Debug.Log(resultadoTexto); // 42

		// Es decir, que al sumar dos textos lo que estamos haciendo en realidad es poner el segundo texto a continuación del primero

		string hola = "Hola";	
		string coma = ",";
		string espacio = " ";
		string mundo = "mundo";

		string holaMundo = hola + coma + espacio + mundo;

		Debug.Log(holaMundo); // Hola, mundo

		// Esto, sin embargo, solo se puede hacer con la suma: los demás operadores no son compatibles con textos

		string error = "El único operador compatible con los textos es el de suma (+)";

		//error = textoA - textoB;		// ¡Error! No se pueden restar textos
		//error = textoA * textoB;		// ¡Error! No se pueden multiplicar textos
		//error = textoA / textoB;		// ¡Error! No se pueden dividir textos (y, en consecuencia, tampoco obtener su módulo)
		//error = -error;				// ¡Error! No se puede "invertir" un texto
		//error++;						// ¡Error! Esto tampoco se puede hacer

		Debug.Log(error);

		holaMundo = "¡" + holaMundo;	// Esto sí que se puede hacer
		holaMundo += "!";				// Y esto también

		Debug.Log(holaMundo); // ¡Hola, mundo!
	}
}
