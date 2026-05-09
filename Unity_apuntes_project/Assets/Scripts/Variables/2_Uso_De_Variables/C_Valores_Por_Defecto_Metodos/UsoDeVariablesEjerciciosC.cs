#pragma warning disable

using UnityEngine;

public class UsoDeVariablesEjerciciosC : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre USO DE VARIABLES (SECCIÓN C) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema

	
	void Ejercicio1()
	{
		// Muestra en consola las variables que aparecen aquí abajo y, en caso de que se produzcan errores al intentar mostrarlas, haz lo que sea necesario para solucionarlos
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		int numeroEntero;
		float numeroReal;
		bool booleano;
		char character;
		string texto;

	}

	void Ejercicio2()
	{
		// Las siguientes líneas de código así escritas dan error, ¿sabrías explicar por qué? (Escribe tu respuesta abajo entre las comillas y a continuación haz que se muestre en la consola de Unity)

		//Debug.Log(booleano);
		//bool booleano = true;
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

	}

	void Ejercicio3()
	{
		// En las siguientes líneas de código, si el primer Debug.Log() provoca un error, ¿por qué el segundo no?
		
		string texto;
		
		//Debug.Log(texto);

		texto = null;

		Debug.Log(texto);

		// Escribe tu respuesta abajo entre las comillas y a continuación haz que se muestre en la consola de Unity
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

	}

	void Ejercicio4()
	{
		// Aquí abajo hay declarada una variable de tipo string, pero todavía no sabemos qué texto vamos a guardar en ella. ¿Qué valor por defecto podríamos darle sin que sea nulo?
		// Dale a la variable el valor que consideres y a continuación muéstrala en la consola de Unity
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string texto;

	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
		Ejercicio4();
	}
}
