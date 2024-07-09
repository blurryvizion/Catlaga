using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenue : MonoBehaviour
{
    [SerializeField] GameObject pauseMenue;

    public void Pause()
    {
        pauseMenue.SetActive(true);
        Time.timeScale = 0;
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        pauseMenue.SetActive(false);
        Time.timeScale = 1;
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}