using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement_3 : MonoBehaviour {

    public void Next()
    {
        SceneManager.LoadSceneAsync(13);
    }
}
