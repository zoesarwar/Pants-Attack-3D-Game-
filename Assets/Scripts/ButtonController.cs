using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    public static float timerChange = 15;
    public static float increase = 2;
    

    public void PlayGame()
    {
        PlayerMovement.jeansLeft = 5;
        PlayerMovement.countdown = 25;
        PlayerMovement.level = 1;
        SceneManager.LoadScene("MainScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NextLevel()
    {
        PlayerMovement.jeansLeft += increase;

        //adds 15 seconds to final time that you finished the level with regardless of level or final time
        PlayerMovement.countdown += timerChange;

        PlayerMovement.level = 1 + PlayerMovement.level;
        SceneManager.LoadScene("MainScene");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OriginalImages()
    {
        SceneManager.LoadScene("OriginalImages");
    }

       public void ImageCredits()
    {
        SceneManager.LoadScene("ImageCredits");
    }

       public void SoundCredits()
    {
        SceneManager.LoadScene("SoundCredits");
    }

       public void WorksCited()
    {
        SceneManager.LoadScene("WorksCited");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif

    }
}
