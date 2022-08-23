using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockScript : MonoBehaviour
{
    public GameObject doorHinge;

    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            doorHinge.transform.Rotate(0, 90, 0);
        }
    }
}
