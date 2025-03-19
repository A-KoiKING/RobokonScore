using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    public float TimeCount;
    public bool enable;
    public bool count;
    AudioSource audioSource;
    public AudioClip countdown;
    public AudioClip jingle;

    // Start is called before the first frame update
    void Start()
    {
        TimeCount = 0;
        enable = false;
        count = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            TimeCount = 0;
            enable = false;
            count = false;
            audioSource.Stop();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            audioSource.PlayOneShot(jingle);
        }

        if (enable)
        {
            if (TimeCount < 155)
            {
                TimeCount += Time.deltaTime;

                TimerText.fontSize = 135;
                TimerText.text = string.Format(
                    "{0:D1}:{1:D2}",
                    (int)(TimeCount-5) / 60,
                    (int)(TimeCount-5) % 60
                );
            }

            if (TimeCount < 1)
            {
                TimerText.text = "5";
            }
            else if (TimeCount < 2)
            {
                TimerText.text = "4";
            }
            else if (TimeCount < 3 )
            {
                TimerText.text = "3";
                if (count == false)
                {
                    audioSource.PlayOneShot(countdown);
                    count = true;
                }
            }
            else if (TimeCount < 4)
            {
                TimerText.text = "2";
                count = false;
            }
            else if (TimeCount < 5)
            {
                TimerText.text = "1";
            }
            else if (TimeCount < 7)
            {
                TimerText.fontSize = 100;
                TimerText.text = "START";
            }

            if (TimeCount > 152 && count == false)
            {
                TimerText.color = Color.yellow;
                audioSource.PlayOneShot(countdown);
                count = true;
            }
            else if (TimeCount > 155)
            {
                TimerText.color = Color.red;
            }
        }
        else
        {
            TimerText.fontSize = 100;
            TimerText.text = "READY";
                
            if (Input.GetKeyDown(KeyCode.Space))
            {
                enable = true;
            }
        }
    }
}
