using UnityEngine;
using Yarn.Unity;
using System.Collections;
using System.Timers;

public class redlight : MonoBehaviour
{
    [YarnCommand("killRed")]
    public void killRed()
    {
        transform.Translate(-2, 1, -12);
    }

    [YarnCommand("awayRed")]
    public void awayRed()
    {
        transform.Translate(2, -1, -12);
    }
}
