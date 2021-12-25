using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip Apple;
    public int value;
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="player"){
            Audiomanager.instance.RandomSfx(Apple);
            FindObjectOfType<Playerstats>().healthrestore(value);
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
