using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class OnClickHighRockTower : MonoBehaviour, IPointerClickHandler
{

    public GameObject Canvas_HighRockTower;
    
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log(name + " Game Object Clicked!");
        if(pointerEventData.pointerId == -1)
        {
        Canvas_HighRockTower.SetActive(true);
        Time.timeScale = 0f; 
        }
    }
}