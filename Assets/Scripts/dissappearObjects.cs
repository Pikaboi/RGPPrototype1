using System.Collections;
using System.Collections.Generic;
//using TreeEditor;
using UnityEngine;

public class dissappearObjects : MonoBehaviour
{


    public int Passes = 0;
    private int dissappeared = 0;
    public GameObject teenage;
    public GameObject child;
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

            teenage.SetActive(false);
            //foreach (GameObject i in GameObject.FindGameObjectsWithTag("Teenage"))
            //{

            //    MeshRenderer m = null;

            //    i.TryGetComponent<MeshRenderer>(out m);
            //    if (m != null)
            //        m.enabled = (false);
            //    else
            //        if (m.GetComponentInChildren<MeshRenderer>() != null)
            //        m.GetComponentInChildren<MeshRenderer>().enabled = false;

            //}

            child.SetActive(true);

            //foreach (GameObject i in GameObject.FindGameObjectsWithTag("Child"))
            //{

            //    gameObject.hideFlags = HideFlags.None;

            //    MeshRenderer m = null;

            //    i.TryGetComponent<MeshRenderer>(out m);
            //    if (m != null)
            //        m.enabled = (true);
            //    else
            //        if (m.GetComponentInChildren<MeshRenderer>() != null)
            //        m.GetComponentInChildren<MeshRenderer>().enabled = true;
            //}
        }

        if (Passes % 2 == 1)
        {
            teenage.SetActive(true);
            child.SetActive(false);
            //foreach (GameObject i in GameObject.FindGameObjectsWithTag("Teenage"))
            //{

            //    MeshRenderer m = null;

            //    i.TryGetComponent<MeshRenderer>(out m);
            //    if (m != null)
            //        m.enabled = (true);
            //    else
            //        if (m.GetComponentInChildren<MeshRenderer>() != null)
            //        m.GetComponentInChildren<MeshRenderer>().enabled = true;
            //}

            //foreach (GameObject i in GameObject.FindGameObjectsWithTag("Child"))
            //{


            //    MeshRenderer m = null;

            //    i.TryGetComponent<MeshRenderer>(out m);
            //    if(m!=null)
            //      m.enabled = (false);
            //    else
            //        if(m.GetComponentInChildren<MeshRenderer>()!=null)
            //        m.GetComponentInChildren<MeshRenderer>().enabled = false;
            //}
        }
    }
}
