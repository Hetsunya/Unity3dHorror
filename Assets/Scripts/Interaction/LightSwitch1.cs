using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch1 : MonoBehaviour, IInteractable
{
    public Light m_Light;
    public bool isOn;

    void Start()
    {
        m_Light.enabled = isOn;
    }

    public string GetDescription()
    {
        if (isOn) return "Press [LMB] to pull the lever.";
        return "Press [LMB] to pull the lever.";
    }

    public void Interact()
    {
        isOn = !isOn;
        m_Light.enabled = isOn;
    }
}
