using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputUI : MonoBehaviour
{

    public InputField ipf;
    public ColorBlock c;
    public Text t;

    void Update()
    {
        Debug.Log(ipf.text);
    }

}
