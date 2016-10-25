﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class kill_vedio : MonoBehaviour {

	public MovieTexture movie;
	public RawImage rawImage;

	// Use this for initialization
	void Start () {
		GetComponent<RawImage> ().texture = movie as MovieTexture;
		movie.Play ();
		StartCoroutine(endMovie());
	}

	// Update is called once per frame
	void Update () {
	}

	IEnumerator endMovie() {		
		yield return new WaitForSeconds(7);
		Destroy (rawImage);
	}
}
