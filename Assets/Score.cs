using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private static int maxScoreValue = 0;

    private static int currentScoreValue = 0;

    public Text currentScoreText;
    public Text maxScoreText;

    // Update is called once per frame
    void Update()
    {
        currentScoreText.text = currentScoreValue.ToString();
        maxScoreText. text = "max:" + maxScoreValue.ToString();
    }

    public static void AddPoint()
    {
        currentScoreValue += 1;
        if (currentScoreValue > maxScoreValue) {
            maxScoreValue = currentScoreValue;
        }
    }

    public static void Reset()
    {
        currentScoreValue = 0;
    }
}
