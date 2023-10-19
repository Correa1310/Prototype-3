using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacleprefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float  repeatRate = 2; 
    private PlayerController _playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        _playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle ()
    {
        if (_playerControllerScript.gameOver == false)
        Instantiate(obstacleprefab, spawnPos, obstacleprefab.transform.rotation);
    }
}
