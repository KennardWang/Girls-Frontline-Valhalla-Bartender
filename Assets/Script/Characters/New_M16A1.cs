using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class New_M16A1 : MonoBehaviour {

    private int num1, numM16, numJill;
    public GameObject Backbutton;
    public Text showText1, showText2;
    public string[] senM16a1 = { "M4, M4, my dear younger sis...I...",
                                 "Oh,M4. Please combine with me...Please not run, M4!",
                                 "Why do you cry, M4? Did the commander tease you? Do not be afraid, I will help you to revenge. "};

    public string[] senJill = { "It seems like that alcohol can easily make someone intoxicated. ",
                                "It sounds like more ridiculous.",
                                "I hope that their commander will be safe and sound. Oh, next guest is coming! "};


    // Use this for initialization
    void Start()
    {
        num1 = 0;
        numM16 = 0;
        numJill = 0;
        ChangeText();
        Backbutton.gameObject.SetActive(false);

    }

    public void ChangeText()
    {
        if (num1 == 6)
        {
            SceneManager.LoadSceneAsync(10);
        }

        else
        {
            if (num1 == 0)
            {
                Backbutton.gameObject.SetActive(false);
            }

            if (num1 > 0)
            {
                Backbutton.gameObject.SetActive(true);
            }

            switch (num1 % 2)
            {
                case 0:
                    {
                        showText1.gameObject.SetActive(true);
                        showText2.gameObject.SetActive(false);
                        showText1.text = senM16a1[numM16];
                        ++numM16;
                        ++num1;
                        break;
                    }

                case 1:
                    {
                        showText2.gameObject.SetActive(true);
                        showText1.gameObject.SetActive(false);
                        showText2.text = senJill[numJill];
                        ++numJill;
                        ++num1;
                        break;
                    }

            }

        }
    }

    public void BackButton()
    {

        if (num1 == 1)
        {
            Backbutton.gameObject.SetActive(false);
        }

        num1 = num1 - 1;
        --numM16;
        --numJill;
        --num1;
        ChangeText();

    }
}
