﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPowerup : BasePowerUp {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other) {
        Ball ball = other.GetComponent<Ball>();
        if(ball != null) {
            BallController.CurrentBallCount++;
            SoundManager.Instance.PlayBallPowerup();
        }
        Destroy(gameObject);
    }
}
