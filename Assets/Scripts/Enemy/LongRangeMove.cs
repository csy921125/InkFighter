﻿using UnityEngine;
using System.Collections;

public class LongRangeMove : MonoBehaviour {

	private Enemy thisEnemy;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		thisEnemy = GetComponent<Enemy> ();
		thisEnemy.debug ();

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 distance = transform.position - thisEnemy.getTarget ().transform.position;
		if (thisEnemy.getSeenTarget ()) {
			if (distance.magnitude > thisEnemy.vision) {
				move ();
				Debug.Log ("im moving");
			}
		} else if (distance.magnitude < thisEnemy.vision) {
			thisEnemy.setSeenTarget ();
		}
	}

	public void move () {
		thisEnemy.transform.position = Vector3.MoveTowards (thisEnemy.transform.position, 
			thisEnemy.getTarget().transform.position, thisEnemy.speed * Time.deltaTime);
	}


}
