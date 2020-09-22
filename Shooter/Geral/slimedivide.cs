using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimedivide : MonoBehaviour
{
    public GameObject slimelittle;
    public Rigidbody2D rb;
    Vector3 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0f,-4);
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

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="projetil"){
        GameObject b = Instantiate(slimelittle) as GameObject;
        b.transform.position = rb.position + new Vector2(1f,0);
        GameObject c = Instantiate(slimelittle) as GameObject;
        c.transform.position = rb.position + new Vector2(-1f,0);
        
        Destroy(this.gameObject);
        }
        
        
    }
}
