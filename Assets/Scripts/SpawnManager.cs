using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	public int maxPlatforms = 50;
	public GameObject platform;
	public GameObject platform2;
	public GameObject platform3;
	public GameObject platform4;
	public float horizontalMin = 6.5f;
	public float horizontalMax = 14f;
	public float verticalMin = 0f;
	public float verticalMax = 0f;
	public int portalMax=2;
	private int platformNum;


	private Vector2 originPosition;


	// Use this for initialization
	void Start () {
	
		originPosition = transform.position;
		Spawn ();

	}
	
	void Spawn(){
		for (int i = 0; i < maxPlatforms; i++) {
			if(portalMax>0){
				platformNum = Random.Range (0, 4);
			}
			else{
				platformNum = Random.Range (0, 3);
			}
			if (platformNum == 0) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
				Instantiate (platform, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			} else if (platformNum == 1){
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
				Instantiate (platform2, randomPosition, Quaternion.identity);
				originPosition = randomPosition;				
			} else if (platformNum == 2){
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
				Instantiate (platform3, randomPosition, Quaternion.identity);
				originPosition = randomPosition;				
			} else if (platformNum == 3){
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
				Instantiate (platform4, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
				portalMax = portalMax - 1;
			}
		}
	}
}
