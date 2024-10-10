using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    Rigidbody2D body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Awake()
    {
          body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
