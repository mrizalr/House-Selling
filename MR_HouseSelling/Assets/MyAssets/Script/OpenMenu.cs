using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour {

    public GazeTime gzTime;
    public Animator anim;
    string btnName;

    void Update()
    {
        
        if (gzTime.timeFinish && btnName == "Menu")
        {
            anim.Play("OpenMenuAnim");
        }
        else if(gzTime.timeFinish && btnName == "Close")
        {
            anim.Play("CloseMenuAnim");
            gzTime.timeFinish = false;
            btnName = null;
        }
    }

    public void OpenMenubtn()
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
