using UnityEngine;
using System.Collections;


public class CoinMovement : MonoBehaviour
{
    public Transform C;
    public MeshRenderer show;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            show.enabled = false;
            Vector3 position = new Vector3(Random.Range(-40.0f,40.0f), 1.5f, Random.Range(-10.0f, 10.0f) * Time.deltaTime * 60);
            transform.position = position;
            show.enabled = true;
        }
    }

    void Update()
    {
        C.Rotate(0,0,-1* Time.deltaTime * 60);
    }
}
