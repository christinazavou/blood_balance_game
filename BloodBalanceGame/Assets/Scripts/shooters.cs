using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shooters : MonoBehaviour {

	public GameObject myshooterprefab;
	public Transform rightBound;

	private GameObject mycurrentshooter;

	void Update(){
		if (Input.GetKey (KeyCode.RightArrow) && mycurrentshooter == null 
			&& gameObject.GetComponent<blood_movement>().isgrounded
			&& gameObject.GetComponent<player_controller>().canShoot()) {
			Create ();
		}
		if (mycurrentshooter != null) {
			mycurrentshooter.GetComponent<Rigidbody2D>().AddForce (Vector2.right*10f);
			if (mycurrentshooter.transform.position.x > rightBound.position.x) {
				Destroy (mycurrentshooter);
			}
		}
	}

	public void Create(){
		mycurrentshooter = Instantiate (myshooterprefab, new Vector2(transform.position.x+0.2f,transform.position.y), transform.rotation) as GameObject;
		mycurrentshooter.GetComponent<Rigidbody2D>().AddForce (Vector2.right*10f);
		gameObject.GetComponent<player_controller> ().increaseWhite (-0.05f);
	}

}
