using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ActiveScript : MonoBehaviour
{
    public GameObject sphere; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Object is activated");
            sphere.SetActive(true);
        }

        if (Input.GetKey(KeyCode.G))
        {
            Debug.Log("Object is deactivated");
            sphere.SetActive(false);
        }
    }
}
