﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin1 : MonoBehaviour
{
  public float speed = 20f;
  public Rigidbody2D rb;

  void Update(){

      rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);

  }
}
