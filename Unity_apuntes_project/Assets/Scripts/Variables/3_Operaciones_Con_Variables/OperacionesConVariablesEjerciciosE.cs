#pragma warning disable

using UnityEngine;

public class OperacionesConVariablesEjerciciosE : MonoBehaviour
{
	// -------------------------------------------------- RECOMENDACIONES --------------------------------------------------


	// ----- Antes de empezar, lee los apuntes sobre OPERACIONES CON VARIABLES (SECCIÓN E) -----


	// Una vez que hayas empezado con los ejercicios, intenta avanzar todo lo que puedas sin mirar los apuntes ni usar ninguna herramienta adicional
	// De hecho, si tienes la confianza suficiente, puedes probar a abrir este documento en un bloc de notas y hacer los ejercicios ahí (en vez de usar Visual Studio u otro editor del estilo)
	// Si te ha faltado algo, lo puedes completar mirando los apuntes o recurriendo a las herramientas que necesites, pero intentando siempre entenderlo todo bien (no copies y pegues sin más)
	// Ante cualquier duda, puedes preguntarme sin problema


	void Ejercicio1()
	{
		// Aquí abajo aparecen varias operaciones matemáticas con los números A y B

		int numeroA = 5;
		int numeroB = 4;
		
		numeroA = numeroA + numeroB;
		numeroA = numeroA - numeroB;
		numeroA = numeroA * numeroB;
		numeroA = numeroA / numeroB;
		numeroA = numeroA % numeroB;

		// Realiza las mismas operaciones que arriba, pero de forma más resumida, sin que se repita el nombre de la variable (ve mostrando cada uno de los resultados en Unity)
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio2()
	{
		// Explica brevemente por qué la operación de aquí abajo entre los números A y B da error (escribe tu respuesta en un string y muéstrala en Unity)

		int numeroA = 3;
		int numeroB = 2;

		//numeroA + = numeroB;
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Ejercicio3()
	{
		// Realiza las operaciones necesarias para hacer que el número principal sea 0 al final (usa todas las variables de la siguiente lista sin repetir ninguna)
		int numeroA = 3;
		int numeroB = 6;
		int numeroC = 6;
		int numeroD = 2;
		int numeroE = 6;
		int numeroF = 1;

		// Si tienes dudas, échale un ojo al ejemplo

		int numeroPrincipal = 5;

		// EJEMPLO

		numeroPrincipal %= numeroA; // 2
		numeroPrincipal += numeroE; // 8
		numeroPrincipal += numeroB; // 14
		numeroPrincipal /= numeroD; // 7
		numeroPrincipal -= numeroC; // 1
		numeroPrincipal -= numeroF; // 0

		// Cada operación que realices debe dar un resultado distinto, no puede haber ninguno repetido (ve mostrando en Unity el resultado de cada operación para asegurarte de que no se repita ninguno)
		// Además, no puedes obtener exactamente los mismos resultados y en el mismo orden exacto que en el ejemplo
		
		numeroPrincipal = 5;
		// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	}

	void Awake()
	{
		Ejercicio1();
		Ejercicio2();
		Ejercicio3();
	}
}
