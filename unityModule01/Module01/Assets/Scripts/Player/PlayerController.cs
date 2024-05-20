using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject selectPlayer;
    public float speed;
    public float jumpPower;
    Rigidbody rigid;
    Collider PlayerCollider;

    void OnTriggerStay(Collider other)
    {
        if (gameObject.CompareTag("Claire") && other.CompareTag("ClaireExit"))
        {
            float distance = Vector3.Distance(transform.position, other.transform.position);
            if (distance < 0.1f) {
                
            }
        }
    }

    void Move()
    {               
        if (Input.GetKey(KeyCode.A))
            rigid.MovePosition(transform.position + speed * Time.deltaTime * Vector3.left);
            // transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.left, Speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            rigid.MovePosition(transform.position + speed * Time.deltaTime * Vector3.right);
            // transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.right, speed * Time.deltaTime);
        if (Input.GetKeyUp(KeyCode.A))
            transform.position = transform.position;
        if (Input.GetKeyUp(KeyCode.D))
            transform.position = transform.position;
         
    }

    void Jump()
    {
        float length = PlayerCollider.bounds.extents.y + 0.1f;
        if (Input.GetKeyDown(KeyCode.Space) && 
            Physics.Raycast(transform.position, Vector3.down, length))
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
    // Start is called before the first frame update
    void Start()
    {
        selectPlayer = null;
        rigid = gameObject.GetComponent<Rigidbody>();
        PlayerCollider = gameObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        selectPlayer = GameManager.Instance.selectPlayer;
        if (selectPlayer != null && gameObject.tag == selectPlayer.tag) 
        {
            Move();
            Jump();
        }
    }   
}
