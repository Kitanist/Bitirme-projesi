using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneUI : MonoBehaviour
{
    public GameObject Credits;
    
    public void OpenCredits()
    {
        Credits.SetActive(true);
        Invoke("CreditsClose", 15f);
    }
    public void CreditsClose()
    {
        Credits.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
