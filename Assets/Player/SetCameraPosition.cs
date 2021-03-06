﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SetCameraPosition : MonoBehaviour {
    [SerializeField] Transform player;
    [SerializeField] Vector3 offset;
    [SerializeField] bool consistentHeight;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 pos = player.position + offset;
        if(consistentHeight)
            pos.y = offset.y;
        transform.position = pos;
    }
}
