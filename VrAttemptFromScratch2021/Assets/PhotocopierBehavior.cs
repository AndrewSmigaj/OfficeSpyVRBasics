using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotocopierBehavior : MonoBehaviour
{
    public Animator anim;
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
        Debug.Log("GeetingThere");
        anim.SetBool("runPhotocopy", true);
    
    }
}
