using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public Animator m_Animator;
    public bool isOpen;

    void Start()
    {
        if (isOpen)
            m_Animator.SetBool("isOpen", true);
    }

    public string GetDescription()
    {
        if (isOpen) return "Press [E] to <color=red>close</color> the door";
        return "Press [E] to <color=green>open</color> the door";
    }

    public void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
            m_Animator.SetBool("isOpen", true);
        else
            m_Animator.SetBool("isOpen", false);
    }
}
