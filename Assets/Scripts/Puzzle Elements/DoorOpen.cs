using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private bool isOpening = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isOpening == true)
        {
            gameObject.transform.Rotate(0.0f, 0.5f, 0.0f, Space.Self);
        }

        Debug.Log(gameObject.transform.rotation.eulerAngles.y);

        if(gameObject.transform.rotation.eulerAngles.y >= 90.0f)
        {
            isOpening = false;
        }
    }

    public void OpenDoor()
    {
        isOpening = true;
    }
}
