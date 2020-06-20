using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jill_end : MonoBehaviour {

    // the operation info
    private int num;
    public Text showText;
    public GameObject Backbutton;
    public string[] oper_info = { "Today's work has been finished.",
                                  "I feel delighted because I talk with many guests and even make friends with them. ",
                                  "Although there are some trouble and unfortunateness coexist.",
                                  "I am still proud of my work. ",
                                  "Because...",
                                  "Gossiping with everyone who comes to my bar is my duty. ",
                                  "True life mingles with sweet, sweat, bitterness, anxiety and so on.",
                                  "We need to express our true feelings to others instead of hiding them.",
                                  "But we also need those people who are willing to listen to you.",
                                  "They are -- Bartenders. " };


    void Start()
    {
        num = 0;
        ButtonNext();
        Backbutton.gameObject.SetActive(false);
    }

    public void ButtonNext()
    {

        if (num == 10)
        {
            SceneManager.LoadSceneAsync(0);
        }

        showText.text = oper_info[num];
        ++num;

        if (num > 0)
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
