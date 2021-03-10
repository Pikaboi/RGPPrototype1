using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractibleHint : MonoBehaviour
{
    public Image buttonPrompt;
    // Start is called before the first frame update
    void Start()
    {
        buttonPrompt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            buttonPrompt.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            buttonPrompt.enabled = false;
        }
    }
}
