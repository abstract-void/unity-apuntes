#pragma warning disable

using UnityEngine;

public class UsoDeVariablesEjerciciosD : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre USO DE VARIABLES (SECCIÓN D) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema


	void Ejercicio1()
	{
		// ¿Qué nombre reciben las variables que se declaran directamente en la clase, fuera de los métodos? (Escribe tu respuesta abajo entre las comillas y a continuación haz que se muestre en la consola de Unity)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

	}

	// Las siguientes variables son correctas y funcionan sin problema, pero normalmente no se pondrían aquí. Muévelas a donde creas que deberían estar y a continuación responde a la pregunta del ejercicio 2

	int numeroEnteroClase;
	float numeroRealClase;
	string textoClase;
	bool booleanoClase;

	void Ejercicio2()
	{
		// Si en una clase tenemos variables y métodos, ¿cuáles deberían colocarse primero y cuáles después? (Escribe tu respuesta abajo entre las comillas y a continuación haz que se muestre en la consola de Unity)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

	}

	void Ejercicio3()
	{
		// Si mostráramos en consola las variables que están declaradas más arriba en la clase y a continuación estas de aquí abajo, ¿habría alguna diferencia entre unas y otras?

		int numeroEnteroMetodo = 0;
		float numeroRealMetodo = 0.0f;
		string textoMetodo = null;
		bool booleanoMetodo = true;

		// Escribe tu respuesta abajo entre las comillas y a continuación haz que se muestre en la consola de Unity
		// Cuando ya tengas tu respuesta escrita (¡solo cuando ya la tengas!), muestra en la consola de Unity las ocho variables para comparar (si te has equivocado, intenta pensar por qué)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

	}

	void Ejercicio4()
	{
		// Intenta hacer aquí que se muestren en la consola de Unity las mismas variables que has mostrado en el ejercicio 3
		// Al hacerlo, verás que unas dan error y otras no. Sin embargo, en el anterior ejercicio ninguna daba error. ¿Sabrías explicar por qué?
		// Escribe tu respuesta abajo entre las comillas y a continuación haz que se muestre en la consola de Unity
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
		Ejercicio4();
	}
}
