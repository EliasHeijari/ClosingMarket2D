using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [Header("Positions")]
    [SerializeField] private Vector3 startPos = Vector3.zero;
    [SerializeField] private Vector3 endPos = Vector3.zero;

    [Header("Movement")]
    [SerializeField] private float speed = 4f;

    private void Update() {
        transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, endPos) < 0.1f)
        {
            transform.position = startPos;
        }
    } 
}
