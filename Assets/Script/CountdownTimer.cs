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
        //dit laat de timer aftellen
        currentTime -= 1 * Time.deltaTime;
        CountDownText.text = currentTime.ToString("0");

        //dit zorgt voor de overgaan naar de eindscenes als de timer op 0 komt
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
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}