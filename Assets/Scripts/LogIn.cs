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
    [SerializeField]
    private GameObject characterSelectCanvas;
    [SerializeField]
    private Image charImg;

    

    public void LogInBtn()
    {
        string playerName = nameInputField.text;

        if (nameInputField.text.Length > 1 && nameInputField.text.Length < 11)
        {
            
            PlayerPrefs.SetString("PlayerName", playerName);

            SceneManager.LoadScene("MainScene");
        }

    }

    public void ChangeCharacterBtn()
    {
        characterSelectCanvas.SetActive(true);
        
    }

    public void KnightSelectBtn()
    {
        PlayerPrefs.SetInt("CharacterType", 0);
        characterSelectCanvas.SetActive(false);
        charImg.sprite = Resources.Load<Sprite>("Character0");
    }

    public void WizardSelcetBtn()
    {
        PlayerPrefs.SetInt("CharacterType", 1);
        characterSelectCanvas.SetActive(false);
        charImg.sprite = Resources.Load<Sprite>("Character1");
    }


   
    
}
 