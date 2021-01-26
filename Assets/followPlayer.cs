using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    private Vector3 defaultPos;
    public Vector3 offset;
    public float speed;
    public bool follow;
    void Start()
    {
        defaultPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = player.position + offset;
       if(follow){
            this.transform.position = Vector3.Lerp(this.transform.position,pos,speed * Time.deltaTime);
       }else{
             this.transform.position = Vector3.Lerp(this.transform.position,defaultPos,speed * Time.deltaTime);   
       }
       
       
    }
}
