using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playervida : Inimigo
{
    private string fala = "mew";
    public override string Agir()
    {
        Debug.Log("MEAU");
        return fala;
    }

   
}

