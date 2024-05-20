using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGenerator : MonoBehaviour
{
    public GameObject playerPrefeb;
    GameObject players;
    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.Find("Players");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(players);
            players = Instantiate(playerPrefeb);
        }
    }
}
