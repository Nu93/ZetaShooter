using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnKeyPress : MonoBehaviour
{
    public string targetSceneName = "IntroGame"; // Tên của Scene mà bạn muốn chuyển đến
    public string startSceneName = "StartGame"; // Tên của Scene "StartGame"
    public string endSceneName = "EndGame"; // Tên của Scene "EndGame"

    void Update()
    {
        // Kiểm tra khi nào người chơi nhấn phím Space và đang ở Scene "StartGame" hoặc "EndGame"
        if (Input.GetKeyDown(KeyCode.Space) && (SceneManager.GetActiveScene().name == startSceneName || SceneManager.GetActiveScene().name == endSceneName))
        {
            // Chuyển đến Scene có tên được chỉ định
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
