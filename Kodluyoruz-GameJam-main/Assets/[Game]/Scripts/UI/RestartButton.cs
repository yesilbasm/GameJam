using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    [Button]
    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        GameManager.Instance.isGameStarted = true;
    }
}
