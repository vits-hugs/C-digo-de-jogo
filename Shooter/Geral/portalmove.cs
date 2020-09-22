using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalmove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velo;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(velo,0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.position.x > 2.3f)
        {
            rb.velocity = new Vector2(-velo,0f);
        }
        if(rb.position.x < -3.2f)
        {
            rb.velocity = new Vector2(velo,0f);
        }
        
    }
}
