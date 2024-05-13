using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI name;
    private TMP_InputField nameInputField;

    private void Awake()
    {
        PrintName();
    }

    public void PrintName()
    {
        string playerName = nameInputField.text;
        name.text = PlayerPrefs.GetString("PlayerName", playerName);
    }
    
}
