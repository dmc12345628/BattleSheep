using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	public Button jouer;

	// Use this for initialization
	void Start () {
		if (jouer != null) {
			jouer.onClick.AddListener (StartGame);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void StartGame() {
		
	}
}
