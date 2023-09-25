using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int Q; 
    private int E=5;
    public GameObject T;
    private int C;
    public int B=0;
    // Start is called before the first frame update
    void Start() //выполняется единожды
    {
        C = Q + E;
        Debug.Log("Сумма Q и E = " + C);
    }

    // Update is called once per frame
    void Update()
    {
        B++;
        Debug.Log("B" + C);
    }
}
