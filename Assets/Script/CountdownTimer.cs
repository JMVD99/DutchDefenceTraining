using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 120f;



    [SerializeField] Text CountDownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountDownText.text = currentTime.ToString("0");

        if (currentTime <= 0 && ScoreScript.scoreValue < 150)
        {
            currentTime = 0;

            //laad level met scene name
            SceneManager.LoadScene("eindscerm");
        }
        else if (currentTime <= 0 && ScoreScript.scoreValue > 150)
        {
            currentTime = 0;

            //laad level met scene name
            SceneManager.LoadScene("SubmitScoreEnd");
        }
    }
}