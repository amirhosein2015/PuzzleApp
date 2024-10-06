using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextPreviousLevel : MonoBehaviour
{

	int totalScenes = 45;


	public void Next_Level()
	{
		//active scene
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

		//check if final level
		if (currentSceneIndex < totalScenes - 1)
		{
		
			SceneManager.LoadScene(currentSceneIndex + 1);
		}
		else
		{
			
			Debug.Log("The End");
		
		}



	}






//----------------------------------------




	public void pre_Level()
	{
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		if (currentSceneIndex > 0)
		{
			
			SceneManager.LoadScene(currentSceneIndex - 1);
		}
		else
		{
			
			Debug.Log("first level");
		
		}


	}

//-------------------------------------------------


	public void Rsest_Level()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}




}
