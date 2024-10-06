using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class DragSixxSix : MonoBehaviour
{
    public Sprite[] Levels;

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

            // بررسی اینکه آیا hit به یک جسم برخورد کرده است یا خیر
            if (hit.transform != null && hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<PiceseSixxSix>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PiceseSixxSix>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<PiceseSixxSix>().Selected = false;
                SelectedPiece = null;
            }
        }

        if (SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }

        if (PlacedPieces == 36)
        {
            if (EndMenu != null)
            {
                EndMenu.SetActive(true);
            }
            else
            {
                Debug.LogError("EndMenu is not assigned!");
            }
        }

    }
}