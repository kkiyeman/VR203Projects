using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCharacter : MonoBehaviour
{
    public UINickname uiNickname;

    public string characterName;
    public float speed = 10;
    
    void Start()
    {
        uiNickname = GetComponentInChildren<UINickname>();
        uiNickname.SetName(characterName);
    }


    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        transform.position += new Vector3(h, 0, v) * 0.001f * speed;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CubeNPC>())
        {
            CubeNPC npc = collision.gameObject.GetComponent<CubeNPC>();
            npc.uiNickname.SetColor(Color.magenta);
            uiNickname.SetColor(Color.magenta);
        }

        if (collision.gameObject.GetComponent<CubeEnemy>())
        {
            CubeEnemy enemy = collision.gameObject.GetComponent<CubeEnemy>();
            enemy.uiNickname.SetColor(Color.red);
            uiNickname.SetColor(Color.red);
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetComponent<CubeNPC>())
        {
            CubeNPC npc = collision.gameObject.GetComponent<CubeNPC>();
            npc.uiNickname.ResetColor();
            uiNickname.ResetColor();
        }

        if (collision.gameObject.GetComponent<CubeEnemy>())
        {
            CubeEnemy enemy = collision.gameObject.GetComponent<CubeEnemy>();
            enemy.uiNickname.ResetColor();
            uiNickname.ResetColor();
        }
    }
}
