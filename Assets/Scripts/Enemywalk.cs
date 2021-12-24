using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemywalk : EnemyController
{
    // Start is called before the first frame update
    void Start()
    {

    }
      // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (this.facingRight == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Wall")
        {
            Flip();
        }
        else if (collider.tag == "Enemy")
        {
            Flip();
        }
        if (collider.tag == "player")
        {
            FindObjectOfType<Playerstats>().takedamage(damage);
            Flip();
        }
    }
}
