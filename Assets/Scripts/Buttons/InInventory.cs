using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;


public class InInventory : MonoBehaviour
{
    [SerializeField] Raycast raycast;
    [SerializeField] public Button SelectedGunIMAGE;
    [SerializeField] private Image Inventory;
    [SerializeField] private GameObject AllDropPanel;
    [SerializeField] private GameObject FinalDropPanel;
    public WeaponParameters weaponParameters;
    public int price;
    public string quality;
    public string _name;
    [SerializeField] private TopPanelButton topPanelButton;
    [SerializeField] private WeaponInfo weaponInfo;

    void Start()
    {
        topPanelButton = GameObject.FindWithTag("GlobalPanel").GetComponent<TopPanelButton>();
    }
    public void ClickInInentory()
    {
        
        Button NewGunInInventory = Instantiate(raycast.PrefabButton, new Vector3(-630.080017f,997.967896f,0), Quaternion.identity);
        NewGunInInventory.transform.parent = Inventory.transform; // создали предмет в инвентаре

        NewGunInInventory.image.sprite = raycast.FinalImageDrop.sprite; // передали ему его image
        WeaponParameters NewGetParameters = NewGunInInventory.GetComponent<WeaponParameters>(); // получаем его WeaponParameters
        NewGetParameters.HeHavaValue = true;
        NewGetParameters.Price = price;
        NewGetParameters.quality = quality;
        NewGetParameters.Name = _name;
        NewGunInInventory.AddComponent<WeaponInfo>();
        weaponInfo = NewGunInInventory.GetComponent<WeaponInfo>();
        NewGunInInventory.onClick.AddListener(() => weaponInfo.ShowInfoGun());
        
        AllDropPanel.SetActive(true);
        FinalDropPanel.SetActive(false);
        raycast.CanGetParameters = true;
        topPanelButton.CanPress = true;
        raycast.SelectedObject = null;

    }
}
