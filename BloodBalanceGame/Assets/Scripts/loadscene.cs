using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour {

	public void LoadByIndex(int idx){
		SceneManager.LoadScene (idx);		
	}

}
