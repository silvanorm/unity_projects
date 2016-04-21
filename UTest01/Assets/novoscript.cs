using UnityEngine;
using System.Collections;

public class novoscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(-10*Time.deltaTime,0,0);
		} else if(Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate (10*Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.A)) {
			transform.Rotate (0,30*Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.W)){
			transform.localScale = new Vector3 (2.5f, 2.5f, 2.5f);
		} else if(Input.GetKey(KeyCode.S)) {
			transform.localScale = new Vector3 (1, 1, 1);
		}
	}
}
