using UnityEngine;
using System.Collections;

public class DrawScript : MonoBehaviour {

 //   public SteamVR_TrackedObject trackedObj;
 //   public GameObject trigger;

 //   LineRenderer currLine;
 //   int numClicks = 0;

 //   public Color c1 = Color.white;
 //   public Color c2 = new Color(1, 1, 1, 0);

 //   // Update is called once per frame
 //   void Update () {
 //       SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);

 //       if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
 //       {
 //           GameObject go = new GameObject();
 //           currLine = go.AddComponent<LineRenderer>();

 //           currLine.SetWidth(0.5f, 0.5f);
 //           currLine.SetColors(c1, c2);

 //           numClicks = 0;
 //       }
 //       else if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
 //       {
 //           currLine.SetVertexCount(numClicks + 1);
 //           currLine.SetPosition(numClicks, new Vector3 (trigger.GetComponent<TriggerScript>().wall.position.x ,trigger.transform.position.y, trigger.transform.position.z));
 //           numClicks++;
 //       }
	//}
}
