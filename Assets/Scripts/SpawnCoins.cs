using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour {

	public Transform[] coinSpawns;
	public GameObject coin;
	public GameObject coin2;

	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	void Spawn(){
		int coinFlip2 = Random.Range (0, 2);
		if (coinFlip2 == 0) {
			for (int i = 0; i < coinSpawns.Length; i++) {
				int coinFlip = Random.Range (0, 7);
				if (coinFlip == 0) {
					Instantiate (coin, coinSpawns [i].position, Quaternion.identity);
				}
			}
		} else {
			for (int i = 0; i < coinSpawns.Length; i++) {
				int coinFlip = Random.Range (0, 7);
				if (coinFlip == 0) {
					Instantiate (coin2, coinSpawns [i].position, Quaternion.identity);
				}
			}
		}
	}
}
