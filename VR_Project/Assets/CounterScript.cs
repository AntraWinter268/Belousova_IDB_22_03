using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    public Text Counter;
    public CollisionScript CubeScript;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Counter.text = "Score: "+ CubeScript.score;
    }
}
