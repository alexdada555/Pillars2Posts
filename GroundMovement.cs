using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public Transform ground;
    public int right = 10;
    public int left = -10;
    public int up = 10;
    public int down = -10;

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            ground.Rotate(left, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            ground.Rotate(right, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            ground.Rotate(0, 0, up);
        }
        if (Input.GetKey("s"))
        {
            ground.Rotate(0, 0, down);
        }
    }
}
