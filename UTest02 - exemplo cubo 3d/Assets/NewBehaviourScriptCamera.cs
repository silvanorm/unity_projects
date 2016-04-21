using UnityEngine;
using System.Collections;

public class NewBehaviourScriptCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0,0,2*Time.deltaTime);
	}
}
