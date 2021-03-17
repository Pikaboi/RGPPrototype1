using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addTags : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform t in gameObject.GetComponentInChildren<Transform>())
        {
            
            t.gameObject.tag = gameObject.tag;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
