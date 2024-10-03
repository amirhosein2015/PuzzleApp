
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MainManager : MonoBehaviour
{

    public GameObject Mainpage;
    //public GameObject Menupage;//
    public GameObject Exitpage;
    public GameObject Aboutpage;
    public GameObject Guidepage;

    public GameObject Diffculti;
   


    void Start()
    {
        Mainpage.SetActive(true);
        Exitpage.SetActive(false);
        //Menupage.SetActive(false);
        Aboutpage.SetActive(false);
        Guidepage.SetActive(false);
        Diffculti.SetActive(false);
      

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Mainpage.SetActive(false);
            //Menupage.SetActive(false);
            Exitpage.SetActive(true);
            Guidepage.SetActive(false);
            Diffculti.SetActive(false);
          

        }


    }
    public void EdamehDadan()
    {
        Exitpage.SetActive(false);
        //Menupage.SetActive(false);
        Mainpage.SetActive(true);
        Guidepage.SetActive(false);
        Diffculti.SetActive(false);
      

    }

    public void firstExit()

    {
        Mainpage.SetActive(false);
        //Menupage.SetActive(false);
        Exitpage.SetActive(true);
        Guidepage.SetActive(false);
        Diffculti.SetActive(false);
   
    }


    public void Quit()

    {
        Application.Quit();

    }


    public void shoroh()
    {
        Mainpage.SetActive(false);
        //Menupage.SetActive(true);
        Exitpage.SetActive(false);
        Guidepage.SetActive(false);
        Diffculti.SetActive(false);
     
    }



    public void Diffcult()
    {
        Mainpage.SetActive(false);
        //Menupage.SetActive(false);
        Exitpage.SetActive(false);
        Guidepage.SetActive(false);
        Diffculti.SetActive(true);
        
    }









    public void BackOfMain()
    {
        Mainpage.SetActive(true);
        //Menupage.SetActive(false);
        Exitpage.SetActive(false);
        Aboutpage.SetActive(false);
        Diffculti.SetActive(false);
      
        Guidepage.SetActive(false);
    }








    public void AboutUs()
    {

        Aboutpage.SetActive(true);
        Mainpage.SetActive(false);
        Guidepage.SetActive(false);
    }

    public void ExitAboutUs()
    {
        Aboutpage.SetActive(false);


    }


    public void GuidePage()

    {


        Mainpage.SetActive(false);
        //Menupage.SetActive(false);
        Exitpage.SetActive(false);
        Guidepage.SetActive(true);
        Diffculti.SetActive(false);
    


    }



    public void ExitOfGuidePage()

    {


        Mainpage.SetActive(true);
        //Menupage.SetActive(false);
        Exitpage.SetActive(false);
        Guidepage.SetActive(false);
        Diffculti.SetActive(false);
       


    }




}
