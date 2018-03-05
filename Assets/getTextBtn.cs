using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class getTextBtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void getBtnText()
	{
		string text = this.GetComponentInChildren<Text> ().text;
		print (text);
		//return text;
	}
}
