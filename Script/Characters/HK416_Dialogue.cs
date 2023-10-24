using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HK416_Dialogue : MonoBehaviour {

    private int num1, numHK, numJill;
    public GameObject Backbutton;
    public Text showText1, showText2;
    public string[] senHK416 = { "It is unbelievable that there is a small inn here!",
                                 "Please do not misunderstand, my lady. I do not want to meet her.",
                                 "I don't care, but as you known. We combat dolls are not allowed to drink.",
                                 "I don't know, probably I exactly need some alcohol.",
                                 "I do not dislike stimulation, so this one please. "};

    public string[] senJill = { "Good Night, Ms.Hk416! I feel about sorry Ms.M16 has left just now. If you...",                              "Well, mind a few rounds of Whisky?",
                                "Well, I see. So mind enjoying some glass?",
                                "So what's your purpose being here?",
                                "OK, to your satisfaction. What about Bad Touch? You will feel like being ravished.",
                                "Okay, 5-minute waiting."};


    // Use this for initialization
    void Start()
    {
        num1 = 0;
        numHK = 0;
        numJill = 0;
        ChangeText();
        Backbutton.gameObject.SetActive(false);

    }

    public void ChangeText()
    {
        if (num1 == 10)
        {
            SceneManager.LoadSceneAsync(11);
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
                        showText1.text = senHK416[numHK];
                        ++numHK;
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
        --numHK;
        --numJill;
        --num1;
        ChangeText();

    }
}
