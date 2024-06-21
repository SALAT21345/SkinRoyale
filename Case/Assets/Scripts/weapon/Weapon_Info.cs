
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WeaponInfo : MonoBehaviour
{
    [SerializeField] private WeaponParameters Wp;
    [SerializeField] private TMP_Text NameGun;
    [SerializeField] private TMP_Text PriceGun;
    [SerializeField] private TMP_Text QualityGun;
    [SerializeField] private GameObject InfoGunPanel;
    [SerializeField] private Transform Inventory;

    void Start()
    {
        Wp = gameObject.GetComponent<WeaponParameters>(); /// ОСТАНОВИЛСЯ ЗДЕСЬ : ПОИСК TMP объекта, т.к скрипт вешается поздно, нужно как то найти, возможно по тегу.
        Inventory = GameObject.FindWithTag("Inventory").GetComponent<Transform>();
        InfoGunPanel = Inventory.Find("InfoGun").gameObject;
        
    }

    
    public void ShowInfoGun()
    {
        InfoGunPanel.SetActive(true);
        NameGun = GameObject.Find("_Name").GetComponent<TMP_Text>();
        QualityGun = GameObject.Find("_Quality").GetComponent<TMP_Text>();
        PriceGun = GameObject.Find("_Price").GetComponent<TMP_Text>();
        NameGun.text = Wp.Name;
        QualityGun.text = Wp.quality.ToString();
        PriceGun.text = Wp.Price.ToString() + "P";
    }
}
