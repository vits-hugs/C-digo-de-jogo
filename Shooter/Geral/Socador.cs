using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socador : MonoBehaviour
{
    Animator soco;
    void Start()
    {
        soco = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            soco.SetTrigger("soque");
            pontuação.Qtsoco ++;
        }
    }
}
