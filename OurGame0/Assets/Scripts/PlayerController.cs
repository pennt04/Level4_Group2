using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Transform _playerTransform;
    public Rigidbody2D _playerRB;

    Vector2 movement;

    [SerializeField] private float movementSpeed;


    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = transform;
        _playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");

    }

    private void FixedUpdate()
    {
        _playerRB.MovePosition(_playerRB.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}

