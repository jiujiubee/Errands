using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        Debug.Log("x");
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
