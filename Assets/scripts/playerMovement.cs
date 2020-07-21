using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private bool isMouseIn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if you are dragging it
        if(isMouseIn)
        {
            //check if the mouse is down
            if(Input.GetButton("Fire1"))
            {
                //get the mouse position 
                Vector2 poz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //move to mouse position
                gameObject.transform.position = poz;
            }
        }
    }
    void OnMouseEnter()
    {
        //check whether the mouse is on it
        isMouseIn = true;
    }
    void OnMouseExit()
    {
        //let it know you arent dragging it anymore
        isMouseIn = false;
    }
}
