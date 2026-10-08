using UnityEngine;
using UnityEngine.InputSystem;

public class MoochieMovement : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;
    public InputActionReference Move;
  

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime;
        Vector2 move = Move.action.ReadValue<Vector2>();
        //rotate around the given axis, however much is wanted
        transform.Rotate(Vector3.up, RotationSpeed * move.x * delta);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Interactable other = collision.gameObject.GetComponent<Interactable>();
        if (other)
        {
            other.StartInteraction();
        }
    }

}
