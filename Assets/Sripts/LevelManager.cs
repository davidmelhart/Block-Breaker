using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name) {
		Brick.breakableCount = 0;
		SceneManager.LoadScene(name);
	}

	public void QuitRequest(string name) {
		Application.Quit ();
		Debug.Log ("Quit requested.");
	}

	public void LoadNextLevel() {
		Brick.breakableCount = 0;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
		
	public void BrickDestroyed () {
		if (Brick.breakableCount <= 0) {
			LoadNextLevel();
		}
	}
}
