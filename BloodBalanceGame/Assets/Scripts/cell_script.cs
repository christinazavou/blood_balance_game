using UnityEngine;
using System.Collections;

public class cell_script : MonoBehaviour {

	public Transform leftBound;
	public Transform rightBound;
	public GameObject myprefab;
	public GameObject particles_prefab;

	GameObject particles;

	void Awake(){
		particles = null;
	}

	void FixedUpdate(){
		if (transform.position.x < leftBound.position.x) {
			makeDead ();
		}
	}

	public void makeDead(){
		makeNew();
		Invoke ("Die", 1);
	}

	void Die(){
		if (particles != null) {
			Destroy (particles);
		}
		Destroy (gameObject);
	}

	void makeNew(){
		float rdm = Random.value;
		rdm = rdm * 1.5f;
		Transform new_transform = transform;
		new_transform.position = new Vector2 (rightBound.position.x + rdm, transform.position.y);
		GameObject newobj = Instantiate (myprefab, new_transform) as GameObject;
		newobj.transform.parent = transform.parent;
	}

	public void CreateParticles(){
		particles = Instantiate (particles_prefab, transform.position, transform.rotation) as GameObject;
		particles.transform.parent = transform.parent;
		Invoke ("makeDead", 1);
	}

}
