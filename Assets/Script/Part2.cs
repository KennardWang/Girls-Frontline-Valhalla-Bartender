using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Part2 : MonoBehaviour {

    // initialization   
    private int num;
    private bool stateice, stateaging;
    private int Time1, Time2, Time3, Time4, Time5;
    public Text ValueText1, ValueText2, ValueText3, ValueText4, ValueText5, TextGuest, TextFeedback;
    public Toggle Iceto;
    public Toggle Agingto;
    public bool Icebo;
    public bool Agingbo;

    public string[] beverage = { "Bloom Light", "1", "Bad Touch", "Blue Fairy" };
    public int[] Rednum = { 4, 0, 0, 4 };
    public int[] Yellownum = { 0, 6, 2, 0 };
    public int[] Bluenum = { 1, 1, 2, 0 };
    public int[] Greennum = { 2, 4, 2, 1 };
    public int[] Cyannum = { 3, 2, 4, 1 };
    public bool[] Icestate = { true, false, true, false };
    public bool[] Agingstate = { true, false, false, true };

    public void Cleartoggle()
    {
        Iceto.isOn = false;
        Agingto.isOn = false;
    }

    public void Refresh()
    {    
        stateice = false; stateaging = false;
        Icebo = false; Agingbo = false;
       
        Time1 = Time2 = Time3 = Time4 = Time5 = 0;
        ValueText1.text = ValueText2.text = ValueText3.text = ValueText4.text = ValueText5.text = "Add";
        
    }

    
    void Start()
    {
        num = 0;
        TextGuest.text = "Beverage Requirement: " + beverage[num];
        Iceto.isOn = false;
        Agingto.isOn = false;
        Refresh();

        TextFeedback.text = "Feedback: ";
      
    }


    public void ButtonClick1()
    {
        ValueText1.text = (++Time1).ToString();
    }

    public void ButtonClick2()
    {
        ValueText2.text = (++Time2).ToString();
    }

    public void ButtonClick3()
    {
        ValueText3.text = (++Time3).ToString();
    }

    public void ButtonClick4()
    {
        ValueText4.text = (++Time4).ToString();
    }

    public void ButtonClick5()
    {
        ValueText5.text = (++Time5).ToString();
    }

    public void ResetButtonClick()
    {
        Cleartoggle();
        Refresh();
        TextFeedback.text = "Feedback: ";
        
    }

    public void IceClick()
    {
        if(stateice)
        {
            Icebo = false;
        }

        else
        {
            Icebo = true;
        }
        stateice = !stateice;
    }

    public void AgingClick()
    {
        if (stateaging)
        {
            Agingbo = false;
        }

        else
        {
            Agingbo = true;
        }
        stateaging = !stateaging;
    }

    public void Confirmation()
    {
      
        if ((Time1 == Rednum[num]) && (Time2 == Yellownum[num]) && (Time3 == Bluenum[num]) && (Time4 == Greennum[num]) && (Time5 == Cyannum[num]) && (Icebo == Icestate[num]) && (Agingbo == Agingstate[num]))
        {
            SceneManager.LoadSceneAsync(4);
        }

        else
        {
            TextFeedback.text = "Fail! It seems not to be her flavor. I am supposed to try again!";

            Cleartoggle();
            Refresh();

        }
    }

    
}
