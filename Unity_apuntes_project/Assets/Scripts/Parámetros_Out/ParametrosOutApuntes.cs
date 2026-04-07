using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // Puedes ignorar esta línea, simplemente le añade un rigidbody al objeto en caso de que no lo tenga ya
public class ParametrosOutApuntes : MonoBehaviour
{
    private void Awake()
    {
		// -------------------------------------------------- PARÁMETROS DE ENTRADA --------------------------------------------------


		// Por lo general, cuando un método tiene uno o más argumentos debemos pasarle el valor o los valores que nos pida, porque el método los necesita para ejercer su función
		// Podemos crear variables, asignarles un valor y entonces pasarle esas variables al método o, si lo preferimos, podemos también pasarle directamente el valor
		// En cualquiera de los dos casos, si no le pasamos los valores al método nos daría un error

		Sumar(2, 3); // Correcto

		int primerNumero = 2;
		int segundoNumero = 3;

		Sumar(primerNumero, segundoNumero); // Correcto también

		//Sumar() // ¡Error! El método nos pide dos números enteros y no le estamos pasando ninguno
		//Sumar(4) // ¡Error! El método nos pide dos números enteros y solo le estamos pasando uno
		//Sumar("Esto", "no vale") // ¡Error! El método nos pide dos números enteros y le estamos pasando textos en vez de números
		

		// -------------------------------------------------- VALORES DE RETORNO --------------------------------------------------


		// Hay veces en las que un método, además de (o en lugar de) pedirnos información, lo que hace es dárnosla
		// En la inmensa mayoría de casos eso se hace mediante un valor de retorno, como en este ejemplo:

		int resta = Restar(6, 2);
		Debug.Log(resta); // Mostramos en consola el valor que nos ha devuelto el método
		

		// -------------------------------------------------- PARÁMETROS DE SALIDA --------------------------------------------------


		// Sin embargo, existe otra manera de hacer que un método nos proporcione información, y es usando un parámetro de salida (out)
		// Al invocar un método, los parámetros que llevan la palabra "out" delante funcionan exactamente igual que un valor de retorno
		// Es decir, sirven para el método nos pase información (el "out" indica que la información sale desde dentro del método hacia afuera)
		// Por ejemplo:

		int multiplicacion;
		Multiplicar(2, 4, out multiplicacion);
		Debug.Log(multiplicacion);

		// Una diferencia de los parámetros de salida (o out) respecto a los de entrada (los que no llevan "out") es que con los de salida podemos crear la variable directamente al invocar el método, como aquí abajo:

		Multiplicar(3, 3, out int resultado); // Estamos creado la variable "resultado" a la vez que invocamos el método
		Debug.Log(resultado); // Luego podemos usar esa variable exactamente igual que si la hubiéramos creado aparte

		// Otra diferencia de los parámetros de salida respecto a los de entrada es que a los de entrada debemos darles un valor antes de pasárselos al método, pero a los de salida no, porque el valor se lo da el propio método
		
		Rigidbody rigidBody;
		Vector3 posicion;
		
		//Debug.Log(rigidBody); // ¡Error! No podemos mostrar el rigidbody porque aún no tiene un valor
		//Debug.Log(posicion); // ¡Error! No podemos mostrar la posición porque aún no tiene un valor

		rigidBody = GetComponent<Rigidbody>(); // Le damos un valor al rigidbody
		// No le damos ningún valor a la posición

		ObtenerPosicion(rigidBody, out posicion);

		Debug.Log(rigidBody); // Correcto, porque al rigidbody le hemos dado un valor antes
		Debug.Log(posicion); // Correcto, porque el método le ha dado un valor a la posición (por ser un parámetro de salida)
		

		// -------------------------------------------------- VALORES DE RETORNO + PARÁMETROS DE SALIDA --------------------------------------------------


		// Normalmente NO se usan parámetros de salida cuando queremos recibir información de un método
		// Lo que se suele hacer en su lugar es ponerle al método un valor de retorno
		// Sin embargo, hay casos en los que necesitamos recibir más de una información por parte del método
		// En esos casos el método puede tener valor de retorno y aparte parámetros de salida

		// En este ejemplo de abajo, el método nos proporciona dos valores
		//		- Un booleano que nos indica si se ha podido realizar la operación de dividir
		//		- El resultado de la división (que será 0 si no se ha podido realizar)
		// El booleano lo obtenemos mediante un valor de retorno y el resultado de la división lo obtenemos mediante un parámetro de salida

		bool operacionCorrecta;
		int resultadoDivision;

		operacionCorrecta = IntentarDividir(5, 0, out resultadoDivision);

		if (operacionCorrecta == true)
		{
			Debug.Log("Este mensaje no se va a mostrar, porque no se puede dividir entre 0 y, por tanto, la operación no es correcta");
		}

		operacionCorrecta = IntentarDividir(5, 1, out resultadoDivision);

		if (operacionCorrecta == true)
		{
			Debug.Log(resultadoDivision);
		}
    }

	// Método con dos parámetros de entrada
	private void Sumar(int numeroA, int numeroB)
	{
		int resultado = numeroA + numeroB;
		Debug.Log(resultado);
	}

	// Método con dos parámetros de entrada y valor de retorno
	private int Restar(int numeroA, int numeroB)
	{
		return numeroA - numeroB;
	}

	// Método con dos parámetros de entrada y uno de salida (en la práctica, un parámetro de salida es equivalente a un valor de retorno)
	private void Multiplicar(int numeroA, int numeroB, out int resultado)
	{
		resultado = numeroA * numeroB; // Debemos darle sí o sí un valor al parámetro de salida, en caso contrario nos saldría un error
	}

	// Método con un parámetro de entrada y otro de salida
	private void ObtenerPosicion(Rigidbody rigidbody, out Vector3 posicion)
	{
		posicion = rigidbody.position; // Debemos darle un valor al parámetro de salida
	}

	// Método con dos parámetros de entrada, uno de salida y valor de retorno
	private bool IntentarDividir(int numeroA, int numeroB, out int resultado)
	{
		if (numeroB == 0)
		{
			Debug.Log("¡No se puede dividir entre 0!");

			resultado = 0; // Debemos darle un valor al parámetro de salida en todos los casos y tenemos que hacerlo antes del return
			return false; // Devolvemos "false" porque no hemos podido realizar la operación
		}
		else
		{
			resultado = numeroA / numeroB; // Debemos darle un valor al parámetro de salida en todos los casos y tenemos que hacerlo antes del return
			return true; // Devolvemos "true" porque la división se ha realizado con éxito
		}
	}
}
