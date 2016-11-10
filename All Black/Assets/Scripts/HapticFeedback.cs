using UnityEngine;
using System.Collections;

public class HapticFeedback : MonoBehaviour {

    public ushort vibrateLength = 100;

    void OnTriggerStay(Collider other)
    {
        GameObject collided = other.gameObject;
        if (collided.GetComponent<SteamVR_TrackedObject>())
        {
            SteamVR_TrackedObject tracked = collided.GetComponent<SteamVR_TrackedObject>();
            string index = tracked.index.ToString();
            int indexInt = indexStringToInt(index);
            SteamVR_Controller.Input(indexInt).TriggerHapticPulse(vibrateLength);
            if (SteamVR_Controller.Input(indexInt).GetPressDown(Valve.VR.EVRButtonId.k_EButton_Grip) ||
                SteamVR_Controller.Input(indexInt).GetPressDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger))
            {
                gameObject.GetComponent<Material>().color = new Color(175, 175, 175);
            }
        }
    }

    int indexStringToInt(string str)
    {
        int index = 0;
        switch (str)
        {
            case "Hmd":
                index = 0;
                break;
            case "Device 1":
                index = 1;
                break;
            case "Device 2":
                index = 2;
                break;
            case "Device 3":
                index = 3;
                break;
            case "Device 4":
                index = 4;
                break;
            case "Device 5":
                index = 5;
                break;
            case "Device 6":
                index = 6;
                break;
            case "Device 7":
                index = 7;
                break;
            case "Device 8":
                index = 8;
                break;
            case "Device 9":
                index = 9;
                break;
            case "Device 10":
                index = 10;
                break;
            case "Device 11":
                index = 11;
                break;
            case "Device 12":
                index = 12;
                break;
            case "Device 13":
                index = 13;
                break;
            case "Device 14":
                index = 14;
                break;
            case "Device 15":
                index = 15;
                break;
        }
        return index;
    }

}
