using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite ExplodedBlock;
    // Start is called before the first frame update
    void Start()
    {
        sr=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D (Collision2D other){
        if(other.gameObject.name=="Character"&& other.GetContact(0).point.y < transform.position.y)
        {
            sr.sprite= ExplodedBlock;
            Object.Destroy(gameObject, .2f);
        }
    }
}
