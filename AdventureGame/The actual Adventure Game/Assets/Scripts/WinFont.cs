using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;
using System.Threading;

[RequireComponent(typeof(TextMeshProUGUI))]
public class WinFont : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    private float _justasec = 0;
    private int a = 1;
    private void start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        textObj.fontSize = 0;
    }

    public void winner()
    {
        Time.timeScale = 0;
    }

    public void pineappel()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        textObj.fontSize = 45;
        _justasec = Time.time + 3f;
    }

    private void Update()
    {
        if (_justasec != 0 && textObj.fontSize != null)
        {
            if (_justasec <= Time.time)
            {
                textObj.fontSize = 0;
            }
        }
    }
}
