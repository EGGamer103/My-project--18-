using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    PlayerInput input;
    Vector2 moveInput;
    public float speed;
    public float jump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<PlayerInput>();
    }

    public void OnMove(InputAction.CallbackContext cxt)
    {
        moveInput = cxt.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext cxt)
    {
        rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(new Vector3(transform.position.x + (moveInput.x * speed), transform.position.y, transform.position.z));
    }
}
