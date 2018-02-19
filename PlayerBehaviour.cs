using UnityEngine;


public class PlayerBehaviour : MonoBehaviour
{
    public Rigidbody Player;
    public int right = 200;
    public int left = -200;
    public int up = 200;
    public int down = -200;

    void FixedUpdate ()
    {
        if (Input.GetKey("a"))
        {
            Player.AddForce(left, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            Player.AddForce(right, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            Player.AddForce(0, 0, up);
        }
        if (Input.GetKey("s"))
        {
            Player.AddForce(0, 0, down);
        }
        FindObjectOfType<GameManager>().EndGame();
    }
    
}
