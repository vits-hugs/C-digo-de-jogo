using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrolafaz : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject pow;
    Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0,-10);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < - screenBounds.y){
            vidaHUD.vida -= 2;
            Destroy(this.gameObject);
        }
        
    }
    void OnCollisionEnter2D (Collision2D col)
    {
        GameObject b = Instantiate(pow) as GameObject;
        b.transform.position = rb.position;
        Destroy(this.gameObject);
        
        if (col.gameObject.tag == "projetil"){
            GameObject c = Instantiate(pow) as GameObject;
            c.transform.position = rb.position;
            Destroy(this.gameObject);

        }

    }
}
