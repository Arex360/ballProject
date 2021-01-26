using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadScript : MonoBehaviour
{
    public GameObject primary;
    public GameObject secondary;
    public GameObject deadBody;
    public GameObject twirl;
    public forwader player;
    public GameObject play;
    public void SpawnDead(){
        GameObject temp = (GameObject) Instantiate(deadBody,this.transform.position,Quaternion.identity);
        Destroy(play);
        primary.SetActive(true);
        secondary.SetActive(false);
        this.gameObject.SetActive(false);
        twirl.SetActive(true);
        player.start = true;
    }
}
