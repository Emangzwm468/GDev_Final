using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsHandler : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Dropdown Resolution;
    Resolution[] resolutions;
    void Start()
    {
        resolutions = Screen.resolutions;

        Resolution.ClearOptions();

        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + "@" + resolutions[i].refreshRateRatio + "hz";
            options.Add(option);
        }

        Resolution.AddOptions(options);
    }
    public void Setvolume (float volume)
    {
        Debug.Log(volume);
    }

    public void Qualityset (int quality)
    {
        QualitySettings.SetQualityLevel (quality);
    }

    public void Fullscreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }
}
