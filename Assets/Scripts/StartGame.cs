using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartGame : MonoBehaviour
{
    public TextMeshProUGUI playerName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NameInput()
    {
        MenuUIManager.Instance.playerName = playerName;        
    }

    public void StartGameProperty()
    {
        SceneManager.LoadScene(1);
    }
}
