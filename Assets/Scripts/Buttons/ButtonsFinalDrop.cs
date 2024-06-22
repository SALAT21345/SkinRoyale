using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonsFinalDrop : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    public float PriceGun;
    [SerializeField] GameObject FinalPanel;
    [SerializeField] private Image ScrollPanel;
    [SerializeField] private GameObject AllDropPanel;
    [SerializeField] private Raycast raycast;
    [SerializeField] private TopPanelButton topPanelButton;
    void Start()
    {
       
    }




    public void Sell()
    {
        gameController.Balance += PriceGun;
        FinalPanel.SetActive(false);
        foreach (Transform child in ScrollPanel.transform)
        {
            Destroy(child.gameObject);
        }
        AllDropPanel.SetActive(true);
        topPanelButton.CanPress = true;
        raycast.SelectedObject = null;
        

    }
}
