﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotAudioScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Destroy", gameObject.GetComponent<AudioSource>().clip.length);
	}
	
	// Update is called once per frame
	void Destroy() {
        Destroy(gameObject);
	}
}
