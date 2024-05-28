using UnityEngine;

public class ExitButtonScript : MonoBehaviour
{
    void Update()
    {
        // Kiểm tra khi nào người chơi click chuột trái
        if (Input.GetMouseButtonDown(0))
        {
            // Thoát ứng dụng
            Application.Quit();
        }
    }
}
