using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement_2 : MonoBehaviour {

    public void Next()
    {
        SceneManager.LoadSceneAsync(9);
    }
}
