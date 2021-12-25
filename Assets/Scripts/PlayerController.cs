using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed;
    public float jumpheight;
    public bool isfacingright;
    public KeyCode Spacebar;
    public KeyCode L;
    public KeyCode R;
    public Transform groundcheck;
    public float groundcheckradius;
    public LayerMask whatisground;
    public Transform firepoint;
    public GameObject bullet;
     public KeyCode s;
    private bool grounded;
   
    private Animator anim; 
 
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isfacingright = true;
    }

    // Update is called once per frame
     void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, whatisground);
    }


    void Update()
    {
        
        if(Input.GetKeyDown(s))
        {
            Instantiate(bullet,firepoint.position,firepoint.rotation);
        }
        
            if (Input.GetKeyDown(Spacebar)&&grounded)
        {
            jump();
        }
        anim.SetBool("grounded", grounded);//Animator understands that its parameter Grounded and the boolean value grounded are related

        if (Input.GetKey(L)) //F1 to move left
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
           if(isfacingright)
            {
                Flip();
                isfacingright = false;
            }
        }
        if (Input.GetKey(R)) //F2 to move right
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);
            if(!isfacingright)
            {
                Flip();
                isfacingright = true;
            }
        }
        anim.SetFloat("speed",Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }

    //Character flips right and left of screen
    void Flip()
    {
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
    //Player jumps
    void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpheight);
    }
    
}

