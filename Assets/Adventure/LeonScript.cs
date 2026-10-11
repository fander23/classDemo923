using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class LeonScript : MonoBehaviour
{
    public RawImage LeonIMG;
    public YarnProject Project;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    [YarnCommand("LeonAppear")]
    public void MarioAppear()
    {
        Debug.Log("Leon is here");
        transform.Translate(2500, 0, 0);
    }

    [YarnCommand("LeonBye")]
    public void MarioBye()
    {
        Debug.Log("Leon is gone");
        transform.Translate(-2500, 0, 0);
    }
}