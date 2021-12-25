using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private PlayerController player;
    public AudioClip bullet;
    void Start()
    {
        player=FindObjectOfType<PlayerController>();    
        if(player.transform.localScale.x<0)
        {
            speed=-speed;
            transform.localScale=new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity=new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Enemy"){
            Destroy(other.gameObject);
        }
        if(other.tag!="player"){
            Destroy(this.gameObject);
        }
        if(other.tag=="player"){
              Audiomanager.instance.RandomSfx(bullet);
        }
    }
}
