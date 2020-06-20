using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class New_M4A1 : MonoBehaviour {

    private int num1, numM4, numJill;
    public GameObject Backbutton;
    public Text showText1, showText2;
    public string[] senM4a1 = { "Marvelous! According to Bloom Light, I feel more energetic. ",
                                "Definitely. She has been here. But now it is the more mature M4.",
                                "Wait. What's the matter about the noise? "};

    public string[] senJill = { "W...Wait! Has Ms.M4A1 been here? ",
                                "Ah...ha.(I can't even believe that the combat doll has two different persona.)"};


    // Use this for initialization
    void Start()
    {
        num1 = 0;
        numM4 = 0;
        numJill = 0;
        ChangeText();
        Backbutton.gameObject.SetActive(false);

    }

    public void ChangeText()
    {
        if (num1 == 5)
        {
            SceneManager.LoadSceneAsync(6);
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
                        showText1.text = senM4a1[numM4];
                        ++numM4;
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
        --numM4;
        --numJill;
        --num1;
        ChangeText();

    }
}
