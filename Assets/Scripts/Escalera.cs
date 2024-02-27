using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("generarEscalon", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision c)
    {
        Debug.Log("Cae");
    }

    void generarEscalon()
    {
        Vector3 pos = this.transform.position;
        pos = pos + new Vector3(0.0, 4f, -1.5f);
        Instantiate(this.gameObject, pos, this.transform.rotation);
    }
}
