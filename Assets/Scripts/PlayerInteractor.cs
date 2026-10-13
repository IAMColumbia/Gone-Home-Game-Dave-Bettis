using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInteractor : MonoBehaviour
{
    public float InteractDistance = 2;
    public InputActionReference interactAction;

    private void Update()
    {
        bool didRaycastHit = Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward);
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * InteractDistance, Color.red);
        if (didRaycastHit)
        {
            Debug.Log("Raycast hit... something?");
        }
    }
    private void OnEnable()
    {
        interactAction.action.performed += OnInteractPerformed;
    }

    private void OnInteractPerformed(InputAction.CallbackContext callbackContext)
    {
        // do interact logic 
        Debug.Log("Interact button pressed");
    }
}
