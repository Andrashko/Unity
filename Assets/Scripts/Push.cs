using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float Force;
    [SerializeField]
    private Vector3 Direction = new Vector3(0, 1, 0);
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward;
        if (Input.GetButton("Jump")) {
            rb.AddForce(Direction * Force*Time.deltaTime);
        }

    }

    private void FixedUpdate()
    {
        
    }
}
