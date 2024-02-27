using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update\
    [SerializeField] private float Speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * Speed* Time.deltaTime;
        float dz = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        transform.Translate(dx, 0, dz);
    }
}
