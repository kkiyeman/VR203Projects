using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextUi : MonoBehaviour
{
    public Text t;
    public Color c;

    void Start()
    {
        t.text = "³¢¿¡¿¡¿¡¾Æ¾Æ¾Æ¾Æ¾Ç";
        t.fontSize = 45;
        t.color = c;
        t.fontStyle = FontStyle.Bold;
        Debug.Log(t.text);
    }
}
