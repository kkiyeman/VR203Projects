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
        //배틀 시작 설정
        
        
        machina.gameObject.SetActive(true); //비활성화창 열기
        log.text = $"탐색중..";
        Invoke("Enemyappear", 3); //3초 후 적 출현
        Invoke("Mypokego", 6); //6초 후 파이리 출동
        Invoke("WhatIdo", 8); //8초 후 무엇을 할까? 출력
        Invoke("Nomove", 8); //8초 후 비활성화창 닫기

        //Invoke("MonsterAttack" , 5);      
    }

    public void Enemyappear()
    {

        //적 출현
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
        log.text = $"{fpk}(이)가 나타났다!";
        FHP.text = $"{fhp}";
        FLV.text = $"Lv.{flv}";
        Fname.text = fname;
        FHP.color = green;

    }


    public void Mypokego()
    {
        //내 포켓몬 출전
        mpk = gopoke[0].poke;
        mhp = gopoke[0].hp;
        pmhp = gopoke[0].hp;
        mlv = gopoke[0].level;
        mname = gopoke[0].poke;
        mypoke[0].gameObject.SetActive(true);
        GameObject.Find("UIManager").GetComponent<UI>().Mskill_UIset(0);


        mpkst.gameObject.SetActive(true);
        log.text = $"가랏! {mpk}!";
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
            log.text = $"{mpk}는 이미 나가있습니다!";
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


            log.text = $"가랏! {mpk}!";
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
        //무엇을할까 출력
        log.text = $"무엇을 할까?";
    }



    public void Fight()
    {
        //싸우다 눌렀을 시
        log.text = $"전투 시작!";
        status.gameObject.SetActive(true);
    }

    public void Bag()
    {
        //가방 눌렀을 시
        log.text = $"사용할 아이템을 고르세요";
        bag.gameObject.SetActive(true);
    }

    public void SwitchPoke()
    {
        //포켓몬 교체 눌렀을 시
        log.text = $"교체할 포켓몬을 고르세요";
        Pokemon.gameObject.SetActive(true);
    }

    public void Run()
    {
        //도망 눌렀을 시
        log.text = $"성공적으로 도망쳤다!";

        machina.gameObject.SetActive(true);
        Invoke("Restart", 3);
    }


    public void ItemUse(string item)
    {
        //아이템 사용시
        log.text = $"{item}은(는) 사용할 수 없습니다.";
    }



    public void Closebag()
    {
        //가방 닫기
        log.text = $"무엇을 할까?";
        bag.gameObject.SetActive(false);
    }



    public void Selectpoke()
    {
        //포켓몬 출전 클릭시
        log.text = $"{mpk}은(는) 이미 출전중입니다.";
    }



    public void ClosePokelist()
    {
        //포켓몬창 닫을시
        log.text = $"무엇을 할까?";
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




    public void Skilluse(int dmg)//데미지
    {
        
        //각 스킬버튼 클릭시 함수
        int fhp1 = fhp;
        fhp = fhp - dmg;

        if(fhp1<=0)
        {
            //적이 쓰러졌는데 공격하려고 할때
            FHP.text = "0";
            log.text = "공격할 대상이 없습니다!";
            fhp = 0;
        }
        else if (fhp > 0)
        {
            //공격 후 적이 살아있을 때
            machina.gameObject.SetActive(true); //비활성화창 열기
            FHP.text = fhp.ToString();
            log.text = $"{mpk}가 {fpk}에게 {dmg}의 데미지를 입혔다!";
            //if (fhp1 - 100 >= fhp)                //적의 체력이 100 이상 닳았을 때
            //{
            //    Invoke("Recoil", 1.5f); //반동데미지 및 로그 출력
            //}
            Invoke("MonsterAttack", 3); //3초 후 적 공격
            Invoke("Nomove", 3); //3초 후 비활성화창 닫기
        }
        else
        {
            //공격 후 적이 쓰러졌을 때
            //if (fhp1 - 100 >= fhp)                //적의 체력이 100 이상 닳았을 때
            //{
            //    Invoke("Recoil", 1.5f); //반동데미지 및 로그 출력
            //}
            FHP.text = "0";
            fhp = 0;
            enemy.gameObject.SetActive(false);
            machina.gameObject.SetActive(true);

            Invoke("Victoryes", 3);
            Invoke("Victoryoff", 6);
            Invoke("Restart", 6); //3초후 전체재시작
            Invoke("Nomove", 6); //3초후 비활성화창 닫기
        }


        //hp출력색깔
        hpcolor();


    }


    private void Victoryes()
    {
        victory.gameObject.SetActive(true);
        log.text = $"{fpk}는 쓰러졌다! 승리하였습니다!";
    }


    private void Victoryoff()
    {
        victory.gameObject.SetActive(false);
    }

    private void Recoil()
    {
        //반동 데미지 설정(30)
        mhp = mhp - 30;
        MHP.text = mhp.ToString();
        log.text = $"{mpk}는 30의 반동데미지를 입었다.";
    }

    public void Cancelfight()
    {
        //싸우다-닫기버튼용
        status.gameObject.SetActive(false);
        log.text = $"무엇을 할까?";
    }

    public void Nomove()
    {
        //비활성화창 끄기
        machina.gameObject.SetActive(false);
    }


    void MonsterAttack()
    {
        //적의 공격
        int foeattack = mhp;
        mhp = mhp - 50;

        if (mhp > 0)
        {
            //적공격 이후 아직 살아있을 때
            MHP.text = mhp.ToString();
            log.text = $"{fpk}의 공격! 50의 데미지를 입었다";
        }
        else
        {
            //적공격 이후 내가 쓰러졌을 때
            machina.gameObject.SetActive(true);
            MHP.text = "0";
            log.text = $"{mpk}는 쓰러졌다..";
            Invoke("Nomove", 5);
            Invoke("Restart", 5);
        }

        //hp 색깔설정
        hpcolor();

    }

    void hpcolor()
    {
        //hp 잔량에 따라 hp의 색으로 위험도 표현

        int myhp = int.Parse(MHP.text); //내 체력
        int ehp = int.Parse(FHP.text); //적 체력

        int checkmhp = (pmhp * 2 / 3); //내체력 66%기준
        int checkmhp2 = (pmhp / 3); //내체력 33%기준
        int checkfhp = (pfhp * 2 / 3); //적체력 66%기준
        int checkfhp2 = (pfhp / 3); //적체력 33%기준

        if (myhp > checkmhp)
        {
            //hp잔량이 3분의 2 이상
            MHP.text = mhp.ToString();
            MHP.color = green;
        }
        else if (checkmhp >= myhp && myhp > checkmhp2)
        {
            //hp 잔량이 3분의2 이하 3분의 1 이상
            MHP.text = mhp.ToString();
            MHP.color = orange;
        }
        else
        {
            //hp 잔량이 3분의 1 이하
            MHP.text = mhp.ToString();
            MHP.color = red;;
        }

        if (ehp > checkfhp)
        {
            //hp잔량이 3분의 2 이상
            FHP.text = fhp.ToString();
            FHP.color = green;
        }
        else if (checkfhp >= ehp && ehp > checkfhp2)
        {
            //hp 잔량이 3분의2 이하 3분의 1 이상
            FHP.text = fhp.ToString();
            FHP.color = orange;
        }
        else if (ehp <= checkfhp2 && ehp >= 0)
        {
            //hp 잔량이 3분의 1 이하
            FHP.text = fhp.ToString();
            FHP.color = red;
        }
        else
        {
            //hp가 0
            FHP.text = "0";
            FHP.color = red;
        }
    }


    private void Restart()
    {
        //전체 재시작(탐색부터 시작)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Setenemy()
    { 

    }
}
