using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButtonName : MonoBehaviour {

    public ChangePointLocation cpl;

    public void getButtonName()
    {
        cpl.btnName = gameObject.name;
    }

    public void releaseButtonName()
    {
        cpl.btnName = null;
    }
}
