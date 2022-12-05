using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class market : MonoBehaviour
{

    public Image soundon;
    public Image sound2on;

    void Start()
    {
        
    }


    void Trumpet(int star)
    {
        for (int i = 1; i <= star; i++)
        {
            soundon.gameObject.SetActive(true);
            Invoke("sound1of", 4*i);
        }
        
    }
    void Sound2on()
    {
        sound2on.gameObject.SetActive(true);
    }
    void Sound2off()
    {
        sound2on.gameObject.SetActive(false);
    }
    void sound1of()
    {
        soundon.gameObject.SetActive(false);
    }

    void Sound1on(int star)
    {
        for (int i = 1; i <= star; i++)
        {
            soundon.gameObject.SetActive(true);
            Invoke("sound1of", 4);
        }
    }

}
