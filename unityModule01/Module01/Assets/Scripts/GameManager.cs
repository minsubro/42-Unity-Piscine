using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    public GameObject selectPlayer;
    // Start is called before the first frame update
    void Start()
    {
        selectPlayer = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            selectPlayer = GameObject.FindWithTag("Claire");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            selectPlayer = GameObject.FindWithTag("John");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            selectPlayer = GameObject.FindWithTag("Thomas");
        }
    }
}
