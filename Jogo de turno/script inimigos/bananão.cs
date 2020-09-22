using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bananão : Inimigo
{
    private string bfala = "bananides";
    public override string Agir(){
        Debug.Log("bananada");
        Atacar(42);
        return bfala;
    


    }
  
  
}
