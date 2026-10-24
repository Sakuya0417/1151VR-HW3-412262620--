using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float acceleration = 300f; // 加速度
    public float deceleration = 150f; // 減速度
    public float maxSpeed = 1000f;    // 最高轉速
    
    private float currentSpeed = 0f;
    private bool isSpinning = false;
    private bool isDecelerating = false;
    private AudioSource audioSource;

    void Start()
    {
        // 取得掛載在同一個物件上的音效元件
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // 按下滑鼠左鍵 (或手機觸控螢幕) 開始旋轉
        if (Input.GetMouseButtonDown(0) && !isSpinning)
        {
            isSpinning = true;
            isDecelerating = false;
            if (audioSource != null) audioSource.Play(); // 播放音效
        }

        if (isSpinning)
        {
            if (!isDecelerating)
            {
                // 加速階段
                currentSpeed += acceleration * Time.deltaTime;
                if (currentSpeed >= maxSpeed)
                {
                    currentSpeed = maxSpeed;
                    isDecelerating = true; // 達到最高速後開始減速
                }
            }
            else
            {
                // 減速階段
                currentSpeed -= deceleration * Time.deltaTime;
                if (currentSpeed <= 0)
                {
                    currentSpeed = 0;
                    isSpinning = false;
                    if (audioSource != null) audioSource.Stop(); // 停止音效
                    Debug.Log("輪盤已停止！");
                }
            }

            // 旋轉輪盤 (Z軸)
            transform.Rotate(0, 0, -currentSpeed * Time.deltaTime);
        }
    }
}
