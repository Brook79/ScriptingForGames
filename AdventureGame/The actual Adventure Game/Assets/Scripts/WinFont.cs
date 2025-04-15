using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

[RequireComponent(typeof(TextMeshProUGUI))]
public class WinFont : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    private float _justasec;
    private int a = 1;
    private void start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        textObj.fontSize = 0;
    }

    public void winner()
    {
        textObj.fontSize = 75;
        int a = 2;
        _justasec = Time.time + 2f;
    }

    private void Update()
    {
        if (_justasec < Time.time && a == 2)
        {
            Time.timeScale = 0;
        }
    }
}
