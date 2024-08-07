using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rd;
    [SerializeField] float jump = 10f;
    [SerializeField] LayerMask sidewalk;
    [SerializeField] Transform fposition;
    [SerializeField] float gDistance = 0.25f;
    [SerializeField] float jTime = 0.3f;

    private bool isTouchingGround = false;
    private bool isJumping = false;
    [SerializeField] private float jTimer;
    AudioSource jumpSFX;

    private void Start()
    {
        jumpSFX = GetComponent<AudioSource>();
    }
    private void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(fposition.position, gDistance, sidewalk);

        if(isTouchingGround && Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            rd.velocity = Vector2.up * jump;
        }

        if (isJumping && Input.GetButton("Jump"))
        {
            if(jTimer < jTime)
            {
                rd.velocity = Vector2.up * jump;

                jTimer += Time.deltaTime;
                jumpSFX.Play();
            } else
            {
                isJumping = false;
            }
        }

        if(Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            jTimer = 0;
        }
    }
}
