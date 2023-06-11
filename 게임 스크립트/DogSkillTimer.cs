using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DogSkillTimer : MonoBehaviour
{
    public float timeRemaining = 0;
    public TextMeshProUGUI timeText;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            //Debug.Log("Dog ��ų ��� ����!");
            // ���� ���� �ڵ� �߰�
            timeText.text = string.Format("Dog : ��� ����");
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float time = Mathf.FloorToInt(timeToDisplay);
        timeText.text = string.Format("Dog : {0:00}", time);
    }
}