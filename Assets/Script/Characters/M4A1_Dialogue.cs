using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class M4A1_Dialogue : MonoBehaviour {

    private int num1, numM4, numJill;
    public GameObject Backbutton;
    public Text showText1, showText2;
    public string[] senM4a1 = { "Mission Clear! Next time I will do better!",
                                "Ah, I have gone on patrol, nothing is abnormal.",
                                "Compared to Whisky, I prefer Bloom Light. After all, this type could keep me calm."};

    public string[] senJill = { "Good Night, M4A1! Have you finished your work? ",
                                "Well, mind a few rounds of Whisky?",
                                "I see, our cute lady wants a glass of Bloom Light."};


    // Use this for initialization
    void Start () {
        num1 = 0;
        numM4 = 0;
        numJill = 0;
        ChangeText();
        Backbutton.gameObject.SetActive(false);

    }

    public void ChangeText()
    {
        if (num1 == 6)
        {
            SceneManager.LoadSceneAsync(3);
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
