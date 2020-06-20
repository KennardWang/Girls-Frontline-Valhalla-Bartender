using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UMP45 : MonoBehaviour {

	private int num1, num45, numJill;
    public GameObject Backbutton;
    public Text showText1, showText2;
    public string[] senUMP45 = { "You're very good at bartending, Ms. Jill.",
                                 "It's getting dark, we should return our command center.",
                                 "Thank you, she is OK."};

    public string[] senJill = { "Thank you very much, Ms.45. ",
                                "Tell the truth, I still worry about Ms.416.",
                                "I will be gald to see you next time, Ms.45."};


    // Use this for initialization
    void Start()
    {
        num1 = 0;
        num45 = 0;
        numJill = 0;
        ChangeText();
        Backbutton.gameObject.SetActive(false);

    }

    public void ChangeText()
    {
        if (num1 == 6)
        {
            SceneManager.LoadSceneAsync(17);
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
                        showText1.text = senUMP45[num45];
                        ++num45;
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
        --num45;
        --numJill;
        --num1;
        ChangeText();

    }
}
