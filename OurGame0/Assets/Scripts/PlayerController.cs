using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Transform _playerTransform;
    private Rigidbody2D _playerRB;

    [SerializeField] private float movementSpeedY;
    [SerializeField] private float movementSpeedX;


    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = transform;
        _playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float translationY = Input.GetAxis("Vertical");
        float translationX = Input.GetAxis("Horizontal");

        translationY *= Time.deltaTime * movementSpeedY;
        translationX *= Time.deltaTime * movementSpeedX;
    }
}

