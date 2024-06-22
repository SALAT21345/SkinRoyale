using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float Balance;
    public int Level;
    [SerializeField] private GameObject Inventory; 

    [SerializeField] private TMP_Text BalanceText;
    
    void Start()
    {
        // Салат гей
        //Inventory.SetActive(true);
        //Inventory.SetActive(false);
    }

    void Update()
    {
        BalanceText.text = Balance.ToString();
    }
}
