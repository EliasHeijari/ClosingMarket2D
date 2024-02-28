using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;

    [Header("Settings")]
    [SerializeField] private float jumpForce = 6f;
    [SerializeField] private float groundCheckRadius = 0.1f;

    public bool isGrounded {get; private set; }

    // Update is called once per frame
    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(groundCheck.position, groundCheckRadius);
    }

    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.TryGetComponent(out Obstacle obstacle))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
