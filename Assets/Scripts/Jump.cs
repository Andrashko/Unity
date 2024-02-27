using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float L = 1f;
    [SerializeField] private float H = 1f;
    [SerializeField] private float T = 1f;
    [SerializeField] bool isJumping = false;

    private float CalculateY(float x)
    {
        return -4*H/(L*L) * (x-L)*x;
    }

    private float x = 0f;
    private float y = 0f;
    private float t = 0f;
    private Vector3 startPos;
    private void Reset()
    {
        x = 0f;
        y = 0f;
        t = 0f;
    }

    private void CalculateNextPos(float t)
    {
        x =  L*t/T;
        y = CalculateY(x);
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump")){
            isJumping = true;
            startPos = transform.position;
            Reset();
        }
        if (isJumping) {
            print(t);
            t += Time.deltaTime;
            CalculateNextPos(t);
            transform.position = startPos+ new Vector3(x, y, 0);
            if (t > T)
            {
                isJumping = false;
            }
        }
    }
}
