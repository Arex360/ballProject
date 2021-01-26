using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{
    public GameObject broken;
    public void Break(){
        GameObject temp = Instantiate(broken,this.transform.position,Quaternion.identity);
        temp.SetActive(true);
        Destroy(temp,10f);
        this.transform.gameObject.SetActive(false);
    }
}
