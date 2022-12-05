using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UINickname : MonoBehaviour
{
    private Image bg;
    private Text txt;

    private Color originColor;

    private void Start()
    {
        bg = GetComponentInChildren<Image>();
        txt = GetComponentInChildren<Text>();

        originColor = bg.color;
    }

    public void SetName(string name)
    {
        txt.text = name;
    }

    public void SetColor(Color color)
    {
        bg.color = color;
    }

    public void ResetColor()
    {
        bg.color = originColor;
    }
}
