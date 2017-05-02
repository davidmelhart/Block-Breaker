using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Paddle paddle;

	private Vector3 paddleToBallVector;

	private bool isStarted = false;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType <Paddle> ();
		paddleToBallVector = this.transform.position - paddle.transform.position;

	}

	void OnCollisionEnter2D(Collision2D collision) {
		Vector2 bounce = new Vector2 (Random.Range (0f, 0.2f), Random.Range (0f, 0.2f));
		if (isStarted) {
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			GetComponent<Rigidbody2D> ().velocity += bounce;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!isStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
			if (Input.GetMouseButtonDown (0)) {
				isStarted = true;
				this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (2f, 10f);
			}
		}
	}
}
