using UnityEngine;
using UnityEngine.UI;
using System;

public class HighScore : MonoBehaviour
{
    public Text result;

    public void Start()
    {   
        result.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }  
}