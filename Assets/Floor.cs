using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

	void OnCollisionEnter(Collision coll){
		GameObject collidedWith = coll.gameObject;
		GameObject droppedFood = GameObject.FindGameObjectWithTag ("DroppedFoodText");
		if (collidedWith.tag == "Bread" || collidedWith.tag == "Ham" || collidedWith.tag == "Lettuce" || collidedWith.tag == "Cheese") {
			droppedFood.SetActive (true);
		}

	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
