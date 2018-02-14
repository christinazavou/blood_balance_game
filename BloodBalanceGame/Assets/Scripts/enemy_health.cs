using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class enemy_health : MonoBehaviour {

	public Slider enemySlider;
	public Transform leftBound;
	public Transform rightBound;
	public GameObject prefabObj;
	public Text time_text;

	float currentHealth;

	public void setHealth(float h){
		currentHealth = h;
		enemySlider.GetComponent<Slider>().value = currentHealth;
	}

	void Awake(){
		setHealth (1f);
	}

	void Start () {
		setHealth (enemySlider.GetComponent<Slider>().maxValue);
	}
		
	public void addDamage(float damage){
		setHealth (currentHealth + damage);
		if (currentHealth <= 0) {
			makeDead ();
			//GameObject player = GameObject.FindWithTag("Player");
			//player.GetComponent<player_controller> ().bonus = 0.1f;
		}
	}

	void FixedUpdate(){
		if (transform.position.x < leftBound.position.x) {
			makeDead ();
			GameObject player = GameObject.FindWithTag("Player");
			player.GetComponent<player_controller> ().bonus = -0.1f;
		}
	}

	public void makeDead(){
		makeNew();
		Invoke ("Die", 1);
	}

	void Die(){
		Destroy (gameObject);
	}

	void makeNew(){
		float rdm = Random.value;
		rdm = rdm * 1.5f;
		Transform new_transform = transform;
		new_transform.position = new Vector2 (rightBound.position.x + rdm, transform.position.y);
		GameObject newobj = Instantiate (prefabObj, new_transform) as GameObject;
		newobj.transform.parent = transform.parent;
	}
		
}