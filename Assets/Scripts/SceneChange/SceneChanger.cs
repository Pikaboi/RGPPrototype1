﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    //Get the scenes panel
    [SerializeField]
    public PanelControl goPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Check for a collision on a trigger
    void OnTriggerEnter(Collider other)
    {
        //Check which warp it is.
        if(other.tag == "warppoint")
        {
            //This lets us warp to any scene we want and transition to it smoothly
            //This comes in handy for later!
            goPanel.startSolidify(other.GetComponent<scenenum>().iSceneNum);
            //Application.LoadLevel(Application.loadedLevel + 1);
        }
    }
}