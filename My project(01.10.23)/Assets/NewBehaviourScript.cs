using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject sphere;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void FixedUpdate(){
        if (Input.GetKey(KeyCode.F)){
            sphere.SetActive(false);
        }
        if (Input.GetKey(KeyCode.G))
        {
            sphere.SetActive(true);
        }
    }
}
