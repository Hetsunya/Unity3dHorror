using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInteraction : MonoBehaviour
{
    public LeverOrderTracker orderTracker; // Ссылка на скрипт для отслеживания порядка нажатия

    public int leverNumber; // Номер этого рычага

    private void OnMouseDown()
    {
        if (orderTracker != null)
        {
            orderTracker.CheckLeverOrder(leverNumber);
        }
    }
}