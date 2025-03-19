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
            TimerText.text = "�L�A�C�_�P";
            TimerText.fontSize = 26;
        }
        else if (dropdown.value == 1)
        {
            TimerText.text = "�I�㗢�Ȗ��_���";
            TimerText.fontSize = 19;
        }
        else if (dropdown.value == 2)
        {
            TimerText.text = "���_";
            TimerText.fontSize = 26;
        }
        else if (dropdown.value == 3)
        {
            TimerText.text = "�����܂��Ⴍ����";
            TimerText.fontSize = 21;
        }
        else if (dropdown.value == 4)
        {
            TimerText.text = "�҂��҂��̂����˂񂹂�";
            TimerText.fontSize = 15;
        }
    }
}
