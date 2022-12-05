using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Account : MonoBehaviour
{
    public Text ntxt;
    public Text atxt;
    public Text rtxt;
    public InputField add;
    public InputField subtract;

    public Color red;
    public Color white;

    string Username = "�ڿ���";
    int money = 0;


    void Start()
    {
        ntxt.text = $"{Username}���� �����Դϴ�";
        atxt.text = $"{money}";
        rtxt.text = "Waiting...";
        Defaultfont();
        add.text = "";
        subtract.text = "";
    }

    public void deposit()
    {
        money = int.Parse(atxt.text) + int.Parse(add.text);
        atxt.text = $"{money.ToString()}";
        rtxt.text = $"{int.Parse(add.text)}�� �Ա��߽��ϴ�!";
        Defaultfont();
        subtract.text = "";
    }

    public void withdraw()
    {
        int rich = int.Parse(atxt.text);
        int poor = int.Parse(subtract.text);
        money = rich - poor;
        Defaultfont();
        if (money >= 0 && rich > 0)
        {
            atxt.text = $"{money.ToString()}";
            rtxt.text = $"{int.Parse(subtract.text)}�� ����߽��ϴ�!";
        }
        else if (rich <= 0 && poor > 0)
        {

            W_font();
            rtxt.text = $"����� ���� �����ϴ�!!!";
        }
        else
        {
            rtxt.text = $"{rich}�� ����߽��ϴ�!";
            atxt.text = "0";
        }
        add.text = "";
    }

    void Defaultfont()
    {
        rtxt.fontSize = 45;
        rtxt.fontStyle = FontStyle.Normal;
        rtxt.color = white;
    }

    void W_font()
    {
        rtxt.color = red;
        rtxt.fontStyle = FontStyle.Bold;
        rtxt.fontSize = 70;
    }
    void Update()
    {

    }
}
