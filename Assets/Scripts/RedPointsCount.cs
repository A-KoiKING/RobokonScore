using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class RedPointsCount : MonoBehaviour
{
    public TextMeshProUGUI RedText;
    private float RedScores;

    // Start is called before the first frame update
    void Start()
    {
        RedScores = 0;
        RedText.text = RedScores.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            RedScores += 10;
            RedText.text = RedScores.ToString();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            RedScores += 80;
            RedText.text = RedScores.ToString();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            RedScores = 0;
            RedText.text = RedScores.ToString();
        }
        if (Input.GetKeyDown(KeyCode.A) && RedScores >= 10)
        {
            RedScores -= 10;
            RedText.text = RedScores.ToString();
        }
        if (Input.GetKeyDown(KeyCode.S) && RedScores >= 80)
        {
            RedScores -= 80;
            RedText.text = RedScores.ToString();
        }
    }
}
