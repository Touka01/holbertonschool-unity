using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    private int prevScene;
    private Toggle invertYAxis;

    void start()
    {
        prevScene = SceneManager.GetActiveScene().buildIndex - 1;
        invertYAxis = transform.Find("InvertYToggle").gameObject.GetComponent<Toggle>();
        if (PlayerPrefs.HasKey("InvertYToggle"))
            invertYAxis.isOn = PlayerPrefs.GetInt("InvertYToggle") == 0 ? false : true;
    }
    public void Options()
    {
        SceneManager.LoadScene(1);
    }

    public void Back()
    {
        SceneManager.LoadScene(prevScene);
    }
    
    public void Apply()
    {
        if (invertYAxis.isOn)
            PlayerPrefs.SetInt("InvertYToggle", 1);
        else
            PlayerPrefs.SetInt("InvertYToggle", 0);
        Back();
    }
}
