using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscScript : MonoBehaviour {
    // Update is called once per frame

    public GazeTime gzTime;
    string btnName;

    void Update () {
        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                Application.Quit();
                Debug.Log("Quit !!");
            }

            SceneManager.GetSceneByBuildIndex(0);
        }*/
        if (gzTime.timeFinish && (btnName == "Exit Button"))
        {
            Application.Quit();
            Debug.Log("Quit !!");
            gzTime.timeFinish = false;
        }
    }

    public void timeToQuit()
    {
        gzTime.TimerStartTrigger();
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
