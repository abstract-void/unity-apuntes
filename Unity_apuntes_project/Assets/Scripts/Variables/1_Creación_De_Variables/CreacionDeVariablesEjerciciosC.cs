#pragma warning disable

using UnityEngine;

public class CreacionDeVariablesEjerciciosC : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------

	// Haz los ejercicios en orden
	// Intenta siempre hacer primero todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si te ves con la confianza suficiente, abre este documento en un bloc de notas e intenta hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si al acabar te ha quedado algún ejercicio por hacer o por completar, échale un ojo a los apuntes (aquí abajo se indica a qué apuntes y a qué sección corresponden estos ejercicios)
	// Si aun así sigues con alguna duda o tienes problemas con algún ejercicio concreto, recurre a las herramientas que necesites (o pregúntame), procurando siempre entenderlo todo bien


	// ----- Si tienes dudas, puedes consultar los apuntes sobre CREACIÓN DE VARIABLES (SECCIÓN C) -----


	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}

	void Ejercicio1()
	{
		// Imagina que tenemos las siguientes variables creadas tal cual se muestran aquí. ¿Qué problema crees que puede haber con ellas? (Escribe tu respuesta abajo entre las comillas)
		// int numero;
		// float numero;
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string respuesta = "";

		Debug.Log(respuesta);
	}

	void Ejercicio2()
	{
		// Todos los nombres de variables que aparecen entrecomillados aquí abajo provocarían errores si se usaran tal cual están ahí. Cámbialos para que sean correctos
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		string nombre1 =  "numero entero";
		string nombre2 =  "Puede'volar";
		string nombre3 =  "esCorrecto?";
		string nombre4 =  "1Up";
		string nombre5 =  "numero-decimal";
		string nombre6 =  "bienHecho=)";
		string nombre7 =  "_totalPower-Ups";
		string nombre8 =  "un,Dos,Tres";
		string nombre9 =  "Nombre Jugador";
		string nombre10 = "enemigo#1";
		string nombre11 = "2letras";
		string nombre12 = "_esta-saltando";
		string nombre13 = "jugador 2";
		string nombre14 = "pulsarTecla/Boton";
		string nombre15 = "¡hasGanado!";

		Debug.Log(nombre1);
		Debug.Log(nombre2);
		Debug.Log(nombre3);
		Debug.Log(nombre4);
		Debug.Log(nombre5);
		Debug.Log(nombre6);
		Debug.Log(nombre7);
		Debug.Log(nombre8);
		Debug.Log(nombre9);
		Debug.Log(nombre10);
		Debug.Log(nombre11);
		Debug.Log(nombre12);
		Debug.Log(nombre13);
		Debug.Log(nombre14);
		Debug.Log(nombre15);
	}

	void Ejercicio3()
	{
		// Identifica cuáles de las siguientes variables tienen nombres 100% correctos (que siguen todas las recomendaciones) y cuáles se pueden mejorar
		// Al final de cada línea, escribe una letra C de 'Correcto' o una M de 'Mejorable'
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		float _Velocidad;			//
		char  _tecla;				//
		int Numerovidas;			//
		bool algo;					//
		float numeroPi;				//
		string _NombrePersonaje;	//
		bool esta_encendido;		//
		char letraJugador1;			//
		float NumeroReal;			//
		int cosa;					//
		string ID;					//
		bool si;					//
		int total_Intentos;			//
		float _contadorTiempo;		//
		string tituloJuego;			//

		// Las variables que tengan nombres mejorables decláralas de nuevo aquí abajo usando nombres que sí que sean del todo correctos (si en algún caso no sabes qué nombre poner, invéntate uno que pudiera tener sentido)

		// ...
	}
}
