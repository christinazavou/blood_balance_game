using UnityEngine;
using System.Collections;

public class repeatBackground : MonoBehaviour {

	public Transform player;
	public Transform rightBound;
	public Transform leftBound;

	int obj = 1;

	void Update () {
		if (rightBound.position.x - transform.position.x > 16f & obj<2) {
			makeNew ();
		}
		if (transform.position.x + 16.1744f < leftBound.position.x){
			Destroy (gameObject);
			obj -= 1;
		}
	}

	void makeNew(){
		GameObject crobj = Instantiate (gameObject, new Vector2(transform.position.x+32.3488f, transform.position.y), new Quaternion()) as GameObject;
		crobj.transform.parent = transform.parent;
		obj += 1;
	}

}
