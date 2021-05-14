using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part1 : MonoBehaviour {

    // initialization
    public Dropdown DropList;
    public Text ShowText;
    private string[] TextInfo = { " ",
                                  "Marsblast consists of 6 Bronson Ext, 1 Pwd Delta, 4 Flanergide and 2 Karmotrine.",
                                  "BloomLight consists of 4 Adelhyde, 1 Pwd Delta, 2 Flanergide and 3 Karmotrine with ice and aging.",
                                  "Bad Touch consists of 2 Bronson Ext, 2 Pwd Delta, 2 Flanergide and 4 Karmotrine with ice.",
                                  "Bule Fairy consists of 4 Adelhyde, 1 Flanergide and 1 Karmotrine with aging"};




	// Use this for initialization
	void Start () {
        ChangeText();
		
	}
	
    public void DropChange()
    {
        ChangeText();
    }
	
    void ChangeText()
    {
        ShowText.text = TextInfo[DropList.value];
    }
		
}
