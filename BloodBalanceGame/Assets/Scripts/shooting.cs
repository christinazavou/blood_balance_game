using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Enemie")) {
			other.GetComponent<enemy_health> ().addDamage (-0.25f);
		}
		//opou kai na xtipisi o shooter pethenei
		Destroy(gameObject);
	}

	void makeDead(){
		GameObject appearance = transform.Find ("cleardrop").gameObject;
		appearance.SetActive (false);
		Invoke ("Destroy", 1);
	}

}
