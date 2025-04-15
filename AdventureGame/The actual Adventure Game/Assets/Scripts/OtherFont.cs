using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;
using System.Threading;

[RequireComponent(typeof(TextMeshProUGUI))]

public class OtherFont : MonoBehaviour
{
    private TextMeshProUGUI textObj;

    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
    }

    public void slow()
    {
        textObj.fontSize = 60;
    }

    public void win()
    {
        textObj.fontSize = 0;
    }

    private void Update()
    {
        if (textObj.fontSize != null)
        {
            while (textObj.fontSize != 0)
            {
                textObj.fontSize -= 1;
                Thread.Sleep(1);
            }
        }
    }
}
