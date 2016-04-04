﻿using UnityEngine;
using System.Collections;

public class DestroyBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}


	void OnCollisionEnter(Collision col){

		if (col.collider.tag == "Enemy" || col.collider.tag == "Floor") {

			Destroy (this.gameObject);
		}
	}
}