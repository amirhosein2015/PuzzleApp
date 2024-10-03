using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiceseTwoxTwo : MonoBehaviour

{

    public AudioSource source;
    public AudioClip tik;
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(4f, 10f), Random.Range(1f, -5f));
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, RightPosition) < 0.5f)
        {
            if (!Selected)
            {
                if (InRightPosition == false)
                {
                    transform.position = RightPosition;
                    InRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    Camera.main.GetComponent<DragTwoxTwo>().PlacedPieces++;
                    source.clip = tik;
                    source.Play();

                }
            }
        }
    }
}
