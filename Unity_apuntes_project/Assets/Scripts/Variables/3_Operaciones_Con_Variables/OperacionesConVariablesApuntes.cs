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
		

		// -------------------------------------------------- C. OPERACIONES MATEMÁTICAS (guardando el resultado en una nueva variable) --------------------------------------------------


		// Otra cosa que también podemos hacer es guardar en una variable el resultado de la operación y entonces utilizar esa variable donde queramos
		// Algo que debemos tener en cuenta es que, cuando guardamos el resultado de una operación matemática en una variable, la manera de escribir esa línea de código es opuesta a cómo lo haríamos en el mundo real
		// Es decir, que, mientras que en el mundo real haríamos algo como esto: 1 + 1 = 2, al programar lo haríamos justo a la inversa: 2 = 1 + 1

		int resultado;

		//numeroA + numeroB = resultado;	// ¡Error! En el mundo real pondríamos la operación de esta manera, pero al escribir código esto es incorrecto y da error
		resultado = numeroA + numeroB;		// Correcto

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
		

		// -------------------------------------------------- D. OPERACIONES MATEMÁTICAS (guardando el resultado en la misma variable) --------------------------------------------------


		// Cuando obtenemos el resultado de una operación matemática, no siempre vamos a querer crear una variable nueva para guardar ese dato
		// Hay ocasiones en las que nos interesa que, al realizar una operación con una determinada variable, el resultado final se guarde en esa misma variable
		// Eso se puede conseguir de dos (o más) maneras diferentes

		int numeroImportante = 3;
		int otroNumero = 2;

		Debug.Log("Mostramos la misma variable después de ir realizando diversas operaciones con ella y guardando todos los resultados en la propia variable");

		Debug.Log(numeroImportante); // El número importante vale 3

		// La primera forma de guardar el resultado de una operación en la propia variable es la misma que usaríamos si creáramos una variable nueva

		numeroImportante = numeroImportante + otroNumero; // Sumamos dos variables y a la vez guardamos el resultado en una de las dos variables que estamos sumando

		Debug.Log(numeroImportante); // El número importante ahora vale 5 (3 + 2)

		// Hay una segunda manera más resumida de hacer eso mismo
		// Cuando guardamos el resultado de una suma en la misma variable que estamos sumando, podemos evitar repetir el nombre de esa variable si ponemos el símbolo + antes del igual, como aquí abajo

		numeroImportante += otroNumero; // Aquí estamos realizando la misma operación que arriba (numeroImportante = numeroImportante + otroNumero), solo que escrita de un modo más resumido

		Debug.Log(numeroImportante); // El número importante ahora vale 7 (5 + 2)

		// Esto mismo que hemos hecho con la suma se puede aplicar a cualquiera de las otras operaciones matemáticas básicas (resta, multiplicación, división y módulo)

		// RESTA

		numeroImportante = numeroImportante - otroNumero; // 7 - 2 = 5

		Debug.Log(numeroImportante); // El número importante ahora vale 5

		numeroImportante -= otroNumero; // 5 - 2 = 3

		Debug.Log(numeroImportante); // El número importante ahora vale 3

		// MULTIPLICACIÓN

		numeroImportante = numeroImportante * otroNumero; // 3 * 2 = 6

		Debug.Log(numeroImportante); // El número importante ahora vale 6

		numeroImportante *= otroNumero; // 6 * 2 = 12

		Debug.Log(numeroImportante); // El número importante ahora vale 12

		// DIVISIÓN

		numeroImportante = numeroImportante / otroNumero; // 12 / 2 = 6

		Debug.Log(numeroImportante); // El número importante ahora vale 6

		numeroImportante /= otroNumero; // 6 / 2 = 3

		Debug.Log(numeroImportante); // El número importante ahora vale 3

		// MÓDULO

		numeroImportante = numeroImportante % otroNumero; // 3 % 2 = 1

		Debug.Log(numeroImportante); // El número importante ahora vale 1

		numeroImportante %= otroNumero; // 1 % 2 = 1

		Debug.Log(numeroImportante); // El número importante ahora vale 1

		// Además de lo anterior, hay un par de operadores especiales que son bastantes más específicos, pero que nos permiten resumir aún más ciertas sumas y restas: ++ y --
		//		- Operador ++	Le suma 1 a la variable en la que lo usemos
		//		- Operador --	Le resta 1 a la variable en la que lo usemos

		numeroImportante++; // Esto es exactamente lo mismo que escribir esto otro: numeroImportante = numeroImportante + 1;	// Es decir, que le estamos sumando 1 al número importante

		Debug.Log(numeroImportante); // El número importante ahora vale 2 (1 + 1)

		numeroImportante--; // Esto es exactamente lo mismo que escribir esto otro: numeroImportante = numeroImportante - 1;	// Es decir, que le estamos restando 1 al número importante

		Debug.Log(numeroImportante); // El número importante ahora vale 1 (2 - 1)

		// Siempre que queramos sumarle (o restarle) 1 a un número, esta manera que acabamos de ver con los operadores ++ y -- es la forma más breve de hacerlo
		

		// -------------------------------------------------- E. OPERACIONES MATEMÁTICAS (encadenando operaciones) --------------------------------------------------


		// Todas las operaciones que hemos realizado hasta ahora han sido simples: un número, otro número y un resultado, pero nada nos impide encadenar tantas operaciones como queramos
		// Eso sí, al encadenar operaciones tenemos que tener en cuenta que aquí se aplican las mismas normas de precedencia o prioridad que en las matemáticas
		// Por tanto, las multiplicaciones y divisiones (incluyendo el módulo) ocurren antes que las sumas y restas, y las operaciones entre paréntesis van antes que las demás

		Debug.Log("Mostramos los resultados de encadenar varias operaciones");

		// Vamos a reutilizar algunas de las variables que hemos ido declarando a lo largo de esta explicación
		// Por ejemplo, numeroA (que vale 4) y numeroB (que vale 2)

		resultado = numeroA + (numeroA - numeroB) * numeroA / numeroA % numeroB;	// 4 + (4 - 2) * 4 / 4 % 2	-> Primero se resuelve la operación entre paréntesis
																					// 4 + 2 * 4 / 4 % 2		-> A continuación se realizan la multiplicación, la división y el módulo (de izquierda a derecha)
																					// 4 + 8 / 4 % 2			-> Es decir, que en este caso primero se multiplica (porque la multiplicación está más a la izquierda)
																					// 4 + 2 % 2				-> Entonces se divide (porque la división es la que ahora está más la izquierda)
																					// 4 + 0					-> Y después se calcula el módulo (porque tiene la misma prioridad que la multiplicación y la división)
		Debug.Log(resultado);														// = 4						-> Por último, se resuelven las sumas y las restas (también de izquierda a derecha)

		// Al encadenar operaciones podemos usar también la forma resumida de hacerlo: +=, -=, *=, /= o %=
		// Sin embargo, debemos tener en cuenta dos cosas:
		//		- Eso podemos hacerlo única y exclusivamente en la primera de las operaciones
		//		- Al usar uno de esos operadores, todo lo que va detrás del símbolo de igual tiene prioridad (es decir, que es como si todo lo que va detrás del signo de igual estuviera entre paréntesis)

		resultado *= numeroB - (numeroA - numeroB) + numeroB % numeroA / numeroB;	// 4 * (2 - (4 - 2) + 2 % 4 / 2)	-> Paréntesis:	4 - 2 = 2
																					// 4 * (2 - 2 + 2 % 4 / 2)			-> Módulo:		2 % 4 = 2
																					// 4 * (2 - 2 + 2 / 2)				-> División:	2 / 2 = 1
																					// 4 * (2 - 2 + 1)					-> Resta:		2 - 2 = 0
																					// 4 * (0 + 1)						-> Suma:		0 + 1 = 1
																					// 4 * 1							-> Multiplic.:	4 * 1 = 4
		Debug.Log(resultado);														// = 4

		// En la operación anterior hemos dejado la primera multiplicación para el final
		// Eso es porque, cuando usamos uno de estos operadores: +=, -=, *=, /=, %=, todo lo que va detrás del símbolo de igual tiene prioridad
		

		// -------------------------------------------------- F. NÚMEROS NEGATIVOS --------------------------------------------------


		// Por simplificar, en los ejemplos de arriba hemos usado números positivos todo el tiempo, pero las operaciones matemáticas se pueden realizar también con números negativos
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
		

		// -------------------------------------------------- G. UNIÓN DE TEXTOS (STRING) --------------------------------------------------


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
