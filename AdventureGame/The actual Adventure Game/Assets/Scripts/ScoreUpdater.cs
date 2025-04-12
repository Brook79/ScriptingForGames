using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

[RequireComponent(typeof(TextMeshProUGUI))]
public class SimpleTextMeshProBehavior : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public SimpleIntData dataObj;
	private float _shaketime;
	private float _leftwards;
	private float _rightwards;

    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        UpdateWithIntData();
    }

    public void UpdateWithIntData()
    {
        textObj.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}
