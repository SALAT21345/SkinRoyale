using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CaseParameters : MonoBehaviour
{
    public string Name;
    [SerializeField] private TMP_Text NameText;
    [SerializeField] private TMP_Text PriceText;
    [SerializeField] private Image ImagePanelCase;
    public int Price;
    public Sprite imageCase;
    public GameObject CaseObject;
    private GameController gameController;
    [SerializeField] GameObject PanelCase;
    [SerializeField] GameObject AllDrop;
    public string SelectedCase;
    [SerializeField] private SpawnDropInScrollBar spawnDropInScrollBar;
    void Start()
    {
        gameController = GameObject.FindWithTag("MainCamera").GetComponent<GameController>();
    }
    public void ClickInCase()
    {
        PanelCase.SetActive(true);
        NameText.text = Name.ToString();
        PriceText.text = Price.ToString();
        ImagePanelCase.sprite = imageCase;
        spawnDropInScrollBar.SelectedCase = SelectedCase;
        AllDrop.SetActive(true);
    }
    
    void Update()
    {

    }
}
