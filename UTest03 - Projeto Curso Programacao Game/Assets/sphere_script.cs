using UnityEngine;
using System.Collections;

public class sphere_script : MonoBehaviour {

	public float velocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveMe ();
	}

	private void moveMe () {
		if (Input.GetKey (KeyCode.A))
			transform.Translate (-velocity*Time.deltaTime, 0, 0);
		if (Input.GetKey (KeyCode.D))
			transform.Translate (velocity*Time.deltaTime,0,0);
		if (Input.GetKey (KeyCode.W))
			transform.Translate (0,0,velocity*Time.deltaTime);
		if (Input.GetKey (KeyCode.S))
			transform.Translate (0,0,-velocity*Time.deltaTime);

		if (!Input.anyKey)
			GetComponent<Rigidbody> ().velocity = new Vector3 (0,0,0);
	}
}
