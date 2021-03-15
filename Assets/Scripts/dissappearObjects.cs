using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class dissappearObjects : MonoBehaviour
{


    public int Passes = 0;
    private int dissappeared = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Passes > dissappeared)
        {
            foreach (GameObject i in GameObject.FindGameObjectsWithTag("Dissappearing"))
            {
                if (!i.activeSelf)
                    continue;
                else
                {
                    dissappeared++;
                    i.SetActive(false);
                    break;
                }
            }
        }
    }
}
