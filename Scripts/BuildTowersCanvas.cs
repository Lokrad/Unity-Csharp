using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class BuildTowersCanvas : MonoBehaviour
{
    [SerializeField] GameObject WoodenTower;
    [SerializeField] GameObject RockTower;
    [SerializeField] GameObject HighRockTower;
    [SerializeField] GameObject CanvasRuined;
    [SerializeField] GameObject RuinedTower;


    public void DestroyWoodenTower()
    {
        WoodenTower.SetActive(false);
        CanvasRuined.SetActive(false);
        RuinedTower.SetActive(true);
        Time.timeScale = 1f; 
    
    }

    public void DestroyRockTower()
    {
        RockTower.SetActive(false);
        CanvasRuined.SetActive(false);
        RuinedTower.SetActive(true);
        Time.timeScale = 1f; 
    }

    public void DestroyHighRockTower()
    {
        HighRockTower.SetActive(false);
        CanvasRuined.SetActive(false);
        RuinedTower.SetActive(true);
        Time.timeScale = 1f; 
    }

    public void BuildWoodenTower()
    {
        WoodenTower.SetActive(true);
        CanvasRuined.SetActive(false);
        RuinedTower.SetActive(false);
        Time.timeScale = 1f; 
    
    }

    public void BuildRockTower()
    {
        RockTower.SetActive(true);
        CanvasRuined.SetActive(false);
        RuinedTower.SetActive(false);
        Time.timeScale = 1f; 
    }

    public void BuildHighRockTower()
    {
        HighRockTower.SetActive(true);
        CanvasRuined.SetActive(false);
        RuinedTower.SetActive(false);
        Time.timeScale = 1f; 
    }

    public void ExitCanvasRuined()
    {
        CanvasRuined.SetActive(false);
        Time.timeScale = 1f; 
    }

}

