using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class pesoScript : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject btnPeso;
    public GameObject pesoMenu;

    // Start is called before the first frame update
    void Start()
    {

        pesoMenu.SetActive(false);
        btnPeso.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){

        pesoMenu.SetActive(true);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){

        pesoMenu.SetActive(false);


    }
}
