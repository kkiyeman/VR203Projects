using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputToText : MonoBehaviour
{
    public Text t;
    public InputField ipf;
    public Color c;

    void Start()
    {
        t.text = "������Դϴ�..";
    }

    public void pressbutton()
    {
        t.text = ipf.text;
        t.color = c;
        t.fontSize = 55;
        t.fontStyle = FontStyle.Bold;
    }

}
