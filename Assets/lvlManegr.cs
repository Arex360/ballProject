using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlManegr : MonoBehaviour
{
    public static int kills;
    public int totalKills;
    public int CurrentLevel;
    public static int cSecene;
    public static bool Endable;
    public GameObject portal;
    void Start()
    {
        cSecene = CurrentLevel;
        kills = 0;
        Endable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(kills == totalKills){
             portal.SetActive(true);
             Endable = true;
        }
    }
}
