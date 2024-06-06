using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PermanentBar : MonoBehaviour
{
    private static PermanentBar instance;
    public string CurrentSceneName { get; private set; }
    [SerializeField] private TextMeshProUGUI messageBox;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        SceneManager.sceneLoaded += OnSceneLoaded;
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("village_main");
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 씬 이름 저장
        CurrentSceneName = scene.name;
        messageBox.text = CurrentSceneName;
        Debug.Log("Current Scene: " + CurrentSceneName);
    }
    
}
