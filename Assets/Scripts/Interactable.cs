using UnityEngine;
/// <summary>
/// The player can interact with interactables by standing near them, 
/// looking at them, and then pressing the interact button.
/// </summary>

public class Interactable : MonoBehaviour
{
    private void Interact()
    {
        Debug.Log("You interacted with me!");
    }
   
}
