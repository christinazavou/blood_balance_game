using UnityEngine;
using System.Collections;

public class cell_gained : MonoBehaviour {

	public GameObject particle_prefab;
	public Transform rightBound;
	public Transform leftBound;
	public GameObject particles;

	void FixedUpdate(){
		if (transform.position.x < leftBound.position.x) {
			CreateNew ();
		}
	}

	public void CreateParticles(){
		particles = Instantiate (particle_prefab, transform.position, transform.rotation) as GameObject;
		Invoke ("makeDead", 1);
	}

	void makeDead(){
		gameObject.SetActive (false);
		Invoke ("destroyprtcls",1);
	}

	void destroyobj(){
		Destroy (gameObject);
	}

	void destroyprtcls(){
		Destroy (particles);
		CreateNew();
	}
		
	public void CreateNew(){
		Transform newTransform = transform;
		float rdm = Random.value;
		newTransform.position = new Vector2(rightBound.position.x + rdm*1.5f, transform.position.y);
		gameObject.SetActive (true);
	}

}