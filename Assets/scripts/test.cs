using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class test : MonoBehaviour
{
    private float Timer = 0f;
    private float Limit = 1f;
    private int n = 1;
    private void Awake()
    {
         Debug.Log("Awake");
    }
    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
            Debug.Log($"{n}: {Time.deltaTime}");
        n++;
        if(Timer > Limit)
        {
            Debug.Log("1 second");
            Timer = 0f;
        }
    }
}
