using UnityEngine;
using System.Collections;

public class BulletDestructionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		 Destroy (gameObject, 3.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision col) {
		
		Destroy (gameObject, 1.0f);
		
	}
}
