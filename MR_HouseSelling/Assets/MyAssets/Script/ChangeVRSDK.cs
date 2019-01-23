using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class ChangeVRSDK : MonoBehaviour {

	// Update is called once per frame

	void Start () {
        if (SceneManager.GetActiveScene().name == "AR_Scene" && XRSettings.loadedDeviceName != "Vuforia")
        {
            VuforiaSDK();
        }
        if (SceneManager.GetActiveScene().name != "AR_Scene" && XRSettings.loadedDeviceName != "cardboard")
        {
            CardBoardSDK();
        }
    }

    IEnumerator LoadDeviceVR(string newDevice, bool status)
    {
        yield return new WaitForEndOfFrame();
        XRSettings.LoadDeviceByName(newDevice);
        yield return new WaitForEndOfFrame();
        XRSettings.enabled = status;
    }

    void CardBoardSDK()
    {
        StartCoroutine(LoadDeviceVR("cardboard", true));
    }

    void VuforiaSDK()
    {
        StartCoroutine(LoadDeviceVR("Vuforia", true));
    }
}
