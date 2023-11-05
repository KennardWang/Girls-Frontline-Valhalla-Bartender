using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jill_Dialogue : MonoBehaviour {

    // the operation info
    private int num;
    public Text showText;
    public GameObject Backbutton;
    public string[] oper_info = { "My name is Jill, a mundane bartender of Valhalla.",
                                  "Today is my first day at work. So I must be tremendously serious. ",
                                  "After all, most of my guests are from Griffin. Oh, god! ",
                                  "Although these charming girls are easy to get along with, I am still worried about their powerful weapons!",
                                  "Why don't we build a rule about weapon permission?",
                                  "In a short, it would be better to review the steps of wine making. ",
                                  "At first, our cute guests will tell us what they would like, and we can find the dosing of ingredients.",
                                  "And then, it will be easy, we just need to add them to the proper amount, choose 'Confirmation' eventually.",
                                  "Of course, we can 'reset' all of the ingredients whenever we make a mistake accidentally.",
                                  "That's all. Oh, look! Our first cute guest is coming!"               };

    
    void Start()
    {
        num = 0;
        ButtonNext();
        Backbutton.gameObject.SetActive(false);
    }

    public void ButtonNext () {

        if (num == 10)
        {
            SceneManager.LoadSceneAsync(2);
        }

        showText.text = oper_info[num];
        ++num;

        if(num > 0)
        {
            Backbutton.gameObject.SetActive(true);
        }
        

	}

    public void BackButton()
    {
        
        if (num == 2)
        {
            Backbutton.gameObject.SetActive(false);
        }

        num = num - 2;
        showText.text = oper_info[num];
        ++num;

        

    }

   
}
