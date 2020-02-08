using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class eurosScript : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject btnEuro;
    public GameObject euroMenu; 
    

    // Start is called before the first frame update
    void Start(){
        euroMenu.SetActive(false);
        btnEuro.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){

        euroMenu.SetActive(true);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){

        euroMenu.SetActive(false);


    }
}
