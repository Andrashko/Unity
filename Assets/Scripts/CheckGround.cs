using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    // Start is called before the first frame update
    public bool IsOnGround = true;
    private void OnTriggerEnter(Collider other)
    {
        IsOnGround = true;
    }

    private void OnTriggerExit(Collider other)
    {
        IsOnGround = false;
    }
}
