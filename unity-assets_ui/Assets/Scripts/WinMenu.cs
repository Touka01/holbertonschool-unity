using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour
{
     void Start()
    {
        transform.Find("MenuButton").gameObject.GetComponent<Button>().onClick.AddListener(MainMenu);
        transform.Find("NextButton").gameObject.GetComponent<Button>().onClick.AddListener(Next);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Next()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex < 2)
            SceneManager.LoadScene(sceneIndex + 1);
        else
            MainMenu();
    }
}
