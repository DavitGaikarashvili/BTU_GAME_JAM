using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("level_1");
    }
}
