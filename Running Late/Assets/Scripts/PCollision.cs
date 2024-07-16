using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCollision : MonoBehaviour
{
    public GameManager gameManager;
    private bool isDead;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Obstacle" && !isDead)
        {
            isDead = true;
            Destroy(gameObject);
            gameManager.gameOver();
        }
    }
}
