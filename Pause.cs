using UnityEngine;
using UnityEngine.UI;
using System;

public class Pause : MonoBehaviour
{
    public void pause ()
    {
        FindObjectOfType<GameManager>().Pause();
    }
}
