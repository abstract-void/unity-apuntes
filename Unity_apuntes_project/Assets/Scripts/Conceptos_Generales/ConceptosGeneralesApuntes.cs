
// -------------------------------------------------- A. SCRIPT Y CÓDIGO --------------------------------------------------


// Este documento que estás leyendo es lo que en Unity se llama script y básicamente es donde escribimos todo el código de un programa
// El código, por otro lado, es el conjunto de órdenes o instrucciones que le damos al programa para que haga lo que queremos


// -------------------------------------------------- B. COMENTARIOS --------------------------------------------------


// Esta línea de aquí es un comentario
// Los comentarios no afectan al programa, podemos poner todos los que queramos donde queramos y todo va a funcionar igual que si no estuvieran ahí
// Por tanto, los comentarios son muy útiles para añadir explicaciones que nos ayuden a entender mejor el código que hemos escrito (o para que otras personas lo entiendan)
// Para añadir un comentario en cualquier parte del programa basta simplemente con poner dos barras y empezar a escribir

/*
   En caso de que queramos escribir comentarios que ocupen varias líneas seguidas, podemos hacerlo de la siguiente forma:
		- Al principio ponemos una barra seguida de un asterisco
		- A continuacion escribimos todo lo que queramos
		- Por último, terminamos el comentario poniendo un asterisco seguido de una barra (como al principio, pero al revés)

   Esto de aquí es un ejemplo de cómo se haría
*/


// -------------------------------------------------- C. LLAVES, CORCHETES Y PARÉNTESIS --------------------------------------------------


// La inmensa mayoría del código que escribamos en Unity va a estar contenido en "bloques"
// Para indicar dónde empieza y dónde acaba cada bloque se utilizan llaves: { }
// En cada script de Unity va a haber siempre un bloque principal más grande que el resto que va a tener una estructura muy parecida a esta de aquí abajo

// public class Nombre
// {
//		// Esto es un bloque de código
// }

// Ese bloque de código principal que hay en todos los scripts se llama clase y casi siempre va a contener en su interior otros bloques de código más pequeños
// La mayoría de esos bloques de código más pequeños van a tener una estructura básica muy parecida a esta de aquí abajo

// void Nombre()
// {
//		// Esto es otro bloque de código
// }

// Ese segundo bloque de código es más o menos parecido al anterior salvo por varios cambios, incluyendo el hecho de que este lleva paréntesis detrás del nombre: ( )

// Por otro lado, habrá también ocasiones en las que, en lugar de llaves o paréntesis, tendremos que usar corchetes, que tienen su propia funcionalidad: [ ]

// Por tanto, al programar es importante tener en cuenta que existen todos estos signos de puntuación para poder diferenciarlos de manera correcta
// En resumen:
//		- { }	Esto son llaves y se usan para englobar bloques de código
//		- ( )	Esto son paréntesis y se colocan detrás del nombre en ciertos bloques de código (entre otras cosas)
//		- [ ]	Esto son corchetes y tienen un par de usos que no hemos visto aquí

// Todos estos símbolos van siempre en pareja, así que debemos tener siempre cuidado de que nunca falte ninguna de las dos partes, porque eso daría errores que pueden ser complicados de identificar si no se tiene experiencia


// -------------------------------------------------- D. PUNTO Y COMA --------------------------------------------------


// Hemos visto que al programar en Unity todo se estructura en bloques de código que pueden ser más grandes o más pequeños
// Sin embargo, esos bloques de código por lo general no están vacíos, sino que contienen las órdenes o instrucciones que le damos al programa
// Estas instrucciones se diferencian de los bloques de código en el hecho de que no contienen nada: una instrucción es lo que es y punto
// Sin embargo, el programa debe saber de algún modo dónde termina cada instrucción
// Y eso se hace poniendo un punto y coma al final

// Esto de aquí abajo es una instrucción, así que al acabar de escribirla tenemos que poner un punto y coma para indicarle al programa que justo ahí es donde termina

using UnityEngine;


// -------------------------------------------------- E. USING --------------------------------------------------


// Esa línea de código que acabamos de poner aquí arriba es una de las muy poquitas que no necesita escribirse dentro de un bloque de código
// Para entender su función, podemos imaginarnos que cuando programamos tenemos diversas "cajas de herramientas" a nuestra disposición
// En tal caso, lo que estaríamos haciendo en la línea de arriba es indicarle al programa que queremos utilizar una de esas cajas de herramientas
// En concreto, la caja de herramientas que queremos usar aquí se llama UnityEngine y es probablemente la más importante a la hora de programar en Unity
// Por tanto, esa línea de código que hemos puesto arriba la vamos a necesitar en la inmensa mayoría de scripts que escribamos en Unity


// -------------------------------------------------- F. CLASES --------------------------------------------------


// Arriba hemos hablado de bloques de código y de que todos los scripts en Unity tienen un bloque principal que se llama clase
// Pues justo aquí abajo tenemos un ejemplo de ello
// Todo el código que está escrito a continuación forma parte de una clase (que en este caso se llama ConceptosGeneralesApuntes)

public class ConceptosGeneralesApuntes : MonoBehaviour // El MonoBehaviour y los dos puntos los podemos ignorar de momento, pero básicamente sirven para que podamos poner este script en una escena de Unity
{
	// En la línea de aquí arriba está la llave que abre este bloque de código y justo al final de este script está la llave que lo cierra
	// Por tanto, todo lo que hay entre esas dos llaves forma parte del contenido de la clase (incluyendo estas dos líneas de código y todas las que aparecen debajo)


	// -------------------------------------------------- G. MÉTODOS --------------------------------------------------


	// Antes hemos comentado que casi todo el código que escribamos va a estar dentro de una clase
	// Pues, si especificamos aún más, podemos afirmar que una gran parte de todo el código que escribamos dentro de una clase va a estar a su vez contenido en otros bloques más pequeños
	// Estos bloques más pequeños son los que hemos mencionado más arriba (los que llevan los dos paréntesis detrás del nombre) y se llaman métodos

	// Aquí abajo tenemos dos ejemplos de métodos que vamos a ver con bastante frecuencia en Unity

	void Awake() // Aquí empieza un método que se llama Awake
	{
		// Al igual que ocurre con las clases, todo el contenido de un método se escribe entre dos llaves

		Debug.Log("¡Hola, mundo!");
	}

	void Update() // Aquí empieza un método que se llama Update
	{
		Debug.Log("Me repito más que el ajo");
	}


	// -------------------------------------------------- H. DEBUG.LOG --------------------------------------------------


	// A modo de ejemplo, en los métodos de arriba hemos puesto una instrucción que nos va a venir bastante bien siempre que escribamos código en Unity
	// Esa instrucción es Debug.Log() y lo que hace es mostrar en Unity el mensaje que pongamos entre los paréntesis
	// Así que, en general, el Debug.Log se usa sobre todo para comprobar si un determinado bloque de código está funcionando o, en caso de que no, qué es lo que está haciendo que no funcione

	// En estos apuntes, el Debug.Log se usa sobre todo para hacer demostraciones
	// Para poder ver esas demostraciones es necesario añadir este script a un objeto cualquiera de una escena en Unity y hacer clic en el botón de jugar
	// Si tenemos abierta en Unity la consola (la ventana que se llama Console), podremos ver todos los mensajes que hayamos escrito en los Debug.Log
}
