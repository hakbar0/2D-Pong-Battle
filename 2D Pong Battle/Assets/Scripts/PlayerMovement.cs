using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveVertical = Input.GetAxis ("Vertical");
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb.AddForce (movement * speed);
	}
}
