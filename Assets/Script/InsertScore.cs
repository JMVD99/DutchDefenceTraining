using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InsertScore : MonoBehaviour
{
    public InputField PlayerField;
    public InputField ScoreField;

    public Button Submit;

    public void CallScore()
    {
        StartCoroutine(Score());
    }

    //dit zorgt ervoor dat er waardes van unity naar de PHP server worden gestuurd
    IEnumerator Score()
    {
        WWWForm form = new WWWForm();
        form.AddField("Player", PlayerField.text);
        form.AddField("Score", ScoreField.text);
        WWW www = new WWW("http://localhost/GameDB/AddScore.php", form);
        yield return www;
    }
}

