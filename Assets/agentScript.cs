using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class agentScript : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent agent;
    public Transform player;
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!player.transform.gameObject.GetComponent<movement>().over){
            agent.SetDestination(player.position);
        }else{
            agent.SetDestination(Vector3.zero);
        }
    }
}
