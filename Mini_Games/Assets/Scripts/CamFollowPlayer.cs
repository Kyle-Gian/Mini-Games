using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public Camera camera;
    GameObject _player;

    public Vector3 _distFromPlayer = new Vector3(0, 0, 0);
    public Quaternion _camRotation = new Quaternion(0, 0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = _distFromPlayer + _player.transform.position;
        //camera.transform.rotation = _camRotation;
    }
}
