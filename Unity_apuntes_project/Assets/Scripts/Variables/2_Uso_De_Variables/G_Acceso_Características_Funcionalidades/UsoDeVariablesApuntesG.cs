using UnityEngine;

public class UsoDeVariablesApuntesG : MonoBehaviour
{
	// -------------------------------------------------- G. ACCESO A PROPIEDADES Y FUNCIONES --------------------------------------------------


	void Awake()
	{
		// En todas las variables es posible acceder a una serie de características y funcionalidades
		// Para ello basta simplemente con poner un punto detrás de su nombre

		// Una funcionalidad bastante común, por ejemplo, sería la de convertir una variable cualquiera en texto

		int numero;			// Declaramos una variable de tipo int (número entero)
		string texto;		// Declaramos una variable de tipo string (texto)

		numero = 10;		// Inicializamos la variable de tipo int con un valor cualquiera
		//texto = numero;	// Intentamos copiar ese número en una variable de tipo string, pero nos da error porque los tipos de las variables son distintos

		// Ahora vamos a hacer exactamente lo mismo, pero usando ToString()
		// Para poder usar ToString(), tenemos que poner un punto detrás del nombre de la variable y a continuación ToString()
		// En este caso, como lo que queremos convertir en texto es la variable de tipo int, el ToString() lo tenemos que poner detrás del nombre de esa variable, como aquí abajo

		texto = numero.ToString(); // Correcto

		// Al hacer esto, lo que estamos haciendo es copiar un número entero en una variable de tipo string, algo que por lo general no sería correcto
		// Sin embargo, al usar el ToString() no estamos simplemente copiando el valor sin más, sino que en el proceso estamos convirtiendo esa copia en un texto
		// Es por eso por lo que al usar ToString() sí que es posible y correcto copiar un número en una variable de tipo string

		Debug.Log("Mostramos un número entero y a continuación ese mismo número convertido en texto");
		Debug.Log(numero);	// Esto muestra el número 10 (int)
		Debug.Log(texto);	// Esto también muestra el número 10, solo que en este caso no es un número, sino un texto (string)

		// ToString() es solo una de las muchas características y funcionalidades a las que podemos acceder en una variable
		// El caso de ToString(), además, es algo particular, ya que es posible acceder a él desde cualquier variable, sin importar su tipo
		// Sin embargo, la mayoría de características y funcionalidades son exclusivas de ciertos tipos (con los números se pueden hacer unas cosas, con los textos otras, etc.)
		// En general, no es necesario saberse de memoria absolutamente todo lo que se puede hacer cada tipo de variable, pero sí tener presente que esas opciones están ahí y poco a poco ir aprendiendo las más importantes


		// ----- Ahora puedes realizar los EJERCICIOS G de uso de variables -----
	}
}
