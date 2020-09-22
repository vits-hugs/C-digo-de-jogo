using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarinimigo : MonoBehaviour
{
    Image barra;
    Inimigo mob;

    private float vmax;
    private float vatual;
    private float VatualPorc;
    // Start is called before the first frame update
    void Start()
    {
        mob = GameObject.FindGameObjectWithTag("Player").GetComponent<iniciaCombate>().vilao.GetComponent<Inimigo>();
        barra = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(VatualPorc == 0)
        {
            mob = GameObject.FindGameObjectWithTag("Player").GetComponent<iniciaCombate>().vilao.GetComponent<Inimigo>();
            barra.fillAmount = 1;
        }
        vmax = mob.Getvidamax();
        vatual = mob.Getvida();
        VatualPorc = vatual/vmax;
        
        
    }
    void FixedUpdate()
    {
        AnimBarra();
    }
    void AnimBarra()
    {
        if(barra.fillAmount < VatualPorc)
        {
            return;
        }
        else
        {
            barra.fillAmount -= 0.01f;
        }
    }
}
