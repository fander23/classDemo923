using UnityEngine;
using UnityEngine.InputSystem;

public class MovementExercise928 : MonoBehaviour
{
    public InputActionReference Move;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Move.action.ReadValue<Vector2>();
        Debug.Log("move: " + move);
        transform.position += move * Time.deltaTime;
    }
}
