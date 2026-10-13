using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInteractor : MonoBehaviour
{
    public InputActionReference interactAction;


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
