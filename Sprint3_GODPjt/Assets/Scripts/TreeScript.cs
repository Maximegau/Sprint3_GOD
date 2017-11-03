using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TreeScript : MonoBehaviour {
	//The file that is sent to this will start with a number. That is the 
	//number of starting decisions. Those are special. 
	// Use this for initialization
	public List<ChoicesClass> currentDisplay;

	private Dictionary<string, ChoicesClass> data;

	public TextAsset myTextAsset;

	//have a streamreader. Trying to figure out how to get the address

	void Start () {
		//read in file and make a dictionary with each decision name mapped to
		 myTextAsset = Resources.Load("testertext") as TextAsset;
		string[] numberStrings = myTextAsset.text.Split('\n'); 
		foreach (string decisionLine in numberStrings){
			string[] items = decisionLine.Substring(1,decisionLine.Length - 1).Split(',');
			if (items.Length < 2){
			    //items[1] needs to be made into an array from a string
				string[] temp = items[1].Split(',');
				int faith = Convert.ToInt32(items[2]);
				ChoicesClass dec = new ChoicesClass(items[0], faith, temp);
				data.Add(items[0], dec);}
		}
	

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
