using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Resume : MonoBehaviour
{
    public GameObject obj;
    public float T;
    
    public void Reconstitute()
    {
        T = obj.GetComponent<GameManager>().GameTime;
        //T = FindObjectOfType<GameManager>().GameTime;
        obj.GetComponent<GameManager>().Score.text = T.ToString("0");
        obj.GetComponent<GameManager>().Resume();
        //FindObjectOfType<GameManager>().Score.text = T.ToString("0");
        //GetComponent<GameManager>().Resume();
    }
}
