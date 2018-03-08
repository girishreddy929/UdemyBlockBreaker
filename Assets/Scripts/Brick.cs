using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {


	public int Maxhits;
	private int TimesHit;
	private LevelManager levelmanager;
	// Use this for initialization
	void Start () {
		TimesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){
		TimesHit++;
		if (Maxhits >= TimesHit) {
			Destroy (gameObject);
		}
	}

	void SimulateWin(){
		levelmanager.LoadNextLevel();
	}
}
