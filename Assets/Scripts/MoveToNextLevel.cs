using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{

    public int nextSceneLoad;


    void Start()
    {

        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }




//--------------------------------------------
//UnlockSpringEsay
    public void UnlockEsay()
    {
        //move to next level
        SceneManager.LoadScene(nextSceneLoad);


        //Setting Int for Index
        if (nextSceneLoad > PlayerPrefs.GetInt("levelEsay"))
        {
            PlayerPrefs.SetInt("levelEsay", nextSceneLoad);
        }
    }


//--------------------------------------------------------------------------



    public void UnlockHard()
    {
        //move to next level
        SceneManager.LoadScene(nextSceneLoad);


        //Setting Int for Index
        if (nextSceneLoad > PlayerPrefs.GetInt("levelHard"))
        {
            PlayerPrefs.SetInt("levelHard", nextSceneLoad);
        }
    }




    //------------------------------------------------------------------







}



