using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wall;
    public AudioClip wallDestroy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="bullet")
        {            
            Destroy(wall);
            Audiomanager.instance.RandomSfx(wallDestroy);
        }
    }
    void Update()
    {
        
    }
}
