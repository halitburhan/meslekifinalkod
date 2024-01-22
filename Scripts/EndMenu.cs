using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public Text pointsText;

   
    public void RestartButton()
    {
        SceneManager.LoadScene("GameplayScene");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("StartScene");

    }

}