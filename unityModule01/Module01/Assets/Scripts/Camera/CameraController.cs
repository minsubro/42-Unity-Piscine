using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    GameObject selectPlayer;
    float cameraSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        selectPlayer = null;
    }

    // Update is called once per frame
    void Update()
    {
        selectPlayer = GameManager.Instance.selectPlayer;
        if (selectPlayer != null)
        {
            Transform targetTransform = selectPlayer.transform;
            transform.position = Vector3.Lerp(transform.position, targetTransform.position + new Vector3(0, 0, transform.position.z), cameraSpeed * Time.deltaTime);
        }        
    }
}
