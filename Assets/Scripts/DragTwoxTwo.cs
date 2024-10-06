
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;


public class DragTwoxTwo : MonoBehaviour
{

    //public Sprite[] Levels;

    public GameObject EndMenu;
    public GameObject SelectedPiece;
    int OIL = 1;
    public int PlacedPieces = 0;

    void Start()
    {

      
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<PiceseTwoxTwo>().InRightPosition)
                {

                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PiceseTwoxTwo>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;



                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<PiceseTwoxTwo>().Selected = false;
                SelectedPiece = null;

            }
        }
        if (SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);

        }
        if (PlacedPieces == 4)
        {

            EndMenu.SetActive(true);
        }
    }
}
