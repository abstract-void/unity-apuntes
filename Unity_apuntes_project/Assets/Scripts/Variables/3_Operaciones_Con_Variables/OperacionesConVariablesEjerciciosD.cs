#pragma warning disable

using UnityEngine;

public class OperacionesConVariablesEjerciciosD : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre OPERACIONES CON VARIABLES (SECCIÓN D) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema


	void Ejercicio1()
	{
		// Aquí abajo hay dos variables declaradas e inicializadas con las que se está realizando una operación de suma

		int numeroA = 4;
		int numeroB = 3;
		
		numeroA = numeroA + numeroB;
		Debug.Log(numeroA);

		// Sin consultarlo en la consola de Unity, indica qué pasaría si hiciésemos de nuevo la misma suma de arriba. ¿Obtendríamos el mismo resultado? ¿Por qué? (Escribe tu respuesta en un string y muéstrala en Unity)
		// Cuando ya tengas tu respuesta (¡solo cuando ya la tengas!), haz la suma y muéstrala en Unity para comparar el resultado con tu respuesta (si te has equivocado, intenta pensar por qué)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio2()
	{
		// Realiza las operaciones necesarias para obtener los resultados que se indican abajo (usa todas las variables de la siguiente lista sin repetir ninguna)
		int numeroA = 2;
		int numeroB = 5;
		int numeroC = 3;
		int numeroD = 4;
		int numeroE = 2;

		// Si tienes dudas, échale un ojo al ejemplo

		int numeroPrincipal = 5;

		// EJEMPLO

		// Operación 1: el número principal debe valer 7 (muéstralo en Unity)
		numeroPrincipal = numeroPrincipal + numeroE;
		Debug.Log(numeroPrincipal);

		// Operación 2: el número principal debe valer 21 (muéstralo en Unity)
		numeroPrincipal = numeroPrincipal * numeroC;
		Debug.Log(numeroPrincipal);
		
		// Operación 3: el número principal debe valer 16 (muéstralo en Unity)
		numeroPrincipal = numeroPrincipal - numeroB;
		Debug.Log(numeroPrincipal);
		
		// Operación 4: el número principal debe valer 4 (muéstralo en Unity)
		numeroPrincipal = numeroPrincipal / numeroD;
		Debug.Log(numeroPrincipal);

		// Operación 5: el número principal debe valer 8 (muéstralo en Unity)
		numeroPrincipal = numeroPrincipal * numeroA;
		Debug.Log(numeroPrincipal);
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Operación 1: el número principal debe valer 9 (muéstralo en Unity)

		// Operación 2: el número principal debe valer 18 (muéstralo en Unity)
		
		// Operación 3: el número principal debe valer 6 (muéstralo en Unity)
		
		// Operación 4: el número principal debe valer 11 (muéstralo en Unity)

		// Operación 5: el número principal debe valer 1 (muéstralo en Unity)

	}

	void Ejercicio3()
	{
		// Realiza las operaciones que se piden a continuación
		// Con cada una debes decidir si guardas el resultado en la misma variable o en otra distinta (ve mostrando en Unity los resultados de todas las operaciones)

		int vidas = 3;				// El personaje pierde 1 vida al ser atacado por un enemigo						// La cantidad de vidas que había antes ya no nos interesa
		int puntuacion = 314;		// La persona que está jugando gana 20 puntos al realizar alguna acción			// La puntuación que había antes ya no nos interesa
		float probabilidad = 100;	// La probabilidad de obtener un power-up se divide entre la cantidad de vidas	// La probabilidad todavía nos interesa, porque la seguiremos usando
		float tiempoRestante = 20;	// Al tiempo que queda para que termine la partida se le suman 10 segundos		// El tiempo que había antes ya no nos interesa
		//							// La puntuacion que está aquí arriba se multiplica por el tiempo restante		// La puntuación que había antes ya no nos interesa
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}
}
