using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody rigid;
    public LayerMask targetLayer;
    float force = 1.0f;
    float jump = 7.0f;

    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Floor")
        {
            Destroy(gameObject);
            Debug.Log("Game over!");
        }
    }
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            rigid.AddForce(Vector3.forward * force);
        if (Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow))
            rigid.AddForce(Vector3.back * force);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            rigid.AddForce(Vector3.left * force);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            rigid.AddForce(Vector3.right * force);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 0.5f, targetLayer))
                rigid.AddForce(Vector3.up * jump, ForceMode.Impulse);
        }
    }
    
}
