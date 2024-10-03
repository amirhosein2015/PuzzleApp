using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionEsay : MonoBehaviour
{
    public Button[] lvlButtons;
    void Start()
    {
        int levelEsay = PlayerPrefs.GetInt("levelEsay", 2);

        for (int i = 0; i < lvlButtons.Length; i++)
            if (i + 2 > levelEsay)
                lvlButtons[i].interactable = false;
    }
    }

    

