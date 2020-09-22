using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GordodaBad : Inimigo
{
    private string gfala = "BARRIGADA MONSTRO";
 public override string Agir(){
     Debug.Log("Barrigada");
     Atacar(4);
     return gfala;
 }
}
