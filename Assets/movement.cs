using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movement : MonoBehaviour
{
    private Rigidbody rigidbody;
    public TrailRenderer trailRenderer;
    public float minDistance;
    public Transform plane;
    public followPlayer cam;
    public float speed;
    public float thrust;
    public LayerMask mask;
    public Transform bottom;
    public GameObject dead;
    public float gravity;
    public int nextScene;
    public float rad;
    private float hor, vert;
    private bool offensive;
    public bool over;
    public GameObject isOverScreen;
    private SphereCollider collider;
    private MeshRenderer renderer;
    void Start()
    {
        renderer = this.GetComponent<MeshRenderer>();
        over = false;
        collider  = this.GetComponent<SphereCollider>();
        rigidbody = this.GetComponent<Rigidbody>();
        isOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool groundCheck = Physics.CheckSphere(bottom.position,rad,mask);
        hor = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        vert = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        if(!over){
                if(Input.GetKey(KeyCode.LeftShift)){
                rigidbody.velocity = new Vector3(hor * thrust,0,vert * thrust);
                offensive = true;
                if(groundCheck){
                print("grounded");
            }else{
                rigidbody.velocity = new Vector3(rigidbody.velocity.x,-200 * gravity * Time.fixedDeltaTime,rigidbody.velocity.z);
            }
            }else{
                offensive = false;
                rigidbody.velocity = new Vector3(hor,0,vert);
                if(groundCheck){
                print("grounded");
            }else{
                rigidbody.velocity = new Vector3(rigidbody.velocity.x,-200 * gravity * Time.fixedDeltaTime,rigidbody.velocity.z);
            }
            }

        if(lvlManegr.Endable){
            if(Vector3.Distance(this.transform.position,plane.position) < minDistance){
                cam.follow = true;
            }else{
                cam.follow = false;
            }
        }
    }else{
        if(Input.GetKeyDown(KeyCode.F)){
            SceneManager.LoadScene(lvlManegr.cSecene);
        }
    }


        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("enemy")){
            if(offensive){
                other.gameObject.GetComponent<dead>().Break();
                cam.follow = true;
                lvlManegr.kills++;
                Invoke("Reset",1.5f);
            }else{
                
                cam.follow = true;
                renderer.enabled = false;
                if(!over){
                    GameObject deadBody = Instantiate(dead,this.transform.position, Quaternion.identity);
                }
                over = true;
                trailRenderer.enabled = false;
                isOverScreen.SetActive(true);
            }
        }
        if(other.gameObject.CompareTag("Finish")){
            SceneManager.LoadScene(nextScene);
        }
    }
    public void Reset(){
        cam.follow = false;
    }
}
