using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class OnClickRockTower : MonoBehaviour, IPointerClickHandler
{

    public GameObject Canvas_RockTower;
    
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log(name + " Game Object Clicked!");
        if(pointerEventData.pointerId == -1)
        {
        Canvas_RockTower.SetActive(true);
        Time.timeScale = 0f; 
        }
    }
}