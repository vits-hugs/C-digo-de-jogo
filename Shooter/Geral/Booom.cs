using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booom : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col){
        Destroy(col.gameObject);
        Destroy(this.gameObject,0.1f);
    }
}
