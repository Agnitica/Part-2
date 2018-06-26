using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	// Use this for initialization
	public CameraController cam;
	public GameObject Initialpos;
	public GameObject[] p;
	private Vector3 d;
	public float disbetween=1.0f;
	private Vector3 des;

	void Start () {
		d =   transform.position-cam.transform.position;
		des=cam.transform.position-Initialpos.transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x - cam.transform.position.x < d.x) {
			GameObject pt = Instantiate (p[Random.Range (0, p.Length)]);
			pt.transform.position = new Vector3 (transform.position.x + disbetween, transform.position.y, transform.position.z);
			transform.position =     new Vector3 (pt.transform.position.x + pt.GetComponent<BoxCollider2D> ().size.x,  transform.position.y, transform.position.z);
		}

		if (cam.transform.position.x - Initialpos.transform.position.x > des.x)
		{
			GameObject platdes = GameObject.FindGameObjectWithTag ("Platform");

			if ( platdes.transform.position.x<Initialpos.transform.position.x) 
			{
				Destroy (platdes);

			}
			Initialpos.transform.position = new Vector3 (Initialpos.transform.position.x+(cam.transform.position.x -(Initialpos.transform.position.x+des.x)), Initialpos.transform.position.y, Initialpos.transform.position.z);
		}

	}
}
