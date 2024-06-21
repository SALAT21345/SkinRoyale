
using UnityEngine;

public class CleanerSP : MonoBehaviour
{
    [SerializeField] private GameObject ScrolPanel;

    public void Cleaner()
    {
        for (int i = ScrolPanel.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(ScrolPanel.transform.GetChild(i).gameObject);
        }
    }
}
