using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicesClass : MonoBehaviour {

	//have the actual text
	public string decision;

	//children
	private List<ChoicesClass> children = null;

	//whether remains next time or not
	public bool persistant;

	//conditions that change faith modifier
	private List<string> conditionals = null;

	//faith given
	private int faithGiven;

	public ChoicesClass(string dec, bool persist, int fate){
		decision = dec;
		persistant = persist;
		faithGiven = fate;
	}

	public void addChild(ChoicesClass child){
		if (children == null){
			children = new List<ChoicesClass>();
			children.Add (child);
		}
		else
			children.Add(child)
				
	}

	public List<ChoicesClass> getChildren(){
		return children;
	}

	public bool stays(){
		return persistant;
	}

	public int getFaith(){

	}

}
