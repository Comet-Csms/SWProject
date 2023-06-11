using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Xcount : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int xcount = this.gameObject.transform.childCount;
        timeText.text = string.Format("{0}", xcount);

        if (xcount == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
