using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public void scale(float scale)
    {
        transform.localScale = new Vector2(1 / scale, 1 * scale);


    }
}