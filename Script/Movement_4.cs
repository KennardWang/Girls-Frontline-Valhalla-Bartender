using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement_4 : MonoBehaviour {

    public void Next()
    {
        SceneManager.LoadSceneAsync(16);
    }
}
