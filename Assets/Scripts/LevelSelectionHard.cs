using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionHard : MonoBehaviour
{
    public Button[] lvlButtons;
    void Start()
    {
        int levelHard = PlayerPrefs.GetInt("levelHard", 48);

        for (int i = 0; i < lvlButtons.Length; i++)
            if (i + 48 > levelHard)
                lvlButtons[i].interactable = false;
    }
}

