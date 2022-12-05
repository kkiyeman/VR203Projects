using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Image EStatus;
    public Image EImage;
    public Image MStatus;
    public Image MImage;
    public Image MainLog;
    public Image MainUI;
    public Image FightUI;
        public Image Skill1;
        public Image Skill2;
        public Image Skill3;
        public Image Skill4;
    public Image BagUI;
    public Image SwitchUI;
    public Image RunUI;

    public Skill skill;


    public Text EHP;
    public Text ELV;
    public Text ENM;
    public Text MHP;
    public Text MLV;
    public Text MNM;
    public Text S1;
        public Text S1nm;
        public Text S1info;
        public Text S1type;
    public Text S2;
        public Text S2nm;
        public Text S2info;
        public Text S2type;
    public Text S3;
        public Text S3nm;
        public Text S3info;
        public Text S3type;
    public Text S4;
        public Text S4nm;
        public Text S4info;
        public Text S4type;
    public Text Log;

    public string enm;
    public int ehp;
    public int elv;

    public string mnm;
    public int mhp;
    public int mlv;
 



    void Start()
    {
        
    }


    public void Popup(Image a)
    {
        a.gameObject.SetActive(true);
    }

    public void Popoff(Image a)
    {
        a.gameObject.SetActive(false);
    }

    public void Estatus_UIset()
    {
        ENM.text = enm;
        EHP.text = ehp.ToString();
        ELV.text = elv.ToString();
    }

    public void Mstatus_UIset()
    {
        MNM.text = mnm;
        MHP.text = mhp.ToString();
        MLV.text = mlv.ToString();
    }

    public void Mskill_UIset(int a)
    {
        skill = GameObject.Find("SkillList").GetComponent<Skill>();
        S1.text = skill.msname[a, 0];
        S2.text = skill.msname[a, 1];
        S3.text = skill.msname[a, 2];
        S4.text = skill.msname[a, 3];
    }
    
    public void Mypoke_Image(int a)
    {

    }
}



