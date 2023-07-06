using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Camera mainCam;
    private bool lightsOn = true;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Camera camera = GameObject.Find("Camera").GetComponent<Camera>();
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Light"))
                {
                    ToggleLights();
                }
            }
        }
    }

    private void ToggleLights()
    {
        print("Работает");
        lightsOn = !lightsOn;
        GameObject[] lights = GameObject.FindGameObjectsWithTag("Light");
        foreach (GameObject lightObj in lights)
        {
            Light lightComponent = lightObj.GetComponent<Light>();
            if (lightComponent != null)
            {
                lightComponent.enabled = lightsOn;
            }
        }
    }
}
