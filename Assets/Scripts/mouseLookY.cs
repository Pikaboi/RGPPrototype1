using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLookY : MonoBehaviour
{

    public float mouseSensitivity;
    public Transform playerBody;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
       
        if(gameObject.tag == "Player")
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        playerBody.Rotate(Vector3.up * mouseX);
        //transform.Rotate(Quaternion.Euler(xRotation, 0f, 0f);
    }
}
