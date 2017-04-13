using UnityEngine;
using System.Collections;

public class Aiz : MonoBehaviour {

	public Transform target;//set target from inspector instead of looking in Update
	public float speed = 3f;
	public float contact_or_shoot= 3.5f;
	public GameObject bulletPrefab;//shoot potato babies
	public Sprite newSprite;
	public int Howmany=2;
	public float Follow=10f;
	private float myPosition;
	private float Check;

	public GameObject Stars;


	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			//coll.gameObject.SendMessage("ApplyDamage", 10);
			GameObject clone2;
			clone2 = (Instantiate (Stars, transform.position, transform.rotation)) as GameObject;
		}
	}

	void Start () {
		myPosition = transform.position.y;
	}

	void Update(){



		Check= transform.position.y;
		//rotate to look at the player
		//if (Vector2.Distance (transform.position, target.position) < 15f) {
			transform.LookAt (target.position);
			transform.Rotate (new Vector2 (0, -90), Space.Self);
		//} else if (myPosition == Check) {
			
			//hopping

			//transform.Translate (new Vector2 (0, 5),Space.Self);
		//}

		if (Vector3.Distance (transform.position, target.position) < contact_or_shoot && Howmany>0 && bulletPrefab!=null) {
			GameObject clone;
			clone= (Instantiate(bulletPrefab, transform.position,transform.rotation)) as GameObject;
			Howmany = Howmany - 1;
		}
		//move towards the player
		if (Vector2.Distance(transform.position,target.position)<Follow){//move if distance from target is greater than 1

			transform.Translate(new Vector2(speed* Time.deltaTime,0) );
		}

	}

}