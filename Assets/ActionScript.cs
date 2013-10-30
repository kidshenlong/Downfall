using UnityEngine;
using System.Collections;

public class ActionScript : MonoBehaviour {
	
	public Rigidbody bulletPrefab;
	public Transform barrelEnd;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Fire1"))
		{
			Rigidbody bulletInstance;
			bulletInstance = Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
			bulletInstance.AddForce(barrelEnd.forward * 5000);
		}	
	
	}
	
	void Shoot(){
		/*Rigidbody bulletInstance;
		bulletInstance = Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
		//bulletInstance.AddForce(0,0,5000);
		//bulletInstance.AddForce(barrelEnd.forward * 5000);
		bulletInstance.AddForce(barrelEnd.forward * 5000);*/
	}
}
