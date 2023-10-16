using UnityEngine;
using TMPro;

public class text_amin : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public string targetText = "Objective:" + "Reach the checkpoint";
    public float animationSpeed = 10f;

    private int currentIndex = 0;
    private float timer = 0f;

    private void Start()
    {
        // Reset the text to an empty string initially
        textMeshPro.text = "";
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (currentIndex < targetText.Length)
        {
            // Calculate the number of characters to display based on the animation speed
            int charCount = (int)(timer * animationSpeed);

            if (charCount > currentIndex)
            {
                // Append the next character to the displayed text
                textMeshPro.text = targetText.Substring(0, currentIndex + 1);
                currentIndex++;
            }
        }
    }
}
