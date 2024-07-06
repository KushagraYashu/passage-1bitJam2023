using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCheck : MonoBehaviour
{

    public List<AllowBoundsLogic> allowElements; 
    public bool puzzlePassed = false;

    
    public bool PuzzlePassCheck()
    {
        foreach (var element in allowElements)
        {
            if (!element.passed)
            {
                return false;
            }
            
        }
        return true;
    }
}
