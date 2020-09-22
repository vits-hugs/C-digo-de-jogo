using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kartz : Inimigo
{
   private string pT = "é 13 porra";
   private string gorpe = "131313";
   public override string Agir()
   {
       Atacar(1.3f);
       if(this.Getvida() == 13)
       {
           EstrelasPT();
           return gorpe;
       }


       return pT;
   }
   private void EstrelasPT()
   {
       Atacar(13);
   }
}
