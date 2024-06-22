using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class MoveScrollBar : MonoBehaviour
{
    private Stopwatch timer = new Stopwatch(); // Таймер для отслеживания времени

    public float speedMove = -3000f; // Скорость движения скроллбара
    public bool CaseOpened; // Флаг, указывающий, что кейс открыт
    public bool ScrollBarSpining; // Флаг, указывающий, что скроллбар вращается
    public float TimeToStop = 800f; // Время до остановки скроллбара

    [SerializeField] private Image image; // Изображение, используемое в скрипте
    [SerializeField] private float time; // Время

    [SerializeField] private GameObject FinalDropPanel; // Панель для отображения финального дропа
    public Image imageFinalDrop; // Изображение для финального дропа
    [SerializeField] private GameObject AllDropPanel; // Панель для отображения всех дропов
    public bool canExinFinalPanel = false; // Флаг, указывающий, можно ли выйти в финальную панель
    [SerializeField] private Image Scrollbar; // Ссылка на скроллбар
    [SerializeField] private Image StartPositionScroll; // Начальная позиция скроллбара
    [SerializeField] private TopPanelButton topPanelButton; // Кнопка на верхней панели
    [SerializeField] private Image[] TargetStop; // Массив целей для остановки

    private float stopDelay; // Задержка перед началом торможения
    private float stopTime; // Время, когда начнется торможение
    private Canvas canvas; // Canvas, к которому прикреплен скрипт

    void Start()
    {
        // Находим компонент TopPanelButton на объекте с тегом "GlobalPanel"
        topPanelButton = GameObject.FindWithTag("GlobalPanel").GetComponent<TopPanelButton>();

        // Получаем Canvas
        canvas = GetComponentInParent<Canvas>();
    }

    void Update()
    {
        // Если кейс открыт
        if (CaseOpened)
        {
            // Если текущее время больше или равно времени начала торможения
            if (Time.time >= stopTime)
            {
                // Начало торможения
                ScrollBarSpining = true;
                speedMove = Mathf.MoveTowards(speedMove, 0, TimeToStop * Time.deltaTime);
                MoveScrollbar(speedMove);

                // Если скроллбар остановился и финальная панель еще не открыта
                if (speedMove == 0 && !canExinFinalPanel)
                {
                    ScrollBarSpining = false; // Рулетка прокрутилась

                    // Отображаем финальную панель и скрываем панель всех дропов
                    FinalDropPanel.SetActive(true);
                    topPanelButton.CanPress = false;
                    AllDropPanel.SetActive(false);
                    canExinFinalPanel = true;
                }
            }
            else
            {
                // Продолжаем движение скроллбара
                MoveScrollbar(speedMove);
            }
        }
    }

    // Метод для запуска вращения
    public void GoSpining()
    {
        // Устанавливаем начальную позицию скроллбара
        Scrollbar.rectTransform.localPosition = StartPositionScroll.rectTransform.localPosition;

        // Сбрасываем параметры вращения
        speedMove = -3000f;
        TimeToStop = 800f;
        canExinFinalPanel = false;
        CaseOpened = true;

        // Устанавливаем рандомную задержку перед началом торможения
        stopDelay = Random.Range(1f, 3f); // Пример: от 1 до 3 секунд
        stopTime = Time.time + stopDelay; // Время, когда начнется торможение
    }

    // Метод для перемещения скроллбара с учетом разрешения экрана
    private void MoveScrollbar(float speed)
    {
        // Нормализуем скорость по масштабу канваса
        float normalizedSpeed = speed / canvas.scaleFactor;
        gameObject.transform.Translate(new Vector2(normalizedSpeed * Time.deltaTime, 0));
    }
}
