using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    [SerializeField] TextMeshProUGUI scoreText;
    public int scoreValue = 0;

    private void Awake()
    {
        instance = this;
        scoreText = GetComponent<TextMeshProUGUI>(); 
    }
 
    void Update()
    {
        scoreText.text = "Score: " + scoreValue.ToString();
    }

    public void AddScore()
    {
        scoreValue += 10;
    }
}
