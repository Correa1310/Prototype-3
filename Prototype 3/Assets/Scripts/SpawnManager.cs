using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Obstacleprefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float _startDelay = 2f;
    private float  _repeatRate = 2f; 
    private PlayerController _playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", _startDelay, _repeatRate);
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle ()
    {
        if (_playerControllerScript.gameOver == false)
        {
            Instantiate(Obstacleprefab, spawnPos, Obstacleprefab.transform.rotation);
        }
    }
}
