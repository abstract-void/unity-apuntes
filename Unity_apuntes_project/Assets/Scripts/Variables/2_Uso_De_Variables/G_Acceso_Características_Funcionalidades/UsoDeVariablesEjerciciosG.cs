#pragma warning disable

using UnityEngine;

public class UsoDeVariablesEjerciciosG : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre USO DE VARIABLES (SECCIÓN G) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema

	
	void Ejercicio1()
	{
		// Si quisiéramos acceder a una característica o funcionalidad de una determinada variable, ¿qué signo de puntuación tendríamos que usar y donde lo colocaríamos?
		// Escribe tu respuesta en una variable de tipo string y, cuando la tengas, muéstrala en Unity
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio2()
	{
		// Échale un ojo a las siguientes líneas de código
		
		float numeroReal;
		string texto;
		
		numeroReal = 5.5f;

		//texto = numeroReal;
		texto = numeroReal.ToString();

		// Las dos últimas líneas de este código son parecidas, pero una da error y la otra no. ¿Sabrías explicar por qué? (Escribe tu respuesta en una variable de tipo string y, cuando la tengas, muéstrala en Unity)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio3()
	{
		// Si declaramos dos variables de tipos distintos e intentamos acceder a las características y funcionalidades de cada una, ¿esas características y funcionalidades serán exactamente las mismas en ambos casos?
		// Escribe tu respuesta en una variable de tipo string y, cuando la tengas, muéstrala en Unity
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}
}
