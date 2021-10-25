using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{



    public enum PlayerNumber { PlayerOne, PlayerTwo }

    [SerializeField]
    private Rigidbody rigid;

    [SerializeField]
    private float speed;

    [SerializeField]
    private PlayerInput playerInput;

    [SerializeField]
    private MeshRenderer spriteRenderer;

    [SerializeField]
    private Vector3 direction;



    // Start is called before the first frame update
    void Start()
    {

        spriteRenderer.material.color = Color.blue;

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }

    public void OnMove(InputValue value)
    {
        Debug.Log("Move: " + value.Get<Vector2>());
        var dir = value.Get<Vector2>();
        direction.x = dir.x;
        direction.z = dir.y;
    }



}
