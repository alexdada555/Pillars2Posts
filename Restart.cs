using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void Redo()
    {
        SceneManager.LoadScene(0);
    }
    
}
