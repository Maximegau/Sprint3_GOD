using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVariables : MonoBehaviour {

	public static int faith = 30;
	public static ChoicesClass lastChoice = null;

	public int changeFaith(int change){
		faith += change;
		return faith;
	}

	//public int getFaith(){
	//	return faith;
	//}

	public ChoicesClass getLastChoice(){
		return lastChoice;
		//or return an error saying it is null
	}

	public void setLastChoice(ChoicesClass a){
		lastChoice = a;
	}
}
