using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MP_BarControl : MonoBehaviour
{
    [SerializeField]
    private Slider mpbar;

    private float maxMp = 100;
    private float curMp = 100;

    // Start is called before the first frame update
    void Start()
    {
        mpbar.value = (float)curMp / (float)maxMp;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
            curMp -= 10;
        HandleHP();
    }

    private void HandleHP()
    {
        mpbar.value = (float)curMp / (float)maxMp;
    }
}