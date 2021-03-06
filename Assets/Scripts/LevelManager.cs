﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("Load Level requested for : " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit Requested ");
		Application.Quit ();
	}

	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel+1);
	}
}
