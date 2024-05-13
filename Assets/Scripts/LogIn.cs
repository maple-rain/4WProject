using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LogIn : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField nameInputField;
    
        
    public void LogInBtn()
    {
        string playerName = nameInputField.text;

        if (nameInputField.text.Length > 1 && nameInputField.text.Length < 11)
        {
            
            PlayerPrefs.SetString("PlayerName", playerName);

            SceneManager.LoadScene("MainScene");
        }
    }
   
}
