using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
    private Image iPanel;
    private bool bFade = false;
    private bool bSolidify = false;
    // Start is called before the first frame update
    void Start()
    {
        iPanel = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bFade == true)
        {
            fading();
        }

        if (bSolidify == true)
        {
            solidifying();
        }
    }

    //Player calls object to turn item transparent
    public void startFade()
    {
        bFade = true;
        bSolidify = false;
        Debug.Log("Fade");
    }

    //Player calls this object to turn item solid
    public void startSolidify()
    {
        bSolidify = true;
        bFade = false;
    }

    private void fading()
    {
        iPanel.Color = new Color(iPanel.Color.r, iPanel.Color.b, iPanel.g, iPanel.Color.a + 0.1 * Time.deltaTime);
    }

    private void solidifying()
    {

    }
}
