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
            string[] dialogue={"Raven: The wall needs explosives to be destroyed, Do you have any?",
            "Yonoko: No but I have what is better.",
            "Raven: There is an apple that can restore your strength behind the wall"};
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }
    }
}
