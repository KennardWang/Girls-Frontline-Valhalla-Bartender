using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class New_HK416 : MonoBehaviour {

    private int num1, numHK, num45, numJill;
    public GameObject Backbutton;
    public Text UMP45;
    public Text showText1, showText2, showText3;
    public string[] senHK416 = { "Such a marvelous feeling!",
                                 "Certainly, I guess you guys will enjoy the Carmen Fantasy!",
                                 "What？",
                                 "Ah...you don't know. So, let me tell you through my wonderful dance. Music."};

    public string[] senUMP45 = { "???...What are you doing, 416? ",
                                 "Please do not care, lady. 416 always has a lot of strange behaviors.",
                                 "My name is UMP45, the leader of 404 Squad, 416 is one of our team members.",
                                 "Sounds like good."};

    public string[] senJill = { "Are you OK, Ms.416?",
                                "Sorry, what do you mean?",
                                "Please forgive my stupidity, I am also confused about your words",
                                "...(Ms.416 is dancing with the music 'Carmen Fantasy') ",
                                "I feel sorry about that, your friend has lost her consciousness.",
                                "I see.",
                                "OK, Ms.UMP45, do you want a cup of Marsblast?"};

    // Use this for initialization
    void Start()
    {
        num1 = 0;
        numHK = 0;
        num45 = 0;
        numJill = 0;
        ChangeText();
        UMP45.gameObject.SetActive(false);
        Backbutton.gameObject.SetActive(false);

    }

    public void ChangeText()
    {
        if (num1 == 15)
        {
            SceneManager.LoadSceneAsync(14);
        }

        else
        {
            if (num1 >= 8)
            {
                UMP45.gameObject.SetActive(true);
                switch (num1 % 2)
                {
                    case 0:
                        {
                            showText2.gameObject.SetActive(true);
                            showText3.gameObject.SetActive(false);
                            showText2.text = senUMP45[num45];
                            ++num45;
                            ++num1;
                            break;
                        }

                    case 1:
                        {
                            showText3.gameObject.SetActive(true);
                            showText2.gameObject.SetActive(false);
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
                            showText3.gameObject.SetActive(false);
                            showText1.text = senHK416[numHK];
                            ++numHK;
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
        }
    }

    public void BackButton()
    {
        if (num1 < 8)
        {
            UMP45.gameObject.SetActive(false);
        }

        if (num1 <= 8)
        {

            if (num1 == 1)
            {
                Backbutton.gameObject.SetActive(false);
            }

            num1 = num1 - 1;
            --numHK;
            --numJill;
            --num1;
            ChangeText();

        }

        else
        {

            num1 = num1 - 1;
            --num45;
            --numJill;
            --num1;
            showText2.gameObject.SetActive(false);
            showText3.gameObject.SetActive(false);
            ChangeText();
        }

    }
}
