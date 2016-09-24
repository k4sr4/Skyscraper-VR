using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {
    public SteamVR_TrackedObject trackedObj;
    //bool erase = false;

    //void Awake()
    //{
    //    trackedObj = GetComponent<SteamVR_TrackedObject>();
    //}

    //void Update()
    //{
    //    SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);

    //    if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
    //    {
    //        //Debug.Log("1");
    //        erase = true;
    //    }

    //    if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
    //    {
    //        //Debug.Log("2");
    //        erase = false;
    //    }
    //}
	void OnTriggerStay(Collider other)
    {
        if (other.tag == "Paint")
        {
            Destroy(other.gameObject);
        }
    }
}
