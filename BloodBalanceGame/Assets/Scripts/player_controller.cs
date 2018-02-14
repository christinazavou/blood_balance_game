using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class player_controller : MonoBehaviour {

	public Slider whiteslider;
	public UnityEngine.UI.Image WhiteSliderFill;
	public Slider redslider;

	public AudioSource healthy_audio;
	public AudioSource unhealthy_audio;
	public AudioSource hit_heart_audio;

	public Text gameover_text;
	public Text time_text;
	public Text score_text;
	//public Text health_text;

	public float player_health;
	public float bonus; // from hits

	Animator myAnim;

	private bool gameover;

	void Start () {
		myAnim = gameObject.GetComponent<Animator> ();
		calculateHealth ();
		gameover = false;
		gameover_text.text = "";
		score_text.text = "";
		//health_text.text = "";
	}

	void Update(){
		if (!gameover) {
			int seconds = (int)(Time.time);
			time_text.text = seconds.ToString ();
		}
		if (myAnim.GetCurrentAnimatorStateInfo (0).IsName ("droplet_death")) {
			GameOver ();
		}
		if (Input.GetKeyDown(KeyCode.Q)){	
			Restart ();			
		}
	}

	void FixedUpdate () {
		calculateHealth ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("RedCell")) {
			other.GetComponent<cell_gained> ().CreateParticles ();
			increaseRed (0.05f);
		} 
		else {
			if (other.gameObject.CompareTag ("WhiteCell")) {
				other.GetComponent<cell_gained> ().CreateParticles ();
				increaseWhite (0.05f);
			} else {
				if (other.gameObject.CompareTag ("Enemie")) {
					increaseRed (-0.05f);
					hit_heart_audio.Play();
				}
			}
		}
	}

	public bool canShoot(){
		if (whiteslider.GetComponent<Slider> ().value < 0.1) {
			return false;
		} else {
			return true;
		}
	}

	public void increaseWhite(float inc){
		float x = whiteslider.GetComponent<Slider>().value + inc;
		x = Mathf.Clamp(x, 0f, 1f);
		whiteslider.GetComponent<Slider>().value = x;
	}

	public void increaseRed(float inc){
		float x = redslider.GetComponent<Slider>().value + inc;
		x = Mathf.Clamp(x, 0f, 1f);
		redslider.GetComponent<Slider>().value = x;
	}

	void calculateHealth(){ // in [0,1]
		float reds = redslider.GetComponent<Slider>().value;
		float whites = whiteslider.GetComponent<Slider>().value;
		player_health = 0f;
		if (whites > 2f * reds) {
			player_health -= 0.4f;
			WhiteSliderFill.GetComponent<Image>().color = new Color (120f, 120f, 120f, 120f);
		} else {
			WhiteSliderFill.GetComponent<Image>().color = new Color (255f, 255f, 255f, 255f);
		}
		if (reds == 0f) {
			player_health -= 0.5f;
		}
		player_health += (whites + reds) * 1.2f;
		player_health += bonus;
		player_health = Mathf.Clamp (player_health, 0f, 1f);
		myAnim.SetFloat ("health", player_health);
		//health_text.text = player_health.ToString("F2");
		playMusic ();
	}

	void playMusic(){
		if (player_health < 0.25f && (!unhealthy_audio.isPlaying)) {
			healthy_audio.Stop();
			unhealthy_audio.Play();
		}
		if (player_health >= 0.25f && (!healthy_audio.isPlaying)){
			unhealthy_audio.Stop();
			healthy_audio.Play();
		}
	}

	public void GameOver(){
		gameover_text.text = "Game Over";
		score_text.text = "Score:" + time_text.text;
		gameover = true;
		unhealthy_audio.Stop ();
		gameObject.GetComponent<blood_movement> ().speed = 0f;
		Invoke ("Restart", 2);
	}

	void Restart(){
		SceneManager.LoadScene (0);		
	}

}