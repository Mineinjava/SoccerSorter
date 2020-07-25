using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartButtonScript : MonoBehaviour
{
    private bool mouseIn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && mouseIn)
        {
            Debug.Log("Loading Scene");
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
    void OnMouseEnter()
    {
        mouseIn = true;
    }
    void OnMouseExit()
    {
        mouseIn = false;
    }
}
