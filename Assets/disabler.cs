using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disabler : MonoBehaviour
{
    // Start is called before the first frame update
   public void Deactive(){
       Invoke("doIT",0.4f);
   }
   void doIT(){
        this.gameObject.SetActive(false);
   }
}
