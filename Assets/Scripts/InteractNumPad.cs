using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractNumPad : MonoBehaviour
{
    public GameObject goPadlock;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        goPadlock.SetActive(false);
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            goPadlock.SetActive(true);

            other.GetComponent<playerMovement>().enabled = false;
            cam.GetComponent<mouseLook>().enabled = false;
        }
    }
}
