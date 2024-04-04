using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public double battlechance = 1;
    

    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        if(movement.x != 0 || movement.y != 0)
        {
            var randint = Random.Range(1, 100);
            if(randint <= battlechance && randint > 0)
            {
                battlechance = 1;
                SceneManager.LoadScene("BattleScene");
            }
            else
            {
                battlechance += 0.001;
            }
        }
    }
}
