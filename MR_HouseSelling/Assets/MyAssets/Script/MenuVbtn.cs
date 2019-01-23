using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class MenuVbtn : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject CloseBtnGO;
    public GameObject ZoomBtnGO;
    public GameObject InteriorBtnGO;
    public GameObject ExitBtnGO;

    public GameObject Obj_;

    Vector3 zoomValue = new Vector3(.15f, .15f, .15f);
    int status = 0;

	// Use this for initialization
	void Start () {
        CloseBtnGO = GameObject.Find("Close");
        CloseBtnGO.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        ZoomBtnGO = GameObject.Find("Zoom");
        ZoomBtnGO.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        InteriorBtnGO = GameObject.Find("Interior");
        InteriorBtnGO.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        ExitBtnGO = GameObject.Find("Exit");
        ExitBtnGO.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    void Update()
    {
        if (status == 1)
        {
            Obj_.transform.localScale = Vector3.Lerp(Obj_.transform.localScale, zoomValue, .1f);
        }
        else if (status == 0)
        {
            Obj_.transform.localScale = Vector3.Lerp(Obj_.transform.localScale, new Vector3(.1f,.1f,.1f), .1f);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "Close")
        {
            SceneManager.LoadScene("Mainmenu");
        }
        else if (vb.VirtualButtonName == "Zoom")
        {
            if (status == 0)
            {
                status = 1;
            }
            else
                status = 0;
        }
        else if (vb.VirtualButtonName == "Interior")
        {
            SceneManager.LoadScene("VR_Scene");
        }
        else if (vb.VirtualButtonName == "Exit")
        {
            SceneManager.LoadScene("Mainmenu");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName + " has been released");
    }
}
