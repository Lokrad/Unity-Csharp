using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void StartHandler()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitHandler()
    {
        SceneManager.LoadScene(0);
    }
}
