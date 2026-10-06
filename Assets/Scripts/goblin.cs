using UnityEngine;
using Yarn.Unity;
using System.Collections;
using System.Timers;


public class goblin : MonoBehaviour
{
    public float speed = 10f;
    
    [YarnCommand("up")]
    public void Up()
    {
        transform.Translate(2, 2, 2);
    }

    [YarnCommand("bye")]
    public void bye()
    {
        Debug.Log("Goblin Moved");
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

}
