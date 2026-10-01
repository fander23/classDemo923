using UnityEngine;
using UnityEngine.InputSystem;

public class MoevementExercise930 : MonoBehaviour
{

    public InputActionReference WASD;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 wasd = WASD.action.ReadValue<Vector2>();
        Debug.Log("moved" + wasd);
        transform.position += wasd * speed * Time.deltaTime;
    }
}
