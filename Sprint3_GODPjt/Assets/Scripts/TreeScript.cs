using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour {
	//The file that is sent to this will start with a number. That is the 
	//number of starting decisions. Those are special. 
	// Use this for initialization
	public List<ChoicesClass> currentDisplay;

	private Dictionary<string, ChoicesClass> data;

	//have a streamreader. Trying to figure out how to get the address

	void Start () {
		//read in file and make a dictionary with each decision name mapped to
		//the ChoicesClass
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
