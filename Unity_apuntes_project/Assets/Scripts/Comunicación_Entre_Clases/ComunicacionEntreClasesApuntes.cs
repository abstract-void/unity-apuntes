using System;
using UnityEngine;

// En Unity (y en C# en general) suele ser buena idea crear diferentes clases que cumplan distintos propósitos cada una
// Sin embargo, para que un programa funcione de forma correcta es necesario que las distintas clases se puedan comunicar entre ellas
// Existen varias formas en las que una clase (A) se puede comunicar con otra (B):
//		- [Comunicación tipo 1] La clase A obtiene algún dato de la clase B
//		- [Comunicación tipo 2] La clase A modifica algún dato de la clase B
//		- [Comunicación tipo 3] La clase A le dice a la clase B que haga algo y que lo haga justo en ese momento
//		- [Comunicación tipo 4] La clase A le pide a la clase B que haga algo, pero la clase B decide cuándo hacerlo (generalmente cuando se dé alguna circunstancia concreta o se cumpla alguna condición)

public class ComunicacionEntreClasesApuntes : MonoBehaviour // Tenemos esta clase
{
	private Cronometro cronometro; // Y en esta clase tenemos una referencia a la clase Cronómetro

	private void Awake()
	{
		// Creamos un nuevo cronómetro

		cronometro = new Cronometro();

		// Cambiamos el tiempo límite del cronómetro (comunicación tipo 2: la clase A modifica algún dato de la clase B)

		cronometro.TiempoLimite = 0.5f;

		// Le pedimos al cronómetro que muestre un mensaje en consola cuando se den las circunstancias (comunicación tipo 4: la clase A le pide a la clase B que haga algo, pero la clase B decide cuándo hacerlo)

		cronometro.TiempoLimiteAlcanzado += MostrarMensajeEnConsola;
		// Fíjate que aquí no estamos invocando el método de mostrar mensaje, sino que se lo estamos pasando al cronómetro para el cronómetro lo invoque cuando considere
		// Es por eso por lo que no se ponen los paréntesis detrás del nombre del método (cuando lo normal es que sí se pongan)
	}

	private void Update()
	{
		// Le decimos al cronómetro que haga avanzar el contador (comunicación tipo 3: la clase A le dice a la clase B que haga algo y que lo haga justo en ese momento)

		cronometro.AvanzarContador();

		// Guardamos el tiempo actual del cronómetro (comunicación tipo 1: la clase A obtiene algún dato de la clase B)

		float tiempoActual = cronometro.TiempoActual;

		Debug.Log(tiempoActual); // Cuando obtenemos un dato de otra clase, lo normal es que lo usemos en ese momento o más adelante
	}

	private void MostrarMensajeEnConsola()
	{
		Debug.Log("¡El cronómetro ha alcanzado el tiempo límite que le hemos indicado!");
	}
}

public class Cronometro
{
	private bool contadorDetenido = false;

	// Las propiedades como esta de aquí abajo son perfectas cuando queremos que otras clases puedan obtener algún dato que se encuentre dentro de esta clase

	public float TiempoActual { get; private set; }
	
	// Y las propiedades son también perfectas para que otras clases puedan cambiar datos que se encuentren en esta clase

	public float TiempoLimite { get; set; } // En esta propiedad el set no es privado, así que otras clases pueden cambiar su valor

	// Si queremos que otra clase le diga a esta lo que tiene que hacer, pero dejando que sea esta la que decida cuándo hacerlo, entonces lo mejor es crear un evento
	// Los eventos siguen la misma estructura que todo lo demás (se pone primero el tipo y luego el nombre), pero además de eso llevan delante la palabra "event"
	// Aparte, los eventos no pueden ser de cualquier tipo (no pueden ser int, float, string, etc.), sino que hay ciertos tipos que son específicos para ellos (por ejemplo, Action y Func)
	// Estos tipos específicos hacen referencia a métodos, así que sirven precisamente para eso: guardar métodos

	public event Action TiempoLimiteAlcanzado;

	// Cuando queremos que sea otra clase la que nos diga qué tenemos que hacer, pero también cuándo tenemos que hacerlo, lo ideal es crear un método público

	public void AvanzarContador()
	{
		if (contadorDetenido == true)
		{
			return;
		}

		TiempoActual += Time.deltaTime;

		if (TiempoActual > TiempoLimite)
		{
			TiempoActual = TiempoLimite;

			TiempoLimiteAlcanzado(); // Aquí estamos invocando el evento que hemos creado arriba: cuando hay un evento, otras clases deciden qué es lo que debe ocurrir, pero es esta la que decide cuándo va a ocurrir

			contadorDetenido = true;
		}
	}

	// Fíjate que en todos los casos en los que necesitamos que otra clase se comunique de alguna forma con esta tenemos que usar la palabra "public"
}

// Algunos ejemplos adicionales del tipo Action

public class Eventos
{
	public event Action EventoOcurrido; // Action (así a secas) es un tipo de variable que guarda métodos sin argumentos ni valor de retorno

	private void Ejemplo()
	{
		EventoOcurrido += MetodoBasico; // Correcto, este método no tiene argumentos ni valor de retorno, así que es compatible con Action
		//EventoOcurrido += MetodoConValorDeRetorno; // ¡Error! Action bajo ninguna circunstancia es compatible con métodos que tienen valor de retorno
		//EventoOcurrido += MetodoConArgumento; // ¡Error! Action (así a secas) no es compatible con métodos que tienen uno o más argumentos
	}

	private void MetodoBasico()
	{
		Debug.Log("Este método no tiene argumentos ni valor de retorno");
	}

	private int MetodoConValorDeRetorno()
	{
		Debug.Log("Este método tiene valor de retorno");
		return 0;
	}

	private void MetodoConArgumento(int argumento)
	{
		Debug.Log("Este método tiene un argumento");
	}
}