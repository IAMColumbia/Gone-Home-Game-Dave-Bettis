using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionReference moveAction;
    public InputActionReference jumpAction;
    public float speed = 1.0f;
    private CharacterController characterController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // need to make player move foward based on the camera forward
        // instead of always moving the player "north" when forward input is given

        Vector2 moveInput = moveAction.action.ReadValue<Vector2>();
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;
        Debug.Log("Foward : " + forward);
        forward.y = 0;
        Debug.Log("Flattened Foward:" +forward);
        Debug.Log("Foward vector length: " + forward.magnitude);
        right.y = 0;
        forward.Normalize();
        right.Normalize();
        Debug.Log("Normalized forward vector:" +forward.magnitude);
        Vector3 direction = forward * moveInput.y + right * moveInput.x;
        // normalize vector length so that speed is consistent regardless of
        // what way the player is looking when they move
        Debug.Log("");
        characterController.SimpleMove(direction * speed);
    }
}
