using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePointLocation : MonoBehaviour {

    [SerializeField] GameObject player;
    [SerializeField] GameObject startPoint;

    [SerializeField] Button[] mButton;
    [SerializeField] Sprite[] mButtonImgNonActive;
    [SerializeField] Sprite[] mButtonImgActive;

    Transform pointTransform;

    public string btnName;
    public Animator anim;
    public GazeTime gzTime;

    // Use this for initialization
    void Start () {
        player.transform.position = new Vector3(startPoint.transform.position.x, transform.position.y, startPoint.transform.position.z);
        mButton[3].GetComponent<Image>().sprite = mButtonImgActive[3];
    }

    void Update()
    {
        if (gzTime.timeFinish && (btnName == "LivingRoom" || btnName == "BedRoom" || btnName == "Backyard" || btnName == "FamilyRoom" || btnName == "Kitchen"))
        {
            anim.Play("CloseMenuAnim");
            gzTime.timeFinish = false;
            btnName = null;
            player.transform.position = new Vector3(pointTransform.transform.position.x, transform.position.y, pointTransform.transform.position.z);

            switch (pointTransform.name)
            {
                case "LivingRoom":
                    mButton[0].GetComponent<Image>().sprite = mButtonImgActive[0];
                    mButton[1].GetComponent<Image>().sprite = mButtonImgNonActive[1];
                    mButton[2].GetComponent<Image>().sprite = mButtonImgNonActive[2];
                    mButton[3].GetComponent<Image>().sprite = mButtonImgNonActive[3];
                    mButton[4].GetComponent<Image>().sprite = mButtonImgNonActive[4];
                    break;
                case "Backyard":
                    mButton[0].GetComponent<Image>().sprite = mButtonImgNonActive[0];
                    mButton[1].GetComponent<Image>().sprite = mButtonImgActive[1];
                    mButton[2].GetComponent<Image>().sprite = mButtonImgNonActive[2];
                    mButton[3].GetComponent<Image>().sprite = mButtonImgNonActive[3];
                    mButton[4].GetComponent<Image>().sprite = mButtonImgNonActive[4];
                    break;
                case "BedRoom":
                    mButton[0].GetComponent<Image>().sprite = mButtonImgNonActive[0];
                    mButton[1].GetComponent<Image>().sprite = mButtonImgNonActive[1];
                    mButton[2].GetComponent<Image>().sprite = mButtonImgActive[2];
                    mButton[3].GetComponent<Image>().sprite = mButtonImgNonActive[3];
                    mButton[4].GetComponent<Image>().sprite = mButtonImgNonActive[4];
                    break;
                case "FamilyRoom":
                    mButton[0].GetComponent<Image>().sprite = mButtonImgNonActive[0];
                    mButton[1].GetComponent<Image>().sprite = mButtonImgNonActive[1];
                    mButton[2].GetComponent<Image>().sprite = mButtonImgNonActive[2];
                    mButton[3].GetComponent<Image>().sprite = mButtonImgActive[3];
                    mButton[4].GetComponent<Image>().sprite = mButtonImgNonActive[4];
                    break;
                case "Kitchen":
                    mButton[0].GetComponent<Image>().sprite = mButtonImgNonActive[0];
                    mButton[1].GetComponent<Image>().sprite = mButtonImgNonActive[1];
                    mButton[2].GetComponent<Image>().sprite = mButtonImgNonActive[2];
                    mButton[3].GetComponent<Image>().sprite = mButtonImgNonActive[3];
                    mButton[4].GetComponent<Image>().sprite = mButtonImgActive[4];
                    break;
            }
        }

    }
	
	public void changeLocationByButton(Transform pointTransform)
    {
        gzTime.TimerStartTrigger();
        this.pointTransform = pointTransform;
    }
}
