using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class BluePointsCount : MonoBehaviour
{
    public TextMeshProUGUI BlueText;
    private float BlueScores;

    // Start is called before the first frame update
    void Start()
    {
        BlueScores = 0;
        BlueText.text = BlueScores.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            BlueScores += 10;
            BlueText.text = BlueScores.ToString();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            BlueScores += 80;
            BlueText.text = BlueScores.ToString();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            BlueScores = 0;
            BlueText.text = BlueScores.ToString();
        }
        if (Input.GetKeyDown(KeyCode.G) && BlueScores >= 10)
        {
            BlueScores -= 10;
            BlueText.text = BlueScores.ToString();
        }
        if (Input.GetKeyDown(KeyCode.H) && BlueScores >= 80)
        {
            BlueScores -= 80;
            BlueText.text = BlueScores.ToString();
        }
    }
}
