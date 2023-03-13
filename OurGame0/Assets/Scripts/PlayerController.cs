using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Transform _playerTransform;
    public Rigidbody2D _playerRB;
    [SerializeField] private float _movementSpeed;
    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = transform;
        _playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //get player's positon
        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    // FixedUpdate is called every fixed framerate frame
    private void FixedUpdate()
    {
        //apply movement  to player
        _playerRB.MovePosition(_playerRB.position + movement * _movementSpeed * Time.fixedDeltaTime);
    }
}