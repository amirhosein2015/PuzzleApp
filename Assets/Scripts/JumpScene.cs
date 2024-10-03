using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JumpScene : MonoBehaviour
{
    [SerializeField]
    private string sceneNameToLoad;


    public void JumpToScene()

    {
        SceneManager.LoadScene(sceneNameToLoad);


    }
}
