using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float turnSpeed;

    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        //move the vehicle
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
