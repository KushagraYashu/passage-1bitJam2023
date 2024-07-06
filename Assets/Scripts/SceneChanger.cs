using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public bool left, right;

    public GameObject errorPanel;
    public PuzzleCheck puzzleCheck;
    public int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Player") && left)
        {
            Debug.Log("Change Scene");
            collision.gameObject.GetComponent<SoundManager>().LevelPass();
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(sceneIndex);
        }
        
        else if(collision.collider.gameObject.CompareTag("Player") && right)
        {
            Debug.Log("Init");
            if (puzzleCheck.PuzzlePassCheck())
            {
                collision.gameObject.GetComponent<SoundManager>().LevelPass();
                yield return new WaitForSeconds(1);
                SceneManager.LoadScene(sceneIndex);
            }
            else
            {
                var a = Instantiate(errorPanel);
                Destroy(a, 2f);
            }
        }
    }

}
