using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Jump
    public Rigidbody2D player;
    public float moveSpeed;
    public float jumpPower;
    float targetMoveSpeed;

    //isGrounded
    public bool isGrounded;
    public LayerMask groundLayers;

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationVector = transform.rotation.eulerAngles;
        rotationVector.x = 0;
        rotationVector.z = 0;
        transform.rotation = Quaternion.Euler(rotationVector);

        player = GetComponent<Rigidbody2D>();
        //isGrounded?
        Physics2D.OverlapArea(new Vector2(transform.position.x - .5f, transform.position.y - .5f),
            new Vector2(transform.position.x + .5f, transform.position.y - .51f), groundLayers);

        //Movement of player
        targetMoveSpeed = Mathf.Lerp(player.velocity.x, Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, Time.deltaTime * 10);
        player.velocity = new Vector2(targetMoveSpeed, player.velocity.y);

        //Let Player Jump
        if (Input.GetKeyDown(KeyCode.Space)  && isGrounded == true)
        {
            player.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }
}
