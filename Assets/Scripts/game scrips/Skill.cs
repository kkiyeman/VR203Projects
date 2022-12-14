using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour
{



    private Type type;
    private int[] pp = { 5, 10, 15, 20, 25, 30 };

    private int recoil;
    private string info;
    private Image effect;

    
    public string[,] esname = new string[6, 4]
    {{"전광석화","전기자석파","아이언테일","10만볼트"},//피카츄기술
     {"몸통박치기","바람일으키기","쪼기","모래뿌리기"}, //구구기술
     {"몸통박치기","꼬리흔들기","필살앞니","분노의 앞니"}, //꼬렛기술
     {"쪼기","모래뿌리기","째려보기","드릴부리"}, //깨비참기술
     {"독침","조이기","오물공격","뱀눈초리"}, //아보기술
     {"몸통박치기","실뿜기","흡수","벌레의 웅성거림"}, //캐터피기술
     };

    public string[,] msname = new string[6, 4]
    {
     {"할퀴기","불꽃세례","지구던지기","화염방사"}, //파이리기술
     {"몸통박치기","덩굴채찍","잎날가르기","솔라빔"}, //이상해씨기술
     {"몸통박치기","물대포","고속스핀","하이드로펌프"}, //꼬부기기술
     {"몸통박치기","돌떨구기","모래뿌리기","매그니튜드"}, //꼬마돌기술
     {"몸통박치기","독침","모래뿌리기","두번치기"}, //니드런기술
     {"소닉붐","초음파","10만볼트","러스터캐논"}, //코일기술
    };

    public int[,] esdmg = new int[6, 4]
    {   {40,30,60,80},
        {35,50,40,20},
        {35,10,50,80},
        {40,20,10,80},
        {40,30,50,20},
        {35,20,30,50},
    };

    public int[,] msdmg = new int[6, 4]
   {   
        {40,50,60,100},
        {35,50,55,110},
        {35,50,20,110},
        {35,50,20,80},
        {35,35,20,90},
        {45,30,80,95},

   };

    public string[,] esinfo = new string[6, 4]
    {
        {   
            "눈에 보이지 않는 굉장한 속도로 상대에게 돌진한다",
            "약한 전격을 날려서 적을 공격한다",
            "단단한 꼬리로 상대를 힘껏 쳐서 공격한다",
            "강한 전격을 상대에게 날려서 공격한다"
        },
        {
            "상대를 향해서 몸 전체를 부딪쳐가며 공격한다",
            "강한 바람을 일으켜서 공격한다",
            "날카롭고 뾰족한 부리나 뿔로 상대를 쪼아서 공격한다",
            "적의 얼굴을 향해 모래를 뿌려 공격한다"
        },
        {
            "상대를 향해서 몸 전체를 부딪쳐가며 공격한다",
            "꼬리를 좌우로 귀엽게 흔들어 방심을 유도한 뒤 공격한다",
            "날카로운 이빨로 상대를 물어서 공격한다",
            "이빨에 분노를 담아 적을 강하게 문다"
        },
        {
            "날카롭고 뾰족한 부리나 뿔로 상대를 쪼아서 공격한다",
            "적의 얼굴을 향해 모래를 뿌려 공격한다",
            "날카로운 눈초리로 겁을 주어 상대를 공격한다",
            "뾰족한 부리를 회전시켜 힘을 더해 적을 공격한다"
        },
        {
            "독을 머금은 이빨이나 뿔로 적을 찔러 공격한다",
            "긴 몸이나 덩굴을 써서 상대를 조여 공격한다",
            "적에게 더러운 오물을 날려 공격한다",
            "적을 무늬나 날카로운 눈초리로 겁을 줘서 공격한다"
        },
        {
            "상대를 향해서 몸 전체를 부딪쳐가며 공격한다",
            "입에서 실을 뿜어서 적을 칭칭 감아 공격한다",
            "적을 물어서 체액을 흡수하여 공격한다",
            "적에게 벌레 특유의 웅웅거리는 소리를 내어 공격한다"
        }
        
    };

    public string[,] msinfo = new string[6, 4]
    {
        {
            "날카로운 발톱으로 할퀸다",
            "약한 불꽃을 날려서 적을 공격한다",
            "적을 지구를 날려버릴 기세로 던져서 공격한다",
            "세찬 불꽃을 상대에게 발사해서 공격한다"
        },
        {
            "상대를 향해서 몸 전체를 부딪쳐가며 공격한다",
            "긴 덩굴을 적에게 채찍처럼 휘둘러서 공격한다",
            "끝이 날카로운 풀잎들을 적에게 날려서 공격한다",
            "태양의 힘을 모아 적에게 쏘아서 공격한다"
        },
        {
            "상대를 향해서 몸 전체를 부딪쳐가며 공격한다",
            "물을 기세 좋게 상대에게 발사하여 공격한다",
            "몸을 고속으로 회전시켜 적에게 부딪혀 공격한다",
            "대량의 물을 세찬 기세로 상대에게 발사하여 공격한다"
        },
        {
            "상대를 향해서 몸 전체를 부딪쳐가며 공격한다",
            "적에게 작은 바위들을 날려 공격한다",
            "적의 얼굴을 향해 모래를 뿌려 공격한다",
            "강한 힘으로 지면을 흔들어 적을 공격한다"
        },
        {
            "상대를 향해서 몸 전체를 부딪쳐가며 공격한다",
            "독을 머금은 이빨이나 뿔로 적을 찔러 공격한다",
            "적의 얼굴을 향해 모래를 뿌려 공격한다",
            "앞발을 이용해 적을 강하게 두번 쳐서 공격한다"
        },
        {
            "적에게 충격파를 날려서 공격한다",
            "강한 음파로 적을 혼란시켜서 공격한다",
            "강한 전격을 상대에게 날려서 공격한다",
            "몸의 빛을 한곳에 모아서 힘을 방출한다"
        }
    };




    private void dmgSet()
    {
        
    }

}
