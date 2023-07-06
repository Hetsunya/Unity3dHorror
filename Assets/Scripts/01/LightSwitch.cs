using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public float interactionDistance = 2f; // Максимальное расстояние для взаимодействия
    public float delayTime = 5f; // Задержка перед отключением света
    private bool lightsOn = true; // Изначально свет включен
    private bool interacted = false; // Флаг для отслеживания взаимодействия
    private float timer = 0f; // Таймер для отслеживания задержки

    private void Update()
    {
        if (!interacted && Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Camera camera = GameObject.Find("Camera").GetComponent<Camera>();
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, interactionDistance))
            {
                if (hit.collider.CompareTag("Light"))
                {
                    interacted = true; // Установка флага взаимодействия
                    timer = delayTime; // Задаем значение таймера
                    ToggleLights(); // Выключаем свет
                }
            }
        }

        if (interacted && timer > 0f)
        {
            timer -= Time.deltaTime; // Уменьшаем таймер
            if (timer <= 0f)
            {
                ToggleLights(); // Включаем свет после задержки
            }
        }
    }

    private void ToggleLights()
    {
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

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class LightSwitch : MonoBehaviour
// {
//     public float interactionDistance = 1f; // Максимальное расстояние для взаимодействия
//     private bool lightsOn = true;

//     private void Update()
//     {
//         if (Input.GetMouseButtonDown(0))
//         {
//             RaycastHit hit;
//             Camera camera = GameObject.Find("Camera").GetComponent<Camera>();
//             Ray ray = camera.ScreenPointToRay(Input.mousePosition);

//             if (Physics.Raycast(ray, out hit, interactionDistance))
//             {
//                 if (hit.collider.CompareTag("Light"))
//                 {
//                     ToggleLights();
//                 }
//             }
//         }
//     }

//     private void ToggleLights()
//     {
//         lightsOn = !lightsOn;
//         GameObject[] lights = GameObject.FindGameObjectsWithTag("Light");
//         foreach (GameObject lightObj in lights)
//         {
//             Light lightComponent = lightObj.GetComponent<Light>();
//             if (lightComponent != null)
//             {
//                 lightComponent.enabled = lightsOn;
//             }
//         }
//     }
// }