using UnityEngine;

public class MobileMovement : MonoBehaviour
{ 
    public Rigidbody Player;
    public bool Flat = true;
    public int MoveForce = 400;

    private void Start()
    {
        Player = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Vector3 tilt = Input.acceleration;
        if(Flat)
        {
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        }

        Player.AddForce(tilt*MoveForce);
    }
}
