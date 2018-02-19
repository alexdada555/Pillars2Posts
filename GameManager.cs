using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float GameTime = 60;
    public float T;

    public GameObject Player;
    public GameObject initscore;
    public KeepScore readval;

    public Text Score;
    public int score;
    private float delay = 4f;
    bool ended = false;

    public void EndGame()
    {
        GameTime -= Time.deltaTime;
        T = GameTime;

        readval = Player.GetComponent<KeepScore>();
        score = readval.Points;
        Score.text = GameTime.ToString("0");

        if (GameTime < 0 && ended == false)
        {
            if (PlayerPrefs.GetInt("HighScore") < score)
            { 
                PlayerPrefs.SetInt("HighScore", score);
            }
            Score.text = "GAME OVER: Score " + score.ToString();

            ended = true;
            FindObjectOfType<PlayerBehaviour>().enabled = false;
            FindObjectOfType<MobileMovement>().enabled = false;
            FindObjectOfType<CoinMovement>().enabled = false;
            FindObjectOfType<KeepScore>().enabled = false;
            FindObjectOfType<TextDisplay>().enabled = false;
            FindObjectOfType<TextDisplay>().enabled = false;
            initscore.GetComponent<Text>().enabled = false;
            FindObjectOfType<CameraMovement>().enabled = false;

            
            Invoke("Pause", delay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void Commence()
    {
        SceneManager.LoadScene(1);
    }

    public void Resume()
    {
        SceneManager.LoadScene(1);
    }

    public void Pause()
    {
        SceneManager.LoadScene(2);
    }

    public void Credits()
    {
        SceneManager.LoadScene(3);
    }
}
