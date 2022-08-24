using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotocopierBehavior : MonoBehaviour
{
    public Animator anim;

    public bool isPaperOnTray = false;

    private GameObject currentDoc;
    // Start is called before the first frame update
    void Start()
    {
        
       // anim = this.gameObject.GetComponentInParent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Photocopier");

        if (other.gameObject.CompareTag("Paper"))
        {
            isPaperOnTray = true;
            currentDoc = other.gameObject;
            //anim.SetBool("runPhotocopy", true);
        }
    }

/*    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Paper"))
        {
            isPaperOnTray = false;
            currentDoc = null;
        }
    }
*/
    public void Print()
    {
        if (isPaperOnTray)
        {
            anim.SetBool("runPhotocopy", true);
            Instantiate(currentDoc, this.transform.position + Vector3.up, this.transform.rotation) ;
        }

    }
}
