using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCube : MonoBehaviour{
    public int a;
    private int b = 6;
    public int c;

    // Start is called before the first frame update
    void Start(){
        ///a = 8;
        //c = a + b;
        //Debug.Log("—ÛÏÏ‡ = " + c);
    }

    // Update is called once per frame
    void Update(){
        c++;
        Debug.Log(c);
    }
}
