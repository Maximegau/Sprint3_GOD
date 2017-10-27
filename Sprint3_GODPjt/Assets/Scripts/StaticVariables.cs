using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVariables : MonoBehaviour {

	public static int faith = 30;

	public int changeFaith(int change){
		faith += change;
		return faith;
	}

	public int getFaith(){
		return faith;
	}
}
