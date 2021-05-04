using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManipulator : MonoBehaviour
{
    public void AddPoint()
    {
        Score.CurrentScore++;
    }
    public void LosePoint()
    {
        if (Score.CurrentScore > 0)
        {
            Score.CurrentScore--;
        }
    }
}
