using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    // ===== Переменные внутри скрипта. ========
    [SerializeField] private GameObject FinalPanel; // Финальная панель с дропом
    [SerializeField] public Image FinalImageDrop; // Image.sprite с выпавшим оружеем
    public GameObject SelectedObject;
    [SerializeField] public string _quality; // quality, сохраняемое в рамках этого скрипта.
    [SerializeField] public string _NameGun;
    [SerializeField] public int _Price;
    public Button PrefabButton; // Префаб создаваемого объекта
    public bool CanGetParameters = false; // Можно сохранять параметры? 
    public Stopwatch timer = new Stopwatch(); // Timer
    

    // ===== TMP_Objects. =======
    [SerializeField] private TMP_Text QulityTextTMP; // FinalPanel
    [SerializeField] private TMP_Text NameGunTMP; // FinalPanel
    public TMP_Text PriceTMP; // FinalPanel



    // ===== Scripts ========= 
    [SerializeField] private MoveScrollBar moveScrollBar; 
    [SerializeField] private ButtonsFinalDrop ButtonsFinalDrop;
    [SerializeField] private InInventory inInventory;
    [SerializeField] private WeaponParameters GetweaponParameters;

//  =======================================================================


    void Update()
    {
        if (moveScrollBar.ScrollBarSpining == false && moveScrollBar.speedMove == 0 )
        {
            RaycastHit2D Hit = Physics2D.Raycast(transform.position, Vector2.up);
            
            if (Hit.collider != null )
            {
//          
            SelectedObject = Hit.collider.gameObject;
            GetweaponParameters = SelectedObject.GetComponent<WeaponParameters>();
            if( GetweaponParameters != null)
            {

                


                _quality = GetweaponParameters.quality.ToString(); // в локальную переменную 
                FinalImageDrop.sprite = SelectedObject.GetComponent<Image>().sprite; // в локальную переменную 
                _Price = GetweaponParameters.Price; // в локальную переменную 
                moveScrollBar.imageFinalDrop.sprite = FinalImageDrop.sprite; // в moveScrollBar
                ButtonsFinalDrop.PriceGun = _Price;
                QulityTextTMP.text = _quality.ToString();

                _NameGun = GetweaponParameters.Name.ToString(); // в локальную переменную 
                inInventory.price = _Price;
                inInventory._name = _NameGun;
                inInventory.quality = _quality;

                QulityTextTMP.text = _quality;
                NameGunTMP.text = _NameGun;
                PriceTMP.text = _Price.ToString();
                if(moveScrollBar.speedMove == 0 && SelectedObject == null)
                {
                    moveScrollBar.speedMove -=4.5f;
                }



                
            }    
            }
            



            
        }
    }
}


                 







