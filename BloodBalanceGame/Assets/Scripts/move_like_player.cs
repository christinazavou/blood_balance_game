using UnityEngine;
using System.Collections;

public class move_like_player : MonoBehaviour {

	public GameObject player;

	float dist_from_player;

	void Start () {
		dist_from_player = transform.position.x - player.transform.position.x;
	}
	
	void Update () {
		transform.position = new Vector2(player.transform.position.x + dist_from_player, transform.position.y);
	}

}
