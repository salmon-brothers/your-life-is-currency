using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode LeftKey = KeyCode.A;
    public KeyCode RightKey = KeyCode.D;

    void Start()
    {

    }

    void Update()
    {
        var rigidBody = GetComponent<Rigidbody2D>();

        if (Input.GetKey(LeftKey))
        {
            rigidBody.AddForce(Vector2.left * 10);
        }
        else if (Input.GetKey(RightKey))
        {
            rigidBody.AddForce(Vector2.right * 10);
        }
    }
}
