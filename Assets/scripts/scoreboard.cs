using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreboard : MonoBehaviour
{
    //create public variable to track the score of the current game
    public static int score = 0;

    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 200, 100), "Score = " + score.ToString());
    }
}
