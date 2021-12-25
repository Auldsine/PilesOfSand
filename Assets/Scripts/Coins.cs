using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip coin1;
    public AudioClip coin2;
    public int value;
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="player"){
            Audiomanager.instance.RandomSfx(coin1, coin2);
            FindObjectOfType<Playerstats>().Collectcoins(value);
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
