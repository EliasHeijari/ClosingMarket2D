using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float speed = 6f;
    private void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
        transform.Rotate(Vector3.forward * speed * 60 * Time.deltaTime);
    }
}
