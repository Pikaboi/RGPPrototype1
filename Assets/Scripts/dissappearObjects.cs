using System.Collections;
using System.Collections.Generic;
//using TreeEditor;
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
        
    }

    public void disable()
    {
        if (Passes % 2 == 0)
        {
            foreach (GameObject i in GameObject.FindGameObjectsWithTag("Teenage"))
            {

                {
                    i.GetComponent<MeshRenderer>().enabled = (false);
                }
            }

            foreach (GameObject i in GameObject.FindGameObjectsWithTag("Child"))
            {

                {
                    i.GetComponent<MeshRenderer>().enabled = (true);
                }
            }
        }

        if (Passes % 2 == 1)
        {
            foreach (GameObject i in GameObject.FindGameObjectsWithTag("Teenage"))
            {

                {
                    i.GetComponent<MeshRenderer>().enabled = true;
                }
            }

            foreach (GameObject i in GameObject.FindGameObjectsWithTag("Child"))
            {



                {
                    i.GetComponent<MeshRenderer>().enabled = (false);
                }
            }
        }
    }
}
