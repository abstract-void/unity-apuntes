#pragma warning disable

using UnityEngine;

public class CreacionDeVariablesEjerciciosB : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre CREACIÓN DE VARIABLES (SECCIÓN B) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema


	void Ejercicio1()
	{
		// ¿Qué dos informaciones tenemos que poner siempre que creamos una variable y en qué orden tenemos que escribirlas? (Escribe tu respuesta entre las comillas)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

		Debug.Log(respuesta);
	}

	void Ejercicio2()
	{
		// A continuación se muestra una lista de tipos de variables. ¿Qué clase de datos podemos guardar en cada uno de ellos? (Escribe tus respuestas abajo entre las comillas)
		//		Tipo 1. string
		//		Tipo 2. float
		//		Tipo 3. bool
		//		Tipo 4. char
		//		Tipo 5. int
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuestaString = "";
		string respuestaFloat = "";
		string respuestaBool = "";
		string respuestaChar = "";
		string respuestaInt = "";

		Debug.Log(respuestaString);
		Debug.Log(respuestaFloat);
		Debug.Log(respuestaBool);
		Debug.Log(respuestaChar);
		Debug.Log(respuestaInt);
	}

	void Ejercicio3()
	{
		// Cambia el tipo de cada una de las siguientes variables por el que creas que mejor encaja con su nombre (si el tipo que mejor encaja es string, deja la variable como está)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string entero;
		string caracter;
		string decimales;
		string texto;
		string apagado;
		string velocidad;
		string simbolo;
		string edad;
		string correcto;
		string nombre;
	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}
}
