using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    [SerializeField]private Transform _tr;
    [SerializeField] private Rigidbody _rb;
    void MovePlayer(float a, float b)
    {
        _rb.AddForce(new Vector3(a, 0, b) * 12f);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            MovePlayer(0.5f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(-0.5f, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(0, -0.5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(0, 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.Space) && _tr.position.y <= 10)
        {
            _rb.AddForce(0, 8, 0, ForceMode.Impulse);
        }
    }
}
