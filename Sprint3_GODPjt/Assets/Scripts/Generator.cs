using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	public int numberObjects;
	public GameObject prefab;
	Vector3 pos;
	int changeInPos;

	// Use this for initialization
	void Start () {
		generatorMethod ();
		numberObjects = StaticVariables.current.Count;

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	Vector3 RandomCircle(Vector3 center, float radius){
		float ang = changeInPos;
		pos.x = center.x + radius * Mathf.Sin (ang * Mathf.Deg2Rad);
		pos.y = center.y;
		pos.z = center.z + radius * Mathf.Cos (ang * Mathf.Deg2Rad);

		return pos;

	}

	public void generatorMethod (){
		Vector3 center = transform.position;
		for (int i = 0; i < numberObjects; i++)
		{
			changeInPos = (270 / numberObjects) * i;
			Vector3 circlePos = RandomCircle (center, 5f);
			Quaternion rot = Quaternion.FromToRotation (Vector3.forward, center - circlePos);
			Instantiate (prefab, pos, rot);
		}
	}
}