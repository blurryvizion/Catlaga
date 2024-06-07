using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public void PlayGame()
    {
        //change sample with title for first level scene
        SceneManager.LoadSceneAsync("sample");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        //Need to edit health script so that the "GameOver" scene 
        //appears when health is 0 
        SceneManager.LoadSceneAsync("Title");
    }

}
