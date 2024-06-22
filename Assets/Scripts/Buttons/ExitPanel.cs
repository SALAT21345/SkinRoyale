using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ExitPanel : MonoBehaviour
{
    [SerializeField] private GameObject Object;

    
    public void Exit()
    {
        
        Object.SetActive(false);
    }
}
