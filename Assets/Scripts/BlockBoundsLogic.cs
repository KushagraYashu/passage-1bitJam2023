using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBoundsLogic : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && collision.gameObject.GetComponent<PlayerBehaviour>().livesLeft >0)
        {
            collision.gameObject.GetComponent<SoundManager>().Hit();
            collision.gameObject.GetComponent<PlayerBehaviour>().DecreaseLives();
        }
    }
}
