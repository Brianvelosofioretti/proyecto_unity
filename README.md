# proyecto_unity

Este proyecto consiste en un juego creado en unity que parte de la idea del tutorial roll a ball en este caso se ha rediseñdo el mapa haciendo un laberinto y se ha creado una ia enemiga que nos persigue mientras tratamos de recoger todos los cubos que nos darian la victoria en caso de que la ia enemiga nos alcance nuestro jugador desapareceria y perderiamos la partida.

Utilizando un navmesh que agregamos a nuestra ia enemiga  le marcamos las zonas transitables  al enemigo de esta manera no podra atravesar muros y agregandole un script con un agent = GetComponent<NavMeshAgent> (); hacemos que el enemigo se desplace a la posicion de nuestro jugador para la muerte de nuestro personaje se utiliza un vector 
distancia = Vector3.Distance (player.position, transform.position);
que calcula la distancia con nuestro personaje y que mediante una serie de condiciones le establecemos cuando eliminaria a nuestro personaje  
  
  
  
En caso de que el jugador consiga todos los puntos y gane la partida el enemigo desaparecera usando un metodo destroy al que le pasamos nuestro objeto enemigo :
Destroy (GameObject.FindGameObjectWithTag ("enemigo"));




Fuentes:
https://unity3d.com/es/learn/tutorials/projects/roll-ball-tutorial
https://www.youtube.com/watch?v=z0VncLyUuc0
http://answers.unity3d.com/questions/1222746/make-zombie-chase-player-within-a-set-range.html
