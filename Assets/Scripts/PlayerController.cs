using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float Speed = 0f;
	private float movex = 0f;
	private float movey = 0f;
	Rigidbody2D rigidbody2D;
//	public rigidbody = new Rigidbody("Player")
	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		rigidbody2D.velocity = new Vector2 (movex * Speed, movey * Speed);
	}
}
