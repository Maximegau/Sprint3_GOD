using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceSelector : MonoBehaviour {
	private Object[] peopleArray;
	private int pointer;
	public GameObject orb;

	// Use this for initialization
	void Start () {
		peopleArray = Resources.LoadAll ("ImagesForPeople");
		pointer = 0; //might want to assign it to max or have it load index
		//of 0 in the first place for consistancy. The peopleArray could be
		//a bunch of textures and each texture is the world.
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void decisionEffects(){
		//we need a way to track which option was just chosen. I say have
		//the update always looking for a raycast and when it finds one, taking that
	}

	private void endGame(bool won){
		if (won) {
			//will display the you win screen over civilization overlay
		} else {
			// Will display black screen with you are forgotten
		}
	}

	public void loadNextImage(bool forward){
		int length = peopleArray.Length;
		if (forward) {
			pointer++;
			if (pointer >= length)
				endGame(true);
		} else {
			pointer--;
			if (pointer < 0)
				endGame (false);
		}
		Object temp = peopleArray [pointer];
		Texture2D tex = temp as Texture2D;
		//can call another thing with temp or
		//you have a public varible that it loads into(better)
	}

}
