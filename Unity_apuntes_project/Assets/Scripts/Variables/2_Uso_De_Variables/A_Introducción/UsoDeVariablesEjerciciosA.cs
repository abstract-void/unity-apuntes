#pragma warning disable

using UnityEngine;

public class UsoDeVariablesEjerciciosA : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre USO DE VARIABLES (SECCIÓN A) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema

	
	string ejemploEjercicio = "Ejercicio 1";

	//Debug.Log(ejemploEjercicio);

	void Ejercicio1()
	{
		// En las líneas de arriba hemos declarado e inicializado una variable y a continuación la hemos intentado mostrar en Unity usando Debug.Log(), pero da error, ¿por qué?
		// Escribe tu respuesta abajo entre las comillas y a continuación haz que se muestre en la consola de Unity
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

	}
	
	void Ejercicio2()
	{
		// Cuando ponemos una variable entre los paréntesis del Debug.Log(), ¿qué se muestra en Unity: el nombre de la variable o el dato que hemos guardado en ella?
		// Escribe tu respuesta abajo entre las comillas y a continuación haz que se muestre en la consola de Unity
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

	}

	void Ejercicio3()
	{
		// A continuación, declaramos una variable e intentamos mostrarla en la consola de Unity, pero nos da error, ¿por qué?

		int entero = 4;
		//Debug.Log(int entero);

		// Escribe tu respuesta abajo entre las comillas y a continuación haz que se muestre en la consola de Unity
		// Cuando tengas tu respuesta, muestra también la variable de arriba, pero sin que dé error
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

	}

	void Ejercicio4()
	{
		// Inventa un personaje (o elige uno que ya exista) y declara cuatro variables que contengan los siguientes datos acerca del personaje:
		//		- Su nombre
		//		- Su edad
		//		- Su altura (en metros)
		//		- Si el personaje es inventado o no

		// A continuación, haz que todos esos datos se muestren en la consola de Unity
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio5()
	{
		// Imagina que vamos a usar al personaje del ejercicio anterior en un videojuego y que necesitamos los siguientes datos:
		//		- Su velocidad
		//		- Sus vidas totales
		//		- Si puede saltar o no
		//		- El tiempo máximo para completar el nivel (en segundos)
		//		- El nombre del siguiente nivel
		//		- La cantidad de monedas que ha encontrado el personaje

		// Guarda cada uno de los datos anteriores en una variable y a continuación muestra todas las variables en la consola de Unity
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
		Ejercicio4();
		Ejercicio5();
	}
}
