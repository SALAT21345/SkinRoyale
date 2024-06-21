using UnityEngine;
using UnityEngine.UI;
public class SpawnDropInScrollBar : MonoBehaviour
{
    public int AllCase;
    public string SelectedCase;
    public Image[] GunsInRevolution;
    public Image[] GunsInWeapons;  
    [SerializeField] private GameObject ScrollBarPanel;
    [SerializeField] private int RandomValue;
    [SerializeField] private int RandomWeapons;
    [SerializeField] private int CanSpawnWeapons;
    [SerializeField] private GameController gameController;
    [SerializeField] private float PriceCase;
    [SerializeField] private GameObject PanelCase;
    
    void Update()
    {
        gameController = GameObject.FindWithTag("MainCamera").GetComponent<GameController>();
    }
    public void OpenRevolution(int RandomWeapons)
    {
        PanelCase.SetActive(false); // ========  ЗАКРЫВАТЬ ПАНЕЛЬ КАЖДЫЙ РАЗ, КОГДА ОТКРЫВАЕМ КЕЙС ===
        
        if (RandomWeapons == 3)
        {
            CanSpawnWeapons = Random.RandomRange(0,2);
        }
        if (RandomWeapons == 2)
        {
            CanSpawnWeapons = Random.RandomRange(3,5);
        }
        if (RandomWeapons == 1)
        {
            CanSpawnWeapons = Random.RandomRange(6,10);
        }
        if (RandomWeapons == 0)
        {
            CanSpawnWeapons = Random.RandomRange(11,17);
        }
        Image Drop = Instantiate(GunsInRevolution[CanSpawnWeapons], ScrollBarPanel.transform.position, Quaternion.identity);
        Drop.transform.parent = ScrollBarPanel.transform;
        Drop.rectTransform.localScale = new Vector3(1, 1);
        
    }
    public void OpenWeapons(int RandomWeapons)
    {
       PanelCase.SetActive(false); // ========  ЗАКРЫВАТЬ ПАНЕЛЬ КАЖДЫЙ РАЗ, КОГДА ОТКРЫВАЕМ КЕЙС ===
    }

    public void SpawnDrop()
    {
        if(gameController.Balance >= PriceCase)
        {
            PriceCase = 260;
            gameController.Balance -= PriceCase;
            for(int i = 0;i < 40; i++)
            {
                int RandomWeapons;
                int RandomValue = Random.Range(0, 100);

                if(RandomValue < 100 && RandomValue>50 ) // 50 %
                {
                    RandomWeapons = 0;
                    if(SelectedCase == "Revolution")
                    {
                        OpenRevolution(RandomWeapons);
                    }
                    else if(SelectedCase == "Weapons")
                    {
                        OpenWeapons(RandomWeapons);
                    }
                }
                if(RandomValue < 50 && RandomValue >25 ) // 25%
                {
                    RandomWeapons = 1;
                    if(SelectedCase == "Revolution")
                    {
                        OpenRevolution(RandomWeapons);
                    }
                    else if(SelectedCase == "Weapons")
                    {
                        OpenWeapons(RandomWeapons);
                    }
                }
                if(RandomValue < 25 && RandomValue >10 ) // 15
                {
                    RandomWeapons = 2;
                    if(SelectedCase == "Revolution")
                    {
                        OpenRevolution(RandomWeapons);
                    }
                    else if(SelectedCase == "Weapons")
                    {
                        OpenWeapons(RandomWeapons);
                    }
                }
                if(RandomValue < 10 && RandomValue> 3) // 7%
                {
                    RandomWeapons = 3;
                    if(SelectedCase == "Revolution")
                    {
                        OpenRevolution(RandomWeapons);
                    }
                    else if(SelectedCase == "Weapons")
                    {
                        OpenWeapons(RandomWeapons);
                    }
                }
                if(RandomValue <3 && RandomValue>0  ) //3
                {
                    RandomWeapons = 4;
                    if(SelectedCase == "Revolution")
                    {
                        OpenRevolution(RandomWeapons);
                    }
                    else if(SelectedCase == "Weapons")
                    {
                        OpenWeapons(RandomWeapons);
                    }
                }
                
                if(i >=49)
                {
                    Debug.Log("Все заспавнилось");
                }
            }
        }

    }

}