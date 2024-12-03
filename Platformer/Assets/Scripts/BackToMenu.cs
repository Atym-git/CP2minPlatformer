using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{
    [SerializeField] Button _backToMenuButton;

    private void Start()
    {
        _backToMenuButton.onClick.AddListener(LoadMenuScene);
    }

    private void LoadMenuScene() => SceneManager.LoadScene("MenuScene");
}