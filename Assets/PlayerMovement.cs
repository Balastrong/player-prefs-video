using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  private float _speed = 5f;
  private Rigidbody2D _rb;
  private Vector2 _movement;

  void Start()
  {
    _rb = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    _movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
  }

  void FixedUpdate()
  {
    _rb.MovePosition(_rb.position + _movement * _speed * Time.fixedDeltaTime);
  }
}
