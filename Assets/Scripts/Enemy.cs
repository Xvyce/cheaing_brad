﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float rotationSpeed;
    public float distance;

    public LineRenderer lineOfSight;
    public Gradient redColor;
    public Gradient greenColor;


    void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
        if(hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            lineOfSight.SetPosition(1, hitInfo.point);
            lineOfSight.colorGradient = redColor;
        } 
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
            lineOfSight.SetPosition(1, transform.position + transform.right * distance);
            lineOfSight.colorGradient = greenColor;
        }

        lineOfSight.SetPosition(0, transform.position);
    }
}
