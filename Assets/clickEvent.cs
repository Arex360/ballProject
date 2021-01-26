using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickEvent : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown() {
        if(Input.GetKey(KeyCode.Space)){
            print("clicked");
        }
    }
}
