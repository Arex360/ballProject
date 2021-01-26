using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class forwader : MonoBehaviour
{
    public bool start;
    public float speed;
    private Rigidbody rigidbody;
    void Start()
    {
        start = false;
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(start){
            rigidbody.velocity = Vector3.forward * speed * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(other.transform.gameObject.CompareTag("Finish")){
           SceneManager.LoadScene(1);
        }
    }
}
