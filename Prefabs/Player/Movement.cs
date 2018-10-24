using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    // Use this for initialization
    Animator animator;
    
	void Start ()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 6.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        if (x != 0 || z != 0)
            animator.SetBool("running_bool",true);
        else
            animator.SetBool("running_bool",false);
        transform.Translate(x, 0, 0);
        transform.Translate(0, z, z);
        /*var dx = 0.1F;
        if (transform.position.x >= 50)
            transform.position = new Vector3(40, transform.position.y, transform.position.z);
        transform.position += Vector3.right * dx;*/
    }
}
