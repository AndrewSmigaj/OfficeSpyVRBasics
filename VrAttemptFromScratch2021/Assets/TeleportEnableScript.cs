using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportEnableScript : MonoBehaviour
{
    // Start is called before the first frame update


    public void HandleAction(InputAction.CallbackContext context)
    {
        Debug.Log("WE MADE IT!");
    }
}
