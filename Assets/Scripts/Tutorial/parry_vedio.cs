﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class parry_vedio : MonoBehaviour {

	public MovieTexture movie;
	public RawImage rawImage;

	// Use this for initialization
	void Start () {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			Destroy (rawImage);
			Handheld.PlayFullScreenMovie ("Parry.mp4");
		} else {
			GetComponent<RawImage> ().texture = movie as MovieTexture;
			movie.Play ();
			StartCoroutine(endMovie());
		}
	}

	// Update is called once per frame
	void Update () {
	}

	IEnumerator endMovie() {		
		yield return new WaitForSeconds(3.8f);
		Destroy (rawImage);
	}
}
