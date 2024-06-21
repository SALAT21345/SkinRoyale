using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine;

public class MoveScrollBar : MonoBehaviour
{
    private Stopwatch timer = new Stopwatch();
    public float speedMove = -30;
    public bool CaseOpened;
    public bool ScrollBarSpining;
    public float TimeToStop = 10f;
    [SerializeField] private Image image;
    [SerializeField] private float time;
    
    [SerializeField] private GameObject FinalDropPanel;
    public Image imageFinalDrop;
    [SerializeField] private GameObject AllDropPanel;
    public bool canExinFinalPanel = false;
    [SerializeField] Image Scrollbar;
    [SerializeField] private Image StartPositionScroll;
    [SerializeField] private TopPanelButton topPanelButton;
    [SerializeField] private Image[] TargetStop;
    
    void Start()
    {
        topPanelButton = GameObject.FindWithTag("GlobalPanel").GetComponent<TopPanelButton>();
    }
    void Update()
    {
        if(CaseOpened)
        {
          if(Scrollbar.rectTransform.position.x == TargetStop[0].rectTransform.position.x)
          {
            speedMove -=10;
          }
            
            ScrollBarSpining = true;
            //speedMove = Mathf.MoveTowards(speedMove, 0, TimeToStop *Time.deltaTime);
            gameObject.transform.Translate(new Vector2(speedMove, 0) );

                if(speedMove == 0 && canExinFinalPanel == false)
                {
                    ScrollBarSpining = false; // Рулетка прокрутилась 
                    
                    FinalDropPanel.SetActive(true);
                    topPanelButton.CanPress = false;
                    AllDropPanel.SetActive(false);
                    canExinFinalPanel = true;
                }
        }
    }
    public void GoSpining()
    {
        
        Scrollbar.rectTransform.localPosition = StartPositionScroll.rectTransform.localPosition;
        speedMove = -30;
        TimeToStop = 8f;
        canExinFinalPanel = false;
        CaseOpened = true;
        

        
    }
}
