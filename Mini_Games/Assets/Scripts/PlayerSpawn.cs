using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerSpawn : MonoBehaviour
{

    GameObject[] _spawns;    
    List<Vector3> _spawnLocations = new List<Vector3>();

    // Start is called before the first frame update
    void Awake()
    {
        _spawns = GameObject.FindGameObjectsWithTag("Spawn Locations");

        for (int i = 0; i < _spawns.Length; i++)
        {
            _spawnLocations.Add(_spawns[i].transform.position);
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
