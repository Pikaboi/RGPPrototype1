﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeFixed : MonoBehaviour
{

    

    public void OnTriggerEnter(Collider other)
    {
        //Check which warp it is.
        if (other.tag == "warppoint")
        {
            Debug.Log("WTF");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
