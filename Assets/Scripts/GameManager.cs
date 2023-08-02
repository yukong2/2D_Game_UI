using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject mainImage;
    public Sprite GameOverSpr;
    public Sprite GameClear;
    public GameObject panel;
    public GameObject listButton;
    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("InactiveImage", 1.0f);
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

