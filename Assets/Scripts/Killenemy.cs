using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killenemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="player")
        {
            Destroy(enemy);
        }
    }
    void Update()
    {
        
    }
}
