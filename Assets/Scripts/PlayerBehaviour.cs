using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject deadScreen;
    
    
    public TextMeshProUGUI livesTxt;



    bool dead = false;

    public int maxLives;
    public int livesLeft;

    public float speed;
   
    float verticalInput;
    float horizontalInput;
    

   


    // Start is called before the first frame update
    void Start()
    {
        livesLeft = maxLives;
        livesTxt.text = "- "+ livesLeft;
    }


    private void Update()
    {
        if (livesLeft <= 0 && !dead)
        {
            livesTxt.text = "- " + livesLeft;
            deadScreen.SetActive(true);
            Debug.Log("DED");
            dead = true;
            this.enabled = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        horizontalInput = Input.GetAxis("Horizontal") * speed;
        verticalInput = Input.GetAxis("Vertical") * speed;
               
        if (Mathf.Abs(verticalInput) >= 0.3 || Mathf.Abs(horizontalInput) >= 0.3)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontalInput, verticalInput));

        }
        else if (Mathf.Abs(verticalInput) < 0.3 && Mathf.Abs(horizontalInput) < 0.3)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontalInput / 5, verticalInput / 5));

        }
    }

    public void DecreaseLives()
    {
        
        livesLeft--;
        livesTxt.text = "- " + livesLeft;
    }

    public void ResetLives()
    {
        livesLeft = maxLives;
        livesTxt.text = "- " + livesLeft;
    }


}

