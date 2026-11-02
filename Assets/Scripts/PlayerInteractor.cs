using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInteractor : MonoBehaviour
{
    public float InteractDistance = 2;
    public InputActionReference interactAction;

    private void Update()
    {
        Transform camaraTransform = Camera.main.transform;
        RaycastHit raycastHitInfo;
        bool didRaycastHit = Physics.Raycast(camaraTransform.position, camaraTransform.forward, out raycastHitInfo);
    
           
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * InteractDistance, Color.red);
        if (didRaycastHit)
        {
            Debug.Log("Raycast hit...  + ObjectName?");
            string hitObjectName = raycastHitInfo.collider.gameObject.name;
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
