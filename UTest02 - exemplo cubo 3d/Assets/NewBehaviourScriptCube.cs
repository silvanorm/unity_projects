using UnityEngine;
using System.Collections;

public class NewBehaviourScriptCube : MonoBehaviour {

	int x;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow))
			transform.Translate (5*Time.deltaTime,0,0);
		else if(Input.GetKey (KeyCode.LeftArrow))
			transform.Translate (-5*Time.deltaTime,0,0);
		else if(Input.GetKey (KeyCode.UpArrow))
			transform.Translate (0,5*Time.deltaTime,0);
		else if(Input.GetKey (KeyCode.DownArrow))
			transform.Translate (0,-5*Time.deltaTime,0);
		transform.Translate (0,0,2*Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){
		//Debug.Log ();
		x++;
		Destroy (other.gameObject);
		Debug.Log (x);
	}

}
