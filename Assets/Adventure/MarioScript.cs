using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class MarioScript : MonoBehaviour
{
    public RawImage MarioIMG;
    public YarnProject Project;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    [YarnCommand("MarioAppear")]
    public void MarioAppear()
    {
        Debug.Log("Mario is here");
        transform.Translate(2500, 0, 0);
    }

    [YarnCommand("MarioBye")]
    public void MarioBye()
    {
        Debug.Log("Mario is gone");
        transform.Translate(-2500, 0, 0);
    }
}
