using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text scoreText;
	public Text winText;

	private Rigidbody rb;
	private int score;

	// Use this for initialization
	void Start () 
	{
		// Gets rigidbody component from owner of PlayerController
		rb = GetComponent<Rigidbody> ();

		score = 0;
		SetScoreText ();
		winText.text = "";
	}

	// Update is called just before a physics calculation is performed
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			score += 1;
			SetScoreText ();
		}
	}

	void SetScoreText ()
	{
		scoreText.text = "Score: " + score.ToString ();
		if (score >= 8) 
		{
			winText.text = "You Won!";
		}
	}
}
