using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour {
    
    private float xRot;
    private float yRot;
    private float xCurrRot;
    private float yCurrRot;
    [SerializeField]
    private Camera fpcCamera;
    [SerializeField]
    private GameObject fpcObject;
    public float mouseSensetive;
    private float xRotVelocity;
    private float yRotVelocity;
    private float smoothDampTime = -0.1f;



    // Start is called before the first frame update
    void Start() {
        mouseSensetive = 1f;
    }

    // Update is called once per frame
    void Update() {
        MouseMove();
    }

    private void MouseMove()
    {
        xRot+=Input.GetAxis("Mouse Y") * mouseSensetive;
        yRot+=Input.GetAxis("Mouse X") * mouseSensetive;
        xRot = Mathf.Clamp(xRot, -90, 90);

        //РАСЧЕТЫ
        xCurrRot = Mathf.SmoothDamp(xCurrRot, xRot, ref xRotVelocity, smoothDampTime);
        yCurrRot = Mathf.SmoothDamp(yCurrRot, yRot, ref yRotVelocity, smoothDampTime);

        //ДЛЯ ОСИ X
        fpcCamera.transform.rotation = Quaternion.Euler(xCurrRot, yCurrRot, 0f);
        //ДЛЯ ОСИ Y
        fpcCamera.transform.rotation = Quaternion.Euler(-xCurrRot, yCurrRot, 0f);
    }  

}
