using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		SceneManager.LoadScene(name);
	}

	public void QuitRequest(string name) {
		Application.Quit ();
		Debug.Log ("Quit requested.");
	}

}