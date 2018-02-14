using UnityEngine;
using System.Collections;

public class followplayer : MonoBehaviour {

	public Transform player;

	float dist;

	void Start(){
		dist = transform.position.x - player.transform.position.x;
	}

	void Update (){
		//transform.position = Camera.main.ScreenToWorldPoint (player.position) + new Vector3(0.0f,1.5f,0.0f);
		transform.position = new Vector3(player.transform.position.x+dist, transform.position.y, transform.position.z);
	}

}
