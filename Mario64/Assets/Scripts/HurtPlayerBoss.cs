﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayerBoss : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            HealthManager.instance.HurtByBoss();
            //Debug.Log("Trigger on box hurt");
        }
    }
}
