using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    
    public void LoadButton()
    {
        Debug.Log("게임 로딩 중");
        SceneManager.LoadScene(1);
    }
}
