using UnityEngine;

// Cuando creamos una clase, normalmente esa clase funciona más o menos como una plantilla o un molde
// Eso significa que la clase en sí no es un objeto concreto, sino simplemente una idea (o un modelo) donde podemos poner las propiedades y funciones que queramos
// Pero luego, partiendo de ese molde o esa idea, podemos crear tantos objetos como queramos, cada uno distinto de los demás
// Por ejemplo, imagina que creamos una clase con un método que permite moverse en una determinada dirección
// Si creamos dos objetos diferentes partiendo de esa clase, ambos objetos tendrán la función de moverse en una dirección (porque son del mismo tipo), pero la dirección no tendrá por qué ser necesariamente la misma para los dos

// Pues, cuando usamos la palabra "static", ocurre exactamente lo contrario
// Es decir, que, si creamos una clase que tiene un número y ese número lo hacemos "static", el número va a ser exactamente el mismo para todos los objetos
// Y, si en algún momento cambiamos el valor de ese número, el número cambiará para absolutamente todos los objetos (ese número no es especfico de cada objeto individual)

// Por poner un ejemplo del mundo real, imagina que tú tienes un coche propio, pero aparte trabajas para una compañía en la que hay un coche de empresa compartido por todas las personas que trabajan en ella
// Si tú un día manchas el asiento de tu coche (el tuyo, no el de empresa), eso no va a afectar para nada a los coches personales de la gente que trabaja contigo, porque cada cual tiene el suyo propio
// Sin embargo, si un día vuelcas un vaso de café en el asiento del coche de empresa (y no lo limpias), ese asiento va a seguir manchado para todo el mundo que trabaje en esa empresa, porque el coche es compartido
// Pues en este ejemplo concreto los coches individuales de cada persona no serían "static", pero el coche de empresa sí

// Volviendo a la programación, la palabra "static" la podemos usar con clases, variables, propiedades, métodos...
// Simplemente basta con ponerla delante del tipo (static int, static void, static class, etc.)
// Eso sí, mientras que una clase NO estática puede contener todo tipo de variables, propiedades y métodos (tanto estáticos como no estáticos), en una clase estática absolutamente todo debe ser estático también

// Clase NO estática (puede contener variables, propiedades, métodos, etc. estáticos y no estáticos)
public class Objeto
{
	private Vector3 posicion; // Variable NO estática

	private static Vector3 tamaño; // Variable estática

	// Métodos NO estáticos

	public Vector3 ObtenerPosicion()
	{
		return posicion;
	}

	public void CambiarPosicion(Vector3 nuevaPosicion)
	{
		posicion = nuevaPosicion;
	}

	public Vector3 ObtenerTamaño()
	{
		return tamaño;
	}
	
	// Método estático

	public static void CambiarTamaño(Vector3 nuevoTamaño)
	{
		tamaño = nuevoTamaño;
	}
}

public class StaticApuntes : MonoBehaviour
{
	// Declaramos tres variables de tipo Objeto (la clase que hemos creado aquí arriba)
	// Cada una de estas variables hace referencia a un objeto que tiene todo lo que hemos puesto en la clase Objeto (porque usan el mismo "molde"), pero cada uno es diferente de los demás
	// El objetoA es distinto del objetoB, el objetoB es distinto del objetoC y el objetoC es distinto del objetoA

	private Objeto objetoA;
	private Objeto objetoB;
	private Objeto objetoC;

	private void Awake()
	{
		// Como la clase Objeto no es MonoBehaviour, no es un componente que podamos añadir a un objeto de una escena de Unity
		// Por tanto, en este caso no podemos usar el GetComponent para darles un valor a estas variables, sino que tenemos que crear los objetos directamente usando la palabra "new"

		objetoA = new Objeto();
		objetoB = new Objeto();
		objetoC = new Objeto();

		// Creamos también tres variables distintas de tipo Vector3 que usaremos con los objetos

		Vector3 vectorA = new Vector3(1f, 1f, 1f); // x = 1, y = 1, z = 1
		Vector3 vectorB = new Vector3(2f, 2f, 2f); // x = 2, y = 2, z = 2
		Vector3 vectorC = new Vector3(3f, 3f, 3f); // x = 3, y = 3, z = 3

		// Vamos a cambiar la posición de cada uno de los objetos usando un método NO estático
		// La posición de los objetos NO es estática, por lo que es diferente para cada uno y, aunque la cambiemos en uno de ellos, la de los demás se mantiene igual que estaba
		// Mostramos las posiciones en la consola de Unity después de cada cambio para que se vea la diferencia (para no repetir código, las mostramos usando un método que está creado más abajo)

		MostrarPosicionObjetos("Posiciones originales de los objetos:");

		objetoA.CambiarPosicion(vectorA);
		MostrarPosicionObjetos("Cambiamos la posición del primer objeto usando un método NO estático:");

		objetoB.CambiarPosicion(vectorB);
		MostrarPosicionObjetos("Cambiamos la posición del segundo objeto usando un método NO estático:");

		objetoC.CambiarPosicion(vectorC);
		MostrarPosicionObjetos("Cambiamos la posición del tercer objeto usando un método NO estático:");

		// Ahora vamos a cambiar el tamaño de los objetos usando un método estático
		// Al ser estático, ese método no pertenece a cada uno de los objetos de forma individual, sino a la clase Objeto en general
		// Es decir, que si intentamos invocar el método usando las variables que hemos creado antes nos da error

		//objetoA.CambiarTamaño(vectorA); // ¡Error! No podemos invocar este método estático usando las variables que hemos creado arriba

		// La forma correcta de invocar un método estático es poner directamente el tipo de la clase (en este caso, Objeto)
		
		MostrarTamañoObjetos("Tamaños originales de los objetos:");

		Objeto.CambiarTamaño(vectorA); // Correcto
		MostrarTamañoObjetos("Cambiamos el tamaño usando un método estático:");

		Objeto.CambiarTamaño(vectorB);
		MostrarTamañoObjetos("Cambiamos el tamaño usando un método estático:");

		Objeto.CambiarTamaño(vectorC);
		MostrarTamañoObjetos("Cambiamos el tamaño usando un método estático:");

		// La variable que guarda el tamaño de los objetos es estática, así que cuando cambiamos el tamaño no cambia solo para un solo objeto, sino para todos a la vez
		// En la inmensa mayoría de los casos esto no es lo que queremos que ocurra: lo que queremos es que cada objeto tenga su propio tamaño
		// Además, cuando se produce un cambio en una variable estática es mucho más complicado saber dónde se ha producido ese cambio, porque cualquier objeto puede haberla modificado
		// Eso, además de aumentar el riesgo de que se produzcan resultados inesperados y el programa no funcione como debe, hace también que sea mucho más difícil testearlo todo
		// Por tanto, la mayoría de las veces es mejor no usar la palabra "static"

		// ¿Cuándo puede venir bien usar el "static" entonces? Cuando lo que estamos haciendo no depende de un objeto en particular, sino que es algo universal
		// Por ejemplo, las matemáticas: si sumamos 2 + 3, el resultado va a ser siempre 5 sin importar qué objeto usemos para hacer la suma
		// En tal caso, podríamos tener una clase estática Matematicas con varios métodos estáticos que realicen distintas operaciones matemáticas: sumar, restar, multiplicar, dividir...
		// La clase Matematicas, al ser estática, es única, por lo que no se pueden crear diferentes matemáticas con distintos valores cada una: simplemente hay una que es universal

		// Matematicas matematicas = new Matematicas(); // ¡Error! La clase Matematicas es estática, por lo que se entiende que solo existe una y nada más que una (no se pueden crear varias matemáticas que sean distintas entre sí)

		int suma = Matematicas.Sumar(3, 4);
		Debug.Log(suma);

		int resta = Matematicas.Restar(7, 4);
		Debug.Log(resta);

		int multiplicacion = Matematicas.Multiplicar(2, 5);
		Debug.Log(multiplicacion);

		int division = Matematicas.Dividir(6, 2);
		Debug.Log(division);

		// Unity utiliza varias clases estáticas, entre ellas precisamente una que permite realizar diversas operaciones matématicas

		// Ejemplo de clase estática de Unity - Mathf (usando el método Clamp)

		int numero = 2;
		int valorMinimo = 0;
		int valorMaximo = 1;

		int numeroLimitado = Mathf.Clamp(numero, valorMinimo, valorMaximo); // El método Clamp límita un número para que nunca sea menor que el valor minimo ni mayor que el valor máximo

		// Ejemplo de clase estática de Unity - Physics (usando el método Raycast)

		Vector3 origenRayo = Vector3.zero;
		Vector3 direccionRayo = Vector3.up;
		float distanciaRayo = 5f;

		Physics.Raycast(origenRayo, direccionRayo, distanciaRayo); // El método Raycast lanza un rayo desde el punto de origen que le digamos en la dirección que le digamos y a la distancia máxima que le digamos

		// Ejemplo de clase estática de Unity - LayerMask (usando el método NameToLayer)

		string nombreCapa = "Personaje";
		int numeroCapa = LayerMask.NameToLayer(nombreCapa); // El método NameToLayer comprueba todas las capas (layers) que hemos creado en Unity y nos dice a qué número de capa corresponde el nombre que le hemos dicho

		// Y hay más clases estáticas en Unity, esto son solo algunos ejemplos
	}

	private void MostrarPosicionObjetos(string texto)
	{
		Debug.Log(texto);

		Debug.Log(objetoA.ObtenerPosicion());
		Debug.Log(objetoB.ObtenerPosicion());
		Debug.Log(objetoC.ObtenerPosicion());
	}

	private void MostrarTamañoObjetos(string texto)
	{
		Debug.Log(texto);

		Debug.Log(objetoA.ObtenerTamaño());
		Debug.Log(objetoB.ObtenerTamaño());
		Debug.Log(objetoC.ObtenerTamaño());
	}
}

public static class Matematicas // Clase estática
{
	/*
	public int SumarNumeros(int numeroA, int numeroB) // ¡Error! Todo lo que pongamos dentro de una clase estática debe ser estático también, no puede haber nada que no sea estático
	{
		return numeroA + numeroB;
	}
	*/

	public static int Sumar(int numeroA, int numeroB)
	{
		return numeroA + numeroB;
	}

	public static int Restar(int numeroA, int numeroB)
	{
		return numeroA - numeroB;
	}

	public static int Multiplicar(int numeroA, int numeroB)
	{
		return numeroA * numeroB;
	}

	public static int Dividir(int numeroA, int numeroB)
	{
		if (numeroB == 0)
		{
			Debug.Log("¡No se puede dividir entre 0!");
			return 0;
		}

		return numeroA / numeroB;
	}
}