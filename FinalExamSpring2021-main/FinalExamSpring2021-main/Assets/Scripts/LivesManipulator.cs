using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManipulator : MonoBehaviour
{
    public void AddLife()
    {
        Score.Lives++;
    }
    public void LoseLife()
    {
        if (Score.Lives > 0)
        {
            Score.Lives--;
        }
    }
}
