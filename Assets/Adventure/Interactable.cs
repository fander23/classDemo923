using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;
using Yarn.Unity.Attributes;

public class Interactable : MonoBehaviour
{
    public YarnProject Project;
    public CinemachineCamera Camera;

    //public void Start()
    //{
    //    DialogueRunner runner = Dialogue.Instance.Runner;
    //    runner.onDialogueComplete.AddListener(OnDialogueComplete);
    //}

    void OnDialogueComplete()
    {
        Camera.gameObject.SetActive(false);
    }

    [YarnNode("Project")]
    public string Node;

    public DialogueRunner Dialogue;

    public void StartInteraction()
    {
        Debug.Log("started interaction");
        Dialogue.StartDialogue(Node);
        Camera.gameObject.SetActive(true);
    }

    

}