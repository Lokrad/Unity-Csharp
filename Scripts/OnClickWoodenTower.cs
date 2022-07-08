using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class OnClickWoodenTower : MonoBehaviour, IPointerClickHandler
{

    public GameObject Canvas_WoodenTower;
    
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log(name + " Game Object Clicked!");
        if(pointerEventData.pointerId == -1)
        {
        Canvas_WoodenTower.SetActive(true);
        Time.timeScale = 0f; 
        }
    }
}