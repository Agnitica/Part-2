using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	public float hspeed=5.0f;
	public float vspeed=5.0f;
	private bool jump;
	private Rigidbody2D player;
	void Start () {
		player = GetComponent<Rigidbody2D> ();
		player.velocity = new Vector2 (0, player.velocity.y);
		
	}
	
	// Update is called once per frame
	void Update () {
		player.velocity = new Vector2 (hspeed, player.velocity.y);

		if ((jump)&&(Input.GetKey ("space"))) 
		{    
			player.velocity = new Vector2 (player.velocity.x, vspeed);
			jump = false;
		}  
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Platform") 
		{
			jump = true;
		}
	}
}
