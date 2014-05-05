﻿using UnityEngine;
using System.Collections;

public class MiLauncher : MonoBehaviour {
	
	public GameObject missile;
	
	// Use this for initialization
	void Start () {

	}

	public void ShootMissile( GameObject target ) {

		GameObject shot = GameObject.Instantiate( missile, transform.root.position + (transform.root.forward * 10), transform.root.rotation) as GameObject;
		shot.GetComponent<SteeringManager> ().maxForce = 400;
		shot.GetComponent<SteeringManager> ().maxSpeed = 400;
		
		shot.GetComponent<SteeringManager> ().leader = target;
		
		shot.GetComponent<SteeringManager> ().TurnAllOff ();
		shot.GetComponent<SteeringManager>().TurnOn("Follow");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
