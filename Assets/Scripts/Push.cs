using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float Force = 20f;
    [SerializeField]
    private Vector3 Direction;
    private Rigidbody rb;
    private CheckGround cg;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Direction = transform.up;
        cg = gameObject.GetComponentInChildren<CheckGround>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && cg.IsOnGround) {
            rb.AddForce(Direction * Force);
        }

    }

    private void FixedUpdate()
    {
        
    }

}
