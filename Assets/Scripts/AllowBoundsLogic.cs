using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowBoundsLogic : MonoBehaviour
{
    public bool passed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            passed = true;
        }
    }

}
