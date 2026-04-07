using System.Collections;
using UnityEngine;

public class CorrutinasApuntes : MonoBehaviour
{
	private float tiempoLimite = 1f;
	private float contador = 0f;

    private void Start()
    {
		EjecutarMetodo();
		EjecutarMetodo();

        StartCoroutine(EjecutarCorrutina());
    }

	private void EjecutarMetodo()
	{
		Debug.Log("[MÉTODO] Este mensaje aparecerá cada vez que se ejecute este método");

		return;// Un return en un método normal hace que el método deje de ejecutarse en ese punto, pero la siguiente vez que se ejecuta lo hace desde el principio, no desde el return

		Debug.Log("[MÉTODO] Este mensaje no se va a mostrar nunca en consola porque hay un return justo antes y los métodos normales no retoman la ejecución desde el último return, sino que empiezan siempre desde el principio");
	}

    private void Update()
    {
		contador += Time.deltaTime;
		
		Debug.Log("[MÉTODO UPDATE] Este mensaje va a seguir mostrándose incluso cuando el contador llegue al tiempo límite");

		if (contador > tiempoLimite)
		{
			Debug.Log("[MÉTODO UPDATE] Este mensaje también se va a repetir, porque un método normal (no corrutina) se ejecuta siempre desde el principio y el Update es un método normal y corriente");
		}

		return; // Lo que hay después del return no va a ocurrir nunca

		//yield return new WaitForSeconds(tiempoLimite);

		Debug.Log("[MÉTODO UPDATE] En un método normal no puede usarse el yield antes de un return");


		// ¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡ ZONA PELIGROSA !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


		bool ejecutarCodigo = true;

		while(ejecutarCodigo == true)
		{
			Debug.Log("[MÉTODO UPDATE] ¡CUIDADO! ESTO ES UN BUCLE INFINITO Y HACE QUE EL PROGRAMA CRASHEE");

			// En ningún momento cambiamos el valor de la variable ejecutarCodigo, así que siempre va a ser verdadera
			// Por tanto, no salimos nunca del bucle while porque la condición siempre se cumple, lo que provoca que el programa se quede congelado
		}
    }

// Uno de los significados de la palabra "yield" en inglés es devolver o ceder el control
// Una corrutina se ejecuta hasta que llega a un yield
// Al llegar a un yield, la corrutina le "devuelve el control" al programa para que siga ejecutándose (es decir, que la corrutina se queda como en segundo plano mientras el programa hace sus cosas)

	private IEnumerator EjecutarCorrutina()
	{
        Debug.Log("[CORRUTINA] La corrutina deja de ejecutarse cada vez que llega a un yield, pero la siguiente vez no empieza desde el principio, sino que retoma desde después del yield");

		yield return new WaitForSeconds(tiempoLimite);

		Debug.Log("[CORRUTINA] Una vez que se ha cumplido el yield, la corrutina retoma la ejecución desde ese punto (no empieza desde el principio, como sí hacen los métodos normales)");

		yield return new WaitForSeconds(tiempoLimite);

		Debug.Log("[CORRUTINA] En una corrutina no hay peligro con los bucles infinitos, SIEMPRE Y CUANDO DENTRO HAYA AL MENOS UN YIELD");

		bool ejecutarCodigo = true;

		while(ejecutarCodigo == true)
		{
			Debug.Log("[CORRUTINA] Un bucle infinito dentro de una corrutina (con un 'yield return null' dentro del bucle) funciona igual que el método Update de Unity");

			// Poner un yield que devuelve null es como poner una espera de 0 segundos
			// Sin embargo, aunque parezca que no tiene sentido poner una espera de 0 segundos, ES NECESARIO QUE HAYA UN YIELD PARA EVITAR QUE EL PROGRAMA CRASHEE
			yield return null;

			Debug.Log("[CORRUTINA] Todo lo que hay dentro de un bucle en una corrutina va a ocurrir sin importar si está antes o después de un 'yield return', porque la corrutina continúa siempre a partir del último yield");
		}
	}
}
