using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class teleport : MonoBehaviour
{

    public Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>().teleport(destination);

            foreach (GameObject v in (GameObject.FindGameObjectsWithTag("OpenableDoor")))
            {
                v.GetComponent<DoorOpen>().transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
                v.GetComponent<DoorOpen>().CloseDoor();
            }
        } 
    }
}
