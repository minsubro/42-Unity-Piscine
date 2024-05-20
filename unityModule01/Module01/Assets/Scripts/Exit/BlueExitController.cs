using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlueExitController : MonoBehaviour
{
    
    void onColliderStay(Collision other)
    {
        Collider otherCollider = other.collider;
        if (otherCollider.CompareTag("Claire"))
        {
            float distance = Vector3.Distance(transform.position, otherCollider.transform.position);
            if (distance < 0.1f)
                Debug.Log("닿았다.");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
