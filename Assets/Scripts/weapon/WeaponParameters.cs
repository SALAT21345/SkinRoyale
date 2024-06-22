
using UnityEngine;
using UnityEngine.UI;
public class WeaponParameters: MonoBehaviour 
{
    public Image GunImage;
    public string Name;
    public string quality;
    
    [SerializeField] public int Price;
    [Header("Закаленное в боях (Battle-Scarred)")]
    [SerializeField] private int PriceBS;
    [Header("Поношенное (Well-Worn)")]
    [SerializeField] private int PriceWW;
    [Header("После полевых испытаний (Field-Tested)")]
    [SerializeField] private int PriceFT;
    [Header("Немного поношенное (Minimal Wear)")]
    [SerializeField] private int PriceMW;
    [Header("Прямо с завода (Factory new)")]
    [SerializeField] private int PriceFN;
    public bool HeHavaValue = false;
    [SerializeField] private int RandomQuality;


    public void Start()
    {   if(!HeHavaValue)
        {
        RandomQuality = Random.Range(0,100);
        if(RandomQuality >= 50) {quality = "Закаленное в боях (Battle-Scarred)";}                   // 50%
        if(RandomQuality <50 && RandomQuality >= 30) quality = "Поношенное (Well-Worn)";     // 20%
        if(RandomQuality <30 && RandomQuality >= 15) quality = "После полевых испытаний (Field-Tested)";  // 15%
        if(RandomQuality <15 && RandomQuality >= 5) quality = "Немного поношенное (Minimal Wear)";   // 10%
        if(RandomQuality <5 && RandomQuality >= 0) quality = "Прямо с завода (Factory new)";     // 5 %


        if(quality == "Закаленное в боях (Battle-Scarred)")  Price = PriceBS;
        if(quality == "Поношенное (Well-Worn)")  Price = PriceWW;
        if(quality == "После полевых испытаний (Field-Tested)")  Price = PriceFT;
        if(quality == "Немного поношенное (Minimal Wear)")  Price = PriceMW;
        if(quality == "Прямо с завода (Factory new)")  Price = PriceFN;
        
        }
       
    }

}

// Закаленное в боях (Battle-Scarred)
// Поношенное (Well-Worn)
// После полевых испытаний (Field-Tested)
// Немного поношенное (Minimal Wear)
// Прямо с завода (Factory new)

