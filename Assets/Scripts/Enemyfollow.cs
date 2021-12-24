using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfollow : EnemyController
{
    // Start is called before the first frame update
    public PlayerController player;
    void Start()
    {
        player=FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector3.MoveTowards(transform.position,player.transform.position, maxSpeed*Time.deltaTime);
    }
}
