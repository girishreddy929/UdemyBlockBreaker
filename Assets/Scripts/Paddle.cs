using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		Vector3 Paddlepos = new Vector3(0.5f,this.transform.position.y,0f);
		float mouseinput = Input.mousePosition.x/Screen.width *16 ;

		Paddlepos.x = Mathf.Clamp(mouseinput,0.75f,15.25f);
		this.transform.position = Paddlepos;
	}
}
