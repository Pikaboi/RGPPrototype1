using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HueControl : MonoBehaviour
{
    Color newColor;
    // Start is called before the first frame update
    void Start()
    {
        //get the objects material renderer
        var rCubeRenderer = GetComponent<Renderer>();
        //Make a Colour
        newColor = Color.gray;
        //Set the Colour
        rCubeRenderer.material.SetColor("_Color", newColor);
    }

    // Update is called once per frame
    void Update()
    {
        var rCubeRenderer = GetComponent<Renderer>();
        newColor = new Color(newColor.r + 0.1f * Time.deltaTime, newColor.b + 0.1f * Time.deltaTime, newColor.g + 0.1f * Time.deltaTime, newColor.a);
        rCubeRenderer.material.SetColor("_Color", newColor);
    }
}
