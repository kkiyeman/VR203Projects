using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class game : MonoBehaviour
{
    public Text log;
    public Text Fname;
    public Text FHP;
    public Text FLV;
    public Text MHP;
    public Text MLV;
    public Text Mname;

    public Color green;
    public Color red;
    public Color orange;

    public Image[] mypoke = new Image[6];
    public Image status;
    public Image bag;
    public Image Pokemon;
    public Image epkst;
    public Image mpkst;
    public Image machina;
    public Image enemy;

    public GameObject victory;
    public GameObject battletheme;
   

    public Image sinfo1;
    public Image sinfo2;
    public Image sinfo3;
    public Image sinfo4;

    public List<PokeList> ranpoke = new List<PokeList>();
    public List<PokeList> gopoke = new List<PokeList>();

    

    int pfhp;
    int fhp;
    int flv;
    string fname;
    int foenumber;

    int pmhp;
    int mhp;
    int mlv;
    string mname;

    string fpk;

    string mpk;

    




    void Start()
    {
        //��Ʋ ���� ����
        
        
        machina.gameObject.SetActive(true); //��Ȱ��ȭâ ����
        log.text = $"Ž����..";
        Invoke("Enemyappear", 3); //3�� �� �� ����
        Invoke("Mypokego", 6); //6�� �� ���̸� �⵿
        Invoke("WhatIdo", 8); //8�� �� ������ �ұ�? ���
        Invoke("Nomove", 8); //8�� �� ��Ȱ��ȭâ �ݱ�

        //Invoke("MonsterAttack" , 5);      
    }

    public void Enemyappear()
    {

        //�� ����
        int ran = Random.Range(0, 6);
        fpk = ranpoke[ran].poke;
        fhp = ranpoke[ran].hp;
        pfhp = ranpoke[ran].hp;
        flv = ranpoke[ran].level;
        fname = ranpoke[ran].poke;
        enemy = ranpoke[ran].shape;

        foenumber = ran;

        enemy.gameObject.SetActive(true);
        epkst.gameObject.SetActive(true);
        log.text = $"{fpk}(��)�� ��Ÿ����!";
        FHP.text = $"{fhp}";
        FLV.text = $"Lv.{flv}";
        Fname.text = fname;
        FHP.color = green;

    }


    public void Mypokego()
    {
        //�� ���ϸ� ����
        mpk = gopoke[0].poke;
        mhp = gopoke[0].hp;
        pmhp = gopoke[0].hp;
        mlv = gopoke[0].level;
        mname = gopoke[0].poke;
        mypoke[0].gameObject.SetActive(true);
        GameObject.Find("UIManager").GetComponent<UI>().Mskill_UIset(0);


        mpkst.gameObject.SetActive(true);
        log.text = $"����! {mpk}!";
        MHP.text = $"{mhp}";
        MLV.text = $"Lv.{mlv}";
        Mname.text = mname;
        MHP.color = green;
    }

    public void Mypokechange(int a)
    {
        if (mpk == gopoke[a].poke)
        {
            machina.gameObject.SetActive(true);
            log.text = $"{mpk}�� �̹� �����ֽ��ϴ�!";
            Invoke("SwitchPoke", 2);
            Invoke("Nomove", 2);
        }
        else
        {
            mpk = gopoke[a].poke;
            mpk = gopoke[a].poke;
            mhp = gopoke[a].hp;
            pmhp = gopoke[a].hp;
            mlv = gopoke[a].level;
            mname = gopoke[a].poke;

            GameObject.Find("UIManager").GetComponent<UI>().Mskill_UIset(a);


            log.text = $"����! {mpk}!";
            MHP.text = $"{mhp}";
            MLV.text = $"Lv.{mlv}";
            Mname.text = mname;
            MHP.color = green;

            ClosePokelist();
        }
        for (int i = 0; i < 6; i++)
        {
            if(i==a)
            {
                mypoke[i].gameObject.SetActive(true);
            }
            else
            {
                mypoke[i].gameObject.SetActive(false);
            }
        }

    }

 

    public void WhatIdo()
    {
        //�������ұ� ���
        log.text = $"������ �ұ�?";
    }



    public void Fight()
    {
        //�ο�� ������ ��
        log.text = $"���� ����!";
        status.gameObject.SetActive(true);
    }

    public void Bag()
    {
        //���� ������ ��
        log.text = $"����� �������� ������";
        bag.gameObject.SetActive(true);
    }

    public void SwitchPoke()
    {
        //���ϸ� ��ü ������ ��
        log.text = $"��ü�� ���ϸ��� ������";
        Pokemon.gameObject.SetActive(true);
    }

    public void Run()
    {
        //���� ������ ��
        log.text = $"���������� �����ƴ�!";

        machina.gameObject.SetActive(true);
        Invoke("Restart", 3);
    }


    public void ItemUse(string item)
    {
        //������ ����
        log.text = $"{item}��(��) ����� �� �����ϴ�.";
    }



    public void Closebag()
    {
        //���� �ݱ�
        log.text = $"������ �ұ�?";
        bag.gameObject.SetActive(false);
    }



    public void Selectpoke()
    {
        //���ϸ� ���� Ŭ����
        log.text = $"{mpk}��(��) �̹� �������Դϴ�.";
    }



    public void ClosePokelist()
    {
        //���ϸ�â ������
        log.text = $"������ �ұ�?";
        Pokemon.gameObject.SetActive(false);
    }



    //public void Skillinfo(int snumber)
    //{
    //    switch(snumber)
    //    {   
    //        case 1:
    //            sinfo1.gameObject.SetActive(true);
    //            break;
    //        case 2:
    //            sinfo2.gameObject.SetActive(true);
    //            break;
    //        case 3:
    //            sinfo3.gameObject.SetActive(true);
    //            break;
    //        case 4:
    //            sinfo4.gameObject.SetActive(true);
    //            break;
    //    }
    //}

    //public void SkillinfoX(int snumber)
    //{
    //    switch (snumber)
    //    {
    //        case 1:
    //            sinfo1.gameObject.SetActive(false);
    //            break;
    //        case 2:
    //            sinfo2.gameObject.SetActive(false);
    //            break;
    //        case 3:
    //            sinfo3.gameObject.SetActive(false);
    //            break;
    //        case 4:
    //            sinfo4.gameObject.SetActive(false);
    //            break;
    //    }
    //}




    public void Skilluse(int dmg)//������
    {
        
        //�� ��ų��ư Ŭ���� �Լ�
        int fhp1 = fhp;
        fhp = fhp - dmg;

        if(fhp1<=0)
        {
            //���� �������µ� �����Ϸ��� �Ҷ�
            FHP.text = "0";
            log.text = "������ ����� �����ϴ�!";
            fhp = 0;
        }
        else if (fhp > 0)
        {
            //���� �� ���� ������� ��
            machina.gameObject.SetActive(true); //��Ȱ��ȭâ ����
            FHP.text = fhp.ToString();
            log.text = $"{mpk}�� {fpk}���� {dmg}�� �������� ������!";
            //if (fhp1 - 100 >= fhp)                //���� ü���� 100 �̻� ����� ��
            //{
            //    Invoke("Recoil", 1.5f); //�ݵ������� �� �α� ���
            //}
            Invoke("MonsterAttack", 3); //3�� �� �� ����
            Invoke("Nomove", 3); //3�� �� ��Ȱ��ȭâ �ݱ�
        }
        else
        {
            //���� �� ���� �������� ��
            //if (fhp1 - 100 >= fhp)                //���� ü���� 100 �̻� ����� ��
            //{
            //    Invoke("Recoil", 1.5f); //�ݵ������� �� �α� ���
            //}
            FHP.text = "0";
            fhp = 0;
            enemy.gameObject.SetActive(false);
            machina.gameObject.SetActive(true);

            Invoke("Victoryes", 3);
            Invoke("Victoryoff", 6);
            Invoke("Restart", 6); //3���� ��ü�����
            Invoke("Nomove", 6); //3���� ��Ȱ��ȭâ �ݱ�
        }


        //hp��»���
        hpcolor();


    }


    private void Victoryes()
    {
        victory.gameObject.SetActive(true);
        log.text = $"{fpk}�� ��������! �¸��Ͽ����ϴ�!";
    }


    private void Victoryoff()
    {
        victory.gameObject.SetActive(false);
    }

    private void Recoil()
    {
        //�ݵ� ������ ����(30)
        mhp = mhp - 30;
        MHP.text = mhp.ToString();
        log.text = $"{mpk}�� 30�� �ݵ��������� �Ծ���.";
    }

    public void Cancelfight()
    {
        //�ο��-�ݱ��ư��
        status.gameObject.SetActive(false);
        log.text = $"������ �ұ�?";
    }

    public void Nomove()
    {
        //��Ȱ��ȭâ ����
        machina.gameObject.SetActive(false);
    }


    void MonsterAttack()
    {
        //���� ����
        int foeattack = mhp;
        mhp = mhp - 50;

        if (mhp > 0)
        {
            //������ ���� ���� ������� ��
            MHP.text = mhp.ToString();
            log.text = $"{fpk}�� ����! 50�� �������� �Ծ���";
        }
        else
        {
            //������ ���� ���� �������� ��
            machina.gameObject.SetActive(true);
            MHP.text = "0";
            log.text = $"{mpk}�� ��������..";
            Invoke("Nomove", 5);
            Invoke("Restart", 5);
        }

        //hp ������
        hpcolor();

    }

    void hpcolor()
    {
        //hp �ܷ��� ���� hp�� ������ ���赵 ǥ��

        int myhp = int.Parse(MHP.text); //�� ü��
        int ehp = int.Parse(FHP.text); //�� ü��

        int checkmhp = (pmhp * 2 / 3); //��ü�� 66%����
        int checkmhp2 = (pmhp / 3); //��ü�� 33%����
        int checkfhp = (pfhp * 2 / 3); //��ü�� 66%����
        int checkfhp2 = (pfhp / 3); //��ü�� 33%����

        if (myhp > checkmhp)
        {
            //hp�ܷ��� 3���� 2 �̻�
            MHP.text = mhp.ToString();
            MHP.color = green;
        }
        else if (checkmhp >= myhp && myhp > checkmhp2)
        {
            //hp �ܷ��� 3����2 ���� 3���� 1 �̻�
            MHP.text = mhp.ToString();
            MHP.color = orange;
        }
        else
        {
            //hp �ܷ��� 3���� 1 ����
            MHP.text = mhp.ToString();
            MHP.color = red;;
        }

        if (ehp > checkfhp)
        {
            //hp�ܷ��� 3���� 2 �̻�
            FHP.text = fhp.ToString();
            FHP.color = green;
        }
        else if (checkfhp >= ehp && ehp > checkfhp2)
        {
            //hp �ܷ��� 3����2 ���� 3���� 1 �̻�
            FHP.text = fhp.ToString();
            FHP.color = orange;
        }
        else if (ehp <= checkfhp2 && ehp >= 0)
        {
            //hp �ܷ��� 3���� 1 ����
            FHP.text = fhp.ToString();
            FHP.color = red;
        }
        else
        {
            //hp�� 0
            FHP.text = "0";
            FHP.color = red;
        }
    }


    private void Restart()
    {
        //��ü �����(Ž������ ����)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Setenemy()
    { 

    }
}
