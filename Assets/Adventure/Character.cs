using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;
    public InputActionReference Move;
    public Camera Camera;
    public bool IsTankControls;

    // Update is called once per frame
    void Update()
    {
        if (IsTankControls)
        {
            float delta = Time.deltaTime;
            Vector2 move = Move.action.ReadValue<Vector2>();

            transform.position += transform.forward * Speed * move.y * delta;

            // rotate around the given axis, however much is wanted
            transform.Rotate(Vector3.up, RotationSpeed * move.x * delta);
        }

        else
        {
            float delta = Time.deltaTime;
            //Vector3 move = Move.action.ReadValue<Vector3>();
            Vector3 forward = Vector3.ProjectOnPlane(Camera.transform.forward, Vector3.up);
            Vector3 right = Vector3.ProjectOnPlane(Camera.transform.right, Vector3.up);
            //transform.position += move.y * Speed * delta * forward;
            //transform.position += move.x * Speed * delta * right;

            Vector3 moveDir = move.y * forward * move.x * right;
            transform.position += moveDir * Speed * delta;
            transform.forward = Vector3.RotateTowards(transform.forward, moveDir, Mathf.Deg2Rad * RotationSpeed * delta, 0f)
        }
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
