using UnityEngine;
using UnityEngine.UI;

public class SelectLives : MonoBehaviour
{
    public Dropdown PickLives;
    public static int Lives;

    public void Start()
    {
        Lives = 3;
    }
    public void ChangeLives()
    {

        switch (PickLives.value)
        {
            case 1:
                Debug.Log("1 Life Selected");
                Lives = 1;
                Score.Lives = 1;

                break;
            case 2:
                Debug.Log("2 Lives Selected");
                Lives = 2;
                Score.Lives = 2;
                break;
            case 3:
                Debug.Log("3 Lives Selected");
                Lives = 3;
                Score.Lives = 3;
                break;
            case 4:
                Debug.Log("4 Life Selected");
                Lives = 4;
                Score.Lives = 4;

                break;
            case 5:
                Debug.Log("5 Lives Selected");
                Lives = 5;
                Score.Lives = 5;
                break;
            case 6:
                Debug.Log("6 Lives Selected");
                Lives = 6;
                Score.Lives = 6;
                break;
            case 7:
                Debug.Log("7 Life Selected");
                Lives = 7;
                Score.Lives = 7;

                break;
            case 8:
                Debug.Log("8 Lives Selected");
                Lives = 8;
                Score.Lives = 8;
                break;
            case 9:
                Debug.Log("9 Lives Selected");
                Lives = 9;
                Score.Lives = 9;
                break;
            default:
                Debug.Log("Please select amount of lives");
                Lives = 3;
                Score.Lives = 3;
                break;
        }
    }

}