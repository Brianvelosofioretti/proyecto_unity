using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemy : MonoBehaviour {
	public Transform player;
	public float distancia;
	public Text texto;
	NavMeshAgent agent;

	// Use this for initialization

	void Awake(){
		agent = GetComponent<NavMeshAgent> ();// a agent le pasamos el navmesh
	}


	// Update is called once per frame
	void Update () {
		distancia = Vector3.Distance (player.position, transform.position);//calcula distancia

		if(distancia <60){
		
			agent.SetDestination (player.position);//

		if (distancia<1.2){
		
		texto.text="YOU LOSE";
				Destroy (GameObject.FindGameObjectWithTag ("Player"));
			
	}
}
	}
}
