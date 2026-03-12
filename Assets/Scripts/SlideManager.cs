using UnityEngine;
using UnityEngine.UI;

public class SlideManager : MonoBehaviour
{
    public Sprite[] slides;
    public Image displayImage;
    private int currentIndex = 0;

    void Start()
    {
        if (slides.Length > 0)
        {
            UpdateDisplay();
        }
    }

    void Update()
    {
        // スペースキー：次へ（最後の枚数で止まる）
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentIndex < slides.Length - 1)
            {
                currentIndex++;
                UpdateDisplay();
            }
            else
            {
                Debug.Log("最後のスライドです");
            }
        }

        // バックスペース：戻る（0枚目で止まる）
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                UpdateDisplay();
            }
            else
            {
                Debug.Log("最初のスライドです");
            }
        }
    }

    void UpdateDisplay()
    {
        if (displayImage != null && slides.Length > 0)
        {
            displayImage.sprite = slides[currentIndex];
        }
    }
}