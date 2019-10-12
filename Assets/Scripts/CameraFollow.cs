﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate(){
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CameraMovement();
    }

    void CameraMovement(){
        if(transform.position != target.position){
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}