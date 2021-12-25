using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavenDialoguestrange : MonoBehaviour
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
            string[] dialogue={"Strange Man: Hello, Come over here.",
                                "Yonoko: What are you doing in such a place?",
                                "Strange Man: I am helping you.",
                                "Yonoko: How is that?",
                                "Strange Man: There is a small snake hiding in that pile of sand over there, be carefull!",
                                "Yonoko: Thank you very much i might have died if you didn't warn me, I am trying to find the World gem to reveal its secrets and know more about my father",
                                "Strange Man: I can help you",
                                "Yonoko accepts his offer but was confused at the same time. Yonoko: What is your name old man?",
                                "Strange Man: My name is Raven"};
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }
    }
}
