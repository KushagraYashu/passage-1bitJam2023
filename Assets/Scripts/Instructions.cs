using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public GameObject insPanel;   

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            insPanel.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        insPanel.SetActive(false);
    }
}
