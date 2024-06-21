using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPanelButton : MonoBehaviour
{

    public bool CanPress = true;
    [SerializeField] public GameObject Selectedcanvas;
    [SerializeField] public GameObject NeedCanvas;
    [SerializeField] private GameObject CaseOpenCanvas;
    [SerializeField] private GameObject Opencase;
    [SerializeField] private GameObject PanelCase;
    public void Change()
    {
        if(CanPress)
        {
        Selectedcanvas.SetActive(false);
        NeedCanvas.SetActive(true);
        Selectedcanvas = NeedCanvas;
        if(Selectedcanvas == CaseOpenCanvas)
            {
                Opencase.SetActive(false);
                PanelCase.SetActive(true);
            }
        }

    }

    
}
