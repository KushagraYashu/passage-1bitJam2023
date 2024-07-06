using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Switch : MonoBehaviour
{
    
    public Material levelMaterial;
    public GameObject targetBoundLogic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            targetBoundLogic.GetComponent<BlockBoundsLogic>().enabled = false;
            targetBoundLogic.GetComponent<SpriteRenderer>().material = levelMaterial;
            targetBoundLogic.GetComponent<BoxCollider2D>().isTrigger = true;
            
            this.gameObject.SetActive(false);
        }
    }

}
