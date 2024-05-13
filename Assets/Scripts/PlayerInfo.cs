using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI name;
    

    private void Awake()
    {
        PrintName();
    }

    public void PrintName()
    {
        name.text = PlayerPrefs.GetString("PlayerName");
    }
    
}
