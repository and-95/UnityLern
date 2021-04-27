using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMove : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().transform.forward * speed;
    }

    
  
}
