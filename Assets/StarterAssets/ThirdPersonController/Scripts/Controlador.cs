using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Animator>().SetBool("saltar", true);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            this.GetComponent<Animator>().SetBool("saltar", false);
        }
    }
}