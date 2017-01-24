using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Rigidbody pacman;
	public int score;
	public int health;
	public Text scoreDisplay;
	public Text healthDisplay;

	// Use this for initialization
	void Start () {
		pacman = GetComponent<Rigidbody> ();
		score = 0;
		scoreDisplay.text = "Score: " + score;
		health = 5;
		healthDisplay.text = "Health: " + health;
	}

	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");



		Vector3 move = new Vector3(moveHorizontal, 0.0f, moveVertical);

		pacman.AddForce (move * speed);
	}

	void OnCollisionEnter(Collision col){
		if (col.rigidbody.CompareTag ("Ghost")) {
			health--;
			healthDisplay.text = "Health: " + health;
		}
	}

	 void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Coin")) {
			other.gameObject.SetActive (false);
			score++;
			scoreDisplay.text = "Score: " + score;
		}
	}

}
