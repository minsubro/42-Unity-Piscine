using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject selectPlayer;
    public float Speed = 5;
    public float jumpPower = 15;
    Rigidbody rigid;

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.left, Speed * Time.deltaTime);
            // transform.Translate(Vector3.left * claireSpeed);
        if (Input.GetKey(KeyCode.D))
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.right, Speed * Time.deltaTime);
        if (Input.GetKeyUp(KeyCode.A))
            transform.position = transform.position;
        if (Input.GetKeyUp(KeyCode.D))
            transform.position = transform.position;
       
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
    // Start is called before the first frame update
    void Start()
    {
        selectPlayer = null;
        rigid = gameObject.GetComponent<Rigidbody>();
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
