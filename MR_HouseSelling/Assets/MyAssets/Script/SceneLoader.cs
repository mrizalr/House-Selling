using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public GazeTime gzTime;
    string levelLoadName;
    string btnName;

    // Update is called once per frame
    void Update()
    {
        if (gzTime.timeFinish && (btnName == "VR" || btnName == "AR" || btnName == "Exit"))
        {
            SceneManager.LoadScene(levelLoadName);
        }
    }

    public void LoadingScene(string sceneName)
    {
        gzTime.TimerStartTrigger();
        levelLoadName = sceneName;
    }

    public void getButtonName()
    {
        btnName = gameObject.name;
    }

    public void releaseButtonName()
    {
        btnName = null;
    }
}
