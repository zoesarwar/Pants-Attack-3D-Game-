using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepLevel : MonoBehaviour
{
    public Text levelText;
    public Text highscoreText;

    public GameObject failSound;

    void Start()
    {
        highscoreText.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    public void Reset()
    {
        highscoreText.text = "0";
        PlayerPrefs.DeleteKey("Highscore");
    }

    void Update()
    {
        levelText.text = PlayerMovement.level.ToString();
    }

    private void Awake()
    {
        if (PlayerMovement.level > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", (int)PlayerMovement.level);
            highscoreText.text = PlayerMovement.level.ToString();
        }
        else
        {
            Instantiate(failSound, transform.position, Quaternion.identity);
        }

        //to play noise if you dont beat highscoreS 
        /*if (PlayerMovement.level < PlayerPrefs.GetInt("Highscore", 0))
        {
            Instantiate(failSound, transform.position, Quaternion.identity);
        }*/
    }
}
