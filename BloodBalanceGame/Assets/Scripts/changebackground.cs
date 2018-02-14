using UnityEngine;
using System.Collections;

public class changebackground : MonoBehaviour {

	int current = 1;
	private GameObject[] all_current;
	private GameObject[] all_to_change;

	void Update () {
		float x = Random.value;
		float y = Random.value;
		if (x<0.005) { // change bgrnd
			if (current == 1) { //choose 2 or 3
				all_current = GameObject.FindGameObjectsWithTag ("background1"); 
				if (y < 0.5) {
					current = 2;
					all_to_change = GameObject.FindGameObjectsWithTag ("background2"); 
				} else {
					current = 3;
					all_to_change = GameObject.FindGameObjectsWithTag ("background3"); 
				}
			} else if (current == 2) { //choose 1 or 3
				all_current = GameObject.FindGameObjectsWithTag ("background2"); 
				if (y < 0.5) {
					current = 1;
					all_to_change = GameObject.FindGameObjectsWithTag ("background1"); 
				} else {
					current = 3;
					all_to_change = GameObject.FindGameObjectsWithTag ("background3"); 
				}
			} else {//choose 1 or 2
				all_current = GameObject.FindGameObjectsWithTag ("background3"); 
				if (y < 0.5) {
					current = 1;
					all_to_change = GameObject.FindGameObjectsWithTag ("background1"); 
				} else {
					current = 2;
					all_to_change = GameObject.FindGameObjectsWithTag ("background2");
				}
			}
			foreach(GameObject tochange in all_to_change){
				tochange.transform.position = new Vector2 (tochange.transform.position.x, 0f);
			}
			foreach(GameObject cur in all_current){
				cur.transform.position = new Vector2 (cur.transform.position.x, 10f);
			}
		}

	}
}
