using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed = 15.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (verticalInput!=0)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * (horizontalInput * (verticalInput>0?1:-1)) * turnSpeed);
            transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
        }
    }
}
