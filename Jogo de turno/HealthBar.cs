using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Image barra;
    Inimigo jogador;

    private float vmax;
    private float vatual;
    private float VatualPorc;
    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindGameObjectWithTag("Player").GetComponent<Inimigo>();
        barra = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        vmax = jogador.Getvidamax();
        vatual = jogador.Getvida();
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
