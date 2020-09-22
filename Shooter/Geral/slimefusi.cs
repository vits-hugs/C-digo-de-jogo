using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimefusi : MonoBehaviour
{   
    public Rigidbody2D eu;
    Vector3 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        eu.velocity = new Vector2 (0,-12f);
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
