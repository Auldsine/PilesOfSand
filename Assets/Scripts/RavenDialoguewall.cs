using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavenDialoguewall : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue dialogueManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="player"){
            string[] dialogue={"Raven: Watchout!!, The snake is guarding the wall and you need to jump on its head in order to kill it",
            "Raven: The wall needs big explosives to be destroyed, do you have any ?",
            "Yonoko: No but I have what is better.",
            "Raven: Okay be carefull, There is an apple that can restore your strength above a tree behind the wall",};
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }
    }
}
