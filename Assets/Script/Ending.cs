using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour {

    // the operation info
    private int num;
    public Text showText;
    public GameObject Backbutton;
    public string[] oper_info = { "OK my last event is over.",
                                  "So today's job is over. ",
                                   };


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
