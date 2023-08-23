using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    // Start is called before the first frame update

    public Button mainMenuButton;

    void Start()
    {
        mainMenuButton.onClick.AddListener(Mainmenu);
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
