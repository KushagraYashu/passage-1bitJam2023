using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BonusScene : MonoBehaviour
{
    public GameObject errorPanel;
    public GameObject bonusPanel;

    public PuzzleCheck puzzleCheck;

    public int sceneIndex;

    private IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if (puzzleCheck.PuzzlePassCheck())
        {
            bonusPanel.SetActive(true);
            collision.gameObject.GetComponent<SoundManager>().LevelPass();
            yield return new WaitForSeconds(1);
            //SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            var a = Instantiate(errorPanel);
            Destroy(a, 2f);
        }
    }

    public void YesButton()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
