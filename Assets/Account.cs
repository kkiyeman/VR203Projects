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

    string Username = "박용준";
    int money = 0;


    void Start()
    {
        ntxt.text = $"{Username}님의 계좌입니다";
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
        rtxt.text = $"{int.Parse(add.text)}원 입금했습니다!";
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
            rtxt.text = $"{int.Parse(subtract.text)}원 출금했습니다!";
        }
        else if (rich <= 0 && poor > 0)
        {

            W_font();
            rtxt.text = $"출금할 돈이 없습니다!!!";
        }
        else
        {
            rtxt.text = $"{rich}원 출금했습니다!";
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
