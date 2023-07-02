using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)){
            var _sceneLights = FindObjectsOfType<Light>().;
        foreach (var ligth in _sceneLights) // обрабатываем все источники освещения
        {
            ligth.enabled = true; // true включить, false выключить.
            ligth.color = Color.red; // применить цвет 
            ligth.intensity = 100f; // применить интенсивность            
        }
        }
    }

    private void Action() {


    }
}
