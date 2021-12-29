using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pileofsand : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip sand;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="bullet"){
            Audiomanager.instance.RandomSfx(sand);
            Destroy(this.gameObject);
        }
    }
}
