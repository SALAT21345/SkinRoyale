using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCanvas : MonoBehaviour
{

    public GameObject Needcanvas;
    [SerializeField] private TopPanelButton topPanelButton;
    void Start()
    {
        topPanelButton = GameObject.FindWithTag("GlobalPanel").GetComponent<TopPanelButton>();
    }
    public void ClickOnCanvas()
    {
        topPanelButton.NeedCanvas = Needcanvas;
    }
}
