using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class dollarScript : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject btnDollar;
    public GameObject dollarMenu; 

    // Start is called before the first frame update
    void Start()
    {
        dollarMenu.SetActive(false);
        btnDollar.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){

        dollarMenu.SetActive(true);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){

        dollarMenu.SetActive(false);


    }


}
