using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndPlay : MonoBehaviour
{
    public GameObject obj;

    public void ShowCredits()
    {
        SceneManager.LoadScene(3);
    }
}
