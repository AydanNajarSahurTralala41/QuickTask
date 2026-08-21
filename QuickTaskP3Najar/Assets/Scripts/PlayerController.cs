using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnspeed = 100f;

    public InputAction MoveAction;

    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = MoveAction.ReadValue<Vector2>();

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * moveInput.y);

        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * moveInput.x);
    }
}
