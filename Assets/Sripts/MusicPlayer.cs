using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	public static MusicPlayer instance = null;

	public MusicPlayer() {
		
	}

	void Awake () {
		if (instance != null) {
			Destroy(gameObject);
			print("Duplicate Music Player is self-destructing.");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}
}
