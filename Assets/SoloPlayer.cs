using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoloPlayer : MonoBehaviour {

	public enum ButtonStates
	{
		//default states
		Empty,
		Sheep,
		//clicked states
		EmptyClicked,
		SheepClicked
	}


	private ButtonStates[,] tableButtons;

	// Use this for initialization
	void Start () {
		tableButtons = new ButtonStates[,]{
			{ButtonStates.Sheep, ButtonStates.Empty, ButtonStates.Empty, ButtonStates.Empty, ButtonStates.Empty},
			{ButtonStates.Sheep, ButtonStates.Empty, ButtonStates.Empty, ButtonStates.Empty, ButtonStates.Empty},
			{ButtonStates.Sheep, ButtonStates.Empty, ButtonStates.Empty, ButtonStates.Empty, ButtonStates.Empty}
		};



		
	}

	public void Click(string msg){


	}

	/*public int[] Convert(string ) {

	}*/
	
	// Update is called once per frame
	void Update () {
		
	}
}
