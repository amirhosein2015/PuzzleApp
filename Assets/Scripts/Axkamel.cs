using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axkamel : MonoBehaviour
{
    [SerializeField] private GameObject nemoneax;
    [SerializeField] private int timer;


    void Start()
    {
        StartCoroutine(HideObjects());
    }

    IEnumerator HideObjects()
    {

        yield return new WaitForSeconds(1.2f);
        nemoneax.SetActive(false);

    }


}