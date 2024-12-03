using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] Button _startGameButton;

    private void Start()
    {
        _startGameButton.onClick.AddListener(LoadGameScene);
    }

    private void LoadGameScene() => SceneManager.LoadScene("GameScene");
}
