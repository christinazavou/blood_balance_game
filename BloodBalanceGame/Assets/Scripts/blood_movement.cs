using UnityEngine;
using System.Collections;

public class blood_movement : MonoBehaviour {

	public float speed;

	public bool isgrounded;
	private float time_passed;

	void Start(){
		isgrounded = false;
		time_passed = 0f;
	}

	void FixedUpdate(){
//		time_passed = Time.time % 60f;
//		if (time_passed == 30f) {
//			speed = speed * 1.3f;
//		}
	}

	void Update(){
		if (Input.GetKey (KeyCode.UpArrow) && isgrounded) {
			gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0.05f, 50f), ForceMode2D.Impulse);
			isgrounded = false;
		} else {
			gameObject.transform.Translate(Vector3.right*speed*Time.deltaTime);
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Ground") {
			isgrounded = true;
		}
	}

}