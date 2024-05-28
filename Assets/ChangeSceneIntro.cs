using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class DelayedSceneTransition : MonoBehaviour
{
    public string targetSceneName = "MainGame"; // Tên của Scene mà bạn muốn chuyển đến


    void Start()
    {
        // Bắt đầu coroutine chờ đợi 10 giây trước khi chuyển đến Scene mới
        StartCoroutine(DelayedTransition());
    }

    IEnumerator DelayedTransition()
    {
        // Chờ đợi 10 giây
        yield return new WaitForSeconds(10f);

        // Chuyển đến Scene có tên được chỉ định
        SceneManager.LoadScene(targetSceneName);
    }
}
