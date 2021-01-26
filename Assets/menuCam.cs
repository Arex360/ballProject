using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuCam : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject portal;
    public GameObject player;
    public GameObject primaryCam;
    private Ray ray;
    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out hit)){
         //   print(hit.transform.name);
          if(hit.transform.CompareTag("play")){
              if(Input.GetMouseButton(0)){
              hit.transform.gameObject.GetComponent<deadScript>().SpawnDead();
          }
          }
        }
    }
}
