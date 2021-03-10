using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelControl : MonoBehaviour
{
    private Image iPanel;
    private bool bFade = false;
    private bool bSolidify = false;
    private int iSceneCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        iPanel = GetComponent<Image>();
        startFade();
    }

    // Update is called once per frame
    void Update()
    {
        //Check if we are fading into a scene
        if (bFade == true)
        {
            //Call the fade function
            fading();
            //Check if its done fading
            if(iPanel.color.a == 0.0f)
            {
                bFade = false;
            }
        }

        //Check if we are fading out of a scene
        if (bSolidify == true)
        {
            //Call the Solidify function
            solidifying();
            Debug.Log(iPanel.color.a);
            //If the fade is fully visible
            if (iPanel.color.a == 1.0f)
            {
                //Change the Scene
                SceneManager.LoadScene(iSceneCount);
            }
        }
    }

    //Player calls object to turn item transparent
    public void startFade()
    {
        bFade = true;
        bSolidify = false;
    }

    //Player calls this object to turn item solid
    public void startSolidify(int iSceneNum)
    {
        bSolidify = true;
        bFade = false;
        iSceneCount = iSceneNum;
    }

    private void fading()
    {
        //Set the color to fade based on time
        //We use clamp at 0 and 1 as transparency only deals with numbers than 0 and 1
        iPanel.color = new Color(iPanel.color.r, iPanel.color.b, iPanel.color.g, Mathf.Clamp(iPanel.color.a - 0.2f * Time.deltaTime, 0.0f, 1.0f));
    }

    private void solidifying()
    {
        //Set the color to fade based on time
        //We use clamp at 0 and 1 as transparency only deals with 0 to 1
        iPanel.color = new Color(iPanel.color.r, iPanel.color.b, iPanel.color.g, Mathf.Clamp(iPanel.color.a + 0.2f * Time.deltaTime, 0.0f, 1.0f));
    }
}
