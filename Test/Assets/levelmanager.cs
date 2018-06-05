using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour {

	public void LoadLevel (string name){
		Application.LoadLevel(name);
	}

	public void quitrequest (){
		Application.Quit ();
	}

}
