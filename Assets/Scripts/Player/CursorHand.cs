using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHand : MonoBehaviour
{
    public bool cursorEnter;
    public Texture2D cursorTexture;
    public float distance = 2;
    public bool dist;

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (cursorEnter == true){
            if (Vector3.Distance(transform.position, player.transform.position) < distance)
                dist = true;
            else 
                dist = false;
        }
            
    }

    void OnMouseEnter() {
        cursorEnter = true;
    }

    void OnMouseExit() {
        cursorEnter = false;
    }

    void OnGUI() {
        if (dist == true)
            GUI.DrawTexture(new Rect(Screen.width/2-40, Screen.height/2-30, 80, 60), cursorTexture);
    }
}
