using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeQualitySettingsUI : MonoBehaviour
{
    [SerializeField] private Toggle toggle;
    [SerializeField] private int qualityIndex = -1;

    void OnEnable()
    {
        var currentQuality = QualitySettings.GetQualityLevel();
        toggle.isOn = (qualityIndex == currentQuality);
        toggle.onValueChanged.AddListener(OnValueChanged);
    }

    private void OnValueChanged(bool isOn)
    {
        if (isOn)
        {
            QualitySettings.SetQualityLevel(qualityIndex);
        }
    }

    void Reset()
    {
        if (toggle == null)
        {
            toggle = GetComponent<Toggle>();
        }
    }
}
