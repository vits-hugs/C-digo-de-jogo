using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimelittlemove : MonoBehaviour
{
    private Vector2 screenBounds;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0f,-4f);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < - screenBounds.y){
        vidaHUD.vida --;
        Destroy(this.gameObject);
        }
        
    }
}
