using UnityEngine;
using Yarn.Unity;
using Yarn.Unity.Attributes;

public class Interactable : MonoBehaviour
{
    [YarnNode("Project")]
    public string Node;
    public DialogueRunner Dialogue;
    public YarnProject Project;
   
   
    
    public void StartInteraction()
    {
        Debug.Log("Started Interaction");
        Dialogue.StartDialogue("Node");
    }
}
