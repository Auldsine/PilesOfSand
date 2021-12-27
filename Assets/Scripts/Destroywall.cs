using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroywall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wall;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="player")
        {
            Destroy(wall);
        }
    }
    void Update()
    {
        
    }
}
