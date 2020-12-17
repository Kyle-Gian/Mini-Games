using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 3f;

    [SerializeField]
    private int playerIndex = 0;

    private Vector3 _moveDirection = Vector3.zero;
    private Vector2 _inputVector = Vector2.zero;
    Rigidbody rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SetInputVector(Vector2 direction)
    {
        _inputVector = direction;
    }

    public int GetPlayerIndex()
    {
        return playerIndex;
    }

    // Update is called once per frame
    void Update()
    {
        _moveDirection = new Vector3(_inputVector.y, 0, -_inputVector.x);
        //_moveDirection = transform.TransformDirection(_moveDirection);
        _moveDirection *= _moveSpeed;
        rb.AddForce(_moveDirection * Time.deltaTime);
    }
}
