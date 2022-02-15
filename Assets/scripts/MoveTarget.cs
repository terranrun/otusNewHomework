using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] private CharacterController _controller;
    [SerializeField] private float _speed =3f;

    // Update is called once per frame
    void Update()
    {
        float MoveY = Input.GetAxis("Vertical");
        float MoveX = Input.GetAxis("Horizontal");
        direction = new Vector3(MoveY, MoveX, 0);
        direction = transform.TransformDirection(direction) * _speed;
        _controller.Move(direction * Time.deltaTime);
    }
}
