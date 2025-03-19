using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TeamNameChanger : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public TextMeshProUGUI TimerText;

    public void ChangeLabel()
    {
        if (dropdown.value == 0)
        {
            TimerText.text = "キアイダケ";
            TimerText.fontSize = 26;
        }
        else if (dropdown.value == 1)
        {
            TimerText.text = "蟹九里以無個論ｯ剣";
            TimerText.fontSize = 19;
        }
        else if (dropdown.value == 2)
        {
            TimerText.text = "風神";
            TimerText.fontSize = 26;
        }
        else if (dropdown.value == 3)
        {
            TimerText.text = "おたまじゃくしず";
            TimerText.fontSize = 21;
        }
        else if (dropdown.value == 4)
        {
            TimerText.text = "ぴかぴかのいちねんせい";
            TimerText.fontSize = 15;
        }
    }
}
