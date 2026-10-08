using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, speed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed += speed * 2;
        }
    }
}
