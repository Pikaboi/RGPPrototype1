using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public Camera camera;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (camera.gameObject.activeSelf && timer <= 0f)
            camera.gameObject.SetActive(false);
        if(GetComponent<resultant>().execute)
        {
            GetComponent<resultant>().execute = false;

            
                //Run animator 
                    GetComponent<Animator>().SetBool("open", true);
                    runCam(5f);
                
            

        }
    }


    void runCam(float time)
    {
        camera.gameObject.SetActive(true);
        timer = time;
    }
}
