using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Inimigo
{
   private string ataque = "haha";
   private string SgolpeFatal = "Iaaaa";
   public override string Agir()
   {
       Atacar(1.3f);
       if(this.Getvida() == 13)
       {
           GolpeFatal();
           return SgolpeFatal;
       }


       return pT;
   }
   private void GolpeFatal()
   {
       Atacar(13);
   }
}
