using UnityEngine;
using UnityEngine.UI;
using System;

public class KeepScore : MonoBehaviour
{
    public Rigidbody Player;
    public int Points = 0;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Coin")
        {
            Points++;
        }
    }
}
