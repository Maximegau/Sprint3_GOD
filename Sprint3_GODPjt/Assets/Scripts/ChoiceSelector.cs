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

	public void loadNextImage(int forward){
		int length = peopleArray.Length;
		if (forward > 0) {
			pointer++;
			if (pointer >= length) {
				endGame (true);
				return;
			}
		} else if (forward < 0) {
			pointer--;
			if (pointer < 0) {
				endGame (false);
				return;
			}
		} else {
			//This will be where if you chose neutral you may end up doing it as
			//pos or neg with certain probability
		}
		Object temp = peopleArray [pointer];
		Texture2D tex = temp as Texture2D;
		orb.GetComponent<Renderer>().material.mainTexture = tex;
		//can call another thing with temp or
		//you have a public varible that it loads into(better)
	}

}
