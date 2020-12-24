using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDeflate : MonoBehaviour
{
    Rigidbody rb;
    Vector3 _startPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        _startPos = this.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindGameObjectWithTag("Spikes") == other.gameObject)
        {
            this.transform.position = _startPos;
            rb.velocity = Vector3.zero;
        }
        else
        {
            Debug.Log("No Hit");
        }
    }
}
