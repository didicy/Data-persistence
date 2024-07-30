using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class MenuUIManager : MonoBehaviour
{
    public static MenuUIManager Instance;

    public TextMeshProUGUI playerName;    

    private void Start()
    {
                
    }

    private void Awake()
    {        
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);        
    }
}
