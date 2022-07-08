using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class OnClickRuined : MonoBehaviour, IPointerClickHandler
{

    public GameObject Canvas_Ruined;
    
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log(name + " Game Object Clicked!");
        if(pointerEventData.pointerId == -1)
        {
        Canvas_Ruined.SetActive(true);
        Time.timeScale = 0f; 
        }
    }
}