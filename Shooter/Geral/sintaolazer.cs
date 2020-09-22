using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sintaolazer : MonoBehaviour
{   
    [System.Serializable]
    public class Enemy
    {
        public GameObject corpo;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void morrendo()
    {
        Destroy(this.gameObject);
    }
}
