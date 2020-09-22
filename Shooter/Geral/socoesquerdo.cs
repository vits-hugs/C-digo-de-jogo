using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socoesquerdo : MonoBehaviour
{
    Animator soco;
    // Start is called before the first frame update
    void Start()
    {
        soco = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)){
            soco.SetTrigger("soca");
            pontuação.Qtsoco ++;
        }
    }
}
