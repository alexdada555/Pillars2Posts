using UnityEngine;
using UnityEngine.UI;


public class TextDisplay : MonoBehaviour
{
    public Text Score;
    public GameObject Player;
    private KeepScore readval;

    private int score;

    void Start()
    {
    }
    void Update()
    {
        readval = Player.GetComponent<KeepScore>();
        score = readval.Points;
        Score.text = score.ToString();
    }
}
