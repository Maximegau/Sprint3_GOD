using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicesClass : MonoBehaviour {

	//have the actual text
	public string decision;

	//children
	private List<string> children = null;
	private string[] childrenHolder;

	//whether remains next time or not
	//public bool persistant = true;

	//conditions that change faith modifier
	private List<string> conditionals = null;

	//faith given
	public int faithGiven;

	public ChoicesClass(string dec, int fate, string[] childrenAr){
		decision = dec;
		//persistant = persist;
		faithGiven = fate;
		childrenHolder = childrenAr;
	}

	/*public void addChild(ChoicesClass child){
		if (children == null) {
			children = new List<ChoicesClass> ();
			children.Add (child);
		} else
			children.Add (child);
				
	}*/

	public List<string> getChildren(){
		return children;
	}

	/*public bool stays(){
		return persistant;
	}*/

	public int getFaith(){
		return faithGiven;
	}

	public bool matchDecision(string matchTo){
		return matchTo.Equals (decision);
	}

	public void fillConstraint(ChoicesClass cur){
		//foreach (string con in conditionals){
		//	if (cur.matchDecision (con)) {
				//remove it. if con now empty, then multiply the faith by -1
		//	}				
		//}
		if (conditionals.Contains (cur.decision)) {
			conditionals.Remove (cur.decision);
			if (conditionals.Count == 0)
				faithGiven = faithGiven * -1;
		}
	}

	public List<string> chosen(){
		StaticVariables.faith += faithGiven;
		//persistant = false;
		//remove self from reveal list maybe?
		return children;
	}

}
