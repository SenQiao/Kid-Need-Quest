using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePortal : MonoBehaviour {

	public Transform[] coinSpawns;
	public GameObject coin;

	// Use this for initialization
	void Start () {
		Spawn ();
	}

	void Spawn(){
		for (int i = 0; i < coinSpawns.Length; i++) {
				Instantiate (coin, coinSpawns [i].position, Quaternion.identity);
			
		}
	}
}
