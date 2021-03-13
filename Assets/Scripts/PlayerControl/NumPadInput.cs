using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumPadInput : MonoBehaviour
{
    public InteractNumpad sActivator;
    private string sInput;
    public Text tTextBox;
    [SerializeField]
    private string sAnswer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tTextBox.text = sInput;

        if (tTextBox.text.Length > 4)
        {
            sInput = tTextBox.text.Substring(0, 4);
        }
    }

    public void add1()
    {
        sInput += '1';
    }

    public void add2()
    {
        sInput += '2';
    }

    public void add3()
    {
        sInput += '3';
    }

    public void add4()
    {
        sInput += '4';
    }

    public void add5()
    {
        sInput += '5';
    }

    public void add6()
    {
        sInput += '6';
    }

    public void add7()
    {
        sInput += '7';
    }

    public void add8()
    {
        sInput += '8';
    }
    public void add9()
    {
        sInput += '9';
    }
    public void add0()
    {
        sInput += '0';
    }

    public void Exit()
    {
        sInput = "";
        sActivator.Return();
    }

    public void Enter()
    {
        //it will do something once i set up a pass code
        if(sInput == sAnswer)
        {
            Debug.Log("yaya");
            sActivator.Deactivate();
        } else
        {
            sInput = "";
        }
    }
}
