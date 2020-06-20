using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class M16A1_Dialogue : MonoBehaviour {

    private int num1, numM16, numM4, numJill;
    public GameObject Backbutton;
    public Text Jill;
    public Text showText1, showText2, showText3;
    public string[] senM16a1 = { "What are you doing, M4?",
                                 "I told you that you should keep away from alcohol. Forgot, didn't you?",
                                 "What？",
                                 "You 're so erudite, my lady. However, it doesn't mean \"well\" sometimes.",
                                 "If you refer to the alcohol, I don't care. But I am supposed to remind you, PLEASE DO NOT DO SOMETHING STRANGE ON MY GIRL!",
                                 "I think Blue Fairy is beneficial to relax myself."};

    public string[] senM4a1 = { "Er...sis M16.... ",
                                "Sorry, sis, but I think this kind of wine doesn't make influence."};

    public string[] senJill = { "Hello, Ms.M16,welcome to Valhalla, I conjecture that you feel tired after coming back from 0-2.",
                                "Thank you for your sincere advice, and do you mind getting some?",
                                "(Probably she also acts herself like this in daily life!) Well, what would you like？",
                                "OK, please wait a moment.(What? There must be something wrong with my ears!) "};

    // Use this for initialization
    void Start()
    {
        num1 = 0;
        numM16 = 0;
        numM4 = 0;
        numJill = 0;
        ChangeText();
        Jill.gameObject.SetActive(false);
        Backbutton.gameObject.SetActive(false);

    }

    public void ChangeText()
    {
        if (num1 == 12)
        {
            SceneManager.LoadSceneAsync(7);
        }

        else
        {
            if (num1 >= 5)
            {
                Jill.gameObject.SetActive(true);
                switch (num1 % 2)
                {
                    case 0:
                        {
                            showText1.gameObject.SetActive(true);
                            showText3.gameObject.SetActive(false);
                            showText1.text = senM16a1[numM16];
                            ++numM16;
                            ++num1;
                            break;
                        }

                    case 1:
                        {
                            showText3.gameObject.SetActive(true);
                            showText1.gameObject.SetActive(false);
                            showText3.text = senJill[numJill];
                            ++numJill;
                            ++num1;
                            break;
                        }

                }


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
                            showText2.text = senM4a1[numM4];
                            ++numM4;
                            ++num1;
                            break;
                        }

                }

            }
        }
    }

    public void BackButton()
    {
        if(num1 < 5)
        {
            Jill.gameObject.SetActive(false);
        }

        if (num1 <= 5)
        {
            
            if (num1 == 1)
            {
                Backbutton.gameObject.SetActive(false);
            }

            num1 = num1 - 1;
            --numM16;
            --numM4;
            --num1;
            ChangeText();
           
        }

        else
        {
        
            num1 = num1 - 1;
            --numM16;
            --numJill;
            --num1;
            showText1.gameObject.SetActive(false);
            showText3.gameObject.SetActive(false);
            ChangeText();
        }

    }
}
