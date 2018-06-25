using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	public Player player; 
	private float x;

	void Start () {
		x = transform.position.x - player.transform.position.x;     
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.transform.position.x + x, transform.position.y, transform.position.z);

					
	}
}
