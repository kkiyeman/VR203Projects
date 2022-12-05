using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnemy : MonoBehaviour
{
    public UINickname uiNickname;

    public string enemyName;

    private void Start()
    {
        uiNickname = GetComponentInChildren<UINickname>();
        uiNickname.SetName(enemyName);
    }
}
