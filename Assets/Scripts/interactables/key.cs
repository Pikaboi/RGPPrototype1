using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float timer = 0;
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        
        if(camera.isActiveAndEnabled && timer <=0f)
        {
            camera.gameObject.SetActive(false);
        }
        
        if(GetComponent<resultant>().execute)
        {
            camera.gameObject.SetActive(true);
            
            timer = 1.4f;

            GetComponent<resultant>().execute = false;
            GetComponent<Animator>().SetBool("cam", true);
        }
    }
}
