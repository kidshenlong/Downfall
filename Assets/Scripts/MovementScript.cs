using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	
	//public enum Direction { Forward = 0, Right = 1, Left = 2, Back = 3 }
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (Input.GetKey ("w")){
			rigidbody.AddForce (10,0,0);
		}
		if (Input.GetKey ("d")){
			rigidbody.AddForce (0,0,-10);
		}
		if (Input.GetKey ("s")){
			rigidbody.AddForce (-10,0,0);
		}
		if (Input.GetKey ("a")){
			rigidbody.AddForce (0,0,10);
		}
	
	}
}
