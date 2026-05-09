#pragma warning disable

using UnityEngine;

public class UsoDeVariablesEjerciciosE : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre USO DE VARIABLES (SECCIÓN E) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema

	
	void Ejercicio1()
	{
		// A continuación se declaran tres variables:

		float ejemploVelocidad = 6.5f;
		bool ejemploPuedeSaltar = false;
		string ejemploNombreEscena = "Fase 1";

		// Declara nuevas variables y copia los datos de las de aquí arriba en las nuevas que has declarado (cuando las tengas, muestra todas las variables en la consola de Unity)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio2()
	{
		// Aquí abajo se intenta guardar el dato de una variable en otra, pero da error, ¿por qué? (Declara aquí abajo una variable de tipo string, escribe en ella tu respuesta y a continuación muéstrala en Unity)

		int ejemploVidas = 3;
		//bool vidas = ejemploVidas;
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio3()
	{
		// Échale un ojo a las variables que se declaran e inicializan a continuación

		int numeroA = 10;
		int numeroB = 20;
		int numeroE = numeroB;
		int numeroF = numeroA;
		int numeroH = numeroE;

		// Sin consultarlo en la consola de Unity, indica cuáles son los números F y H (declara aquí abajo una variable de tipo string, escribe en ella tu respuesta y a continuación muéstrala en la consola de Unity)
		// Cuando ya tengas tu respuesta escrita (¡solo cuando ya la tengas!), muestra en la consola de Unity los números F y H para compararlos con tu respuesta (si te has equivocado, intenta pensar por qué)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio4()
	{
		// Fíjate en las variables del ejercicio anterior. Si le cambiamos el valor al número B y hacemos que valga 30 en vez de 20, ¿qué valor tendrían las variables E y H?
		// Declara aquí abajo una variable de tipo string, escribe en ella tu respuesta y a continuación muéstrala en la consola de Unity
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio5()
	{
		// Échale un ojo a las variables que se declaran e inicializan a continuación

		int numeroA = 10;
		int numeroB = 20;
		int numeroC = 30;
		int numeroD = 40;
		int numeroE = numeroA;
		int numeroF = numeroC;
		int numeroG = numeroD;
		int numeroH = numeroF;
		int numeroI = numeroB;
		int numeroK = numeroI;
		int numeroL = numeroK;
		int numeroN = numeroH;
		int numeroO = numeroL;

		// Sin consultarlo en la consola de Unity, indica cuáles son los números N y O (declara aquí abajo dos variables de tipo string, escribe en ellas tus respuestas y a continuación muéstralas en la consola de Unity)
		// Cuando ya tengas tu respuesta escrita (¡solo cuando ya la tengas!), muestra en la consola de Unity los números F y H para compararlos con tu respuesta (si te has equivocado, intenta pensar por qué)
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
