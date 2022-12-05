using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeNPC : MonoBehaviour
{
    public UINickname uiNickname;

    public string npcName;

    private void Start()
    {
        uiNickname = GetComponentInChildren<UINickname>();
        uiNickname.SetName(npcName);
    }
}
