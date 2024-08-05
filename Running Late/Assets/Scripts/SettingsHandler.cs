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

        int currResolutions = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + "@" + resolutions[i].refreshRateRatio + "hz";
            options.Add(option);

            if ((resolutions[i].width == Screen.currentResolution.width) && (resolutions[i].height == Screen.currentResolution.height))
            {
                currResolutions = i;
            }
        }

        Resolution.AddOptions(options);
        Resolution.value = currResolutions;
        Resolution.RefreshShownValue();
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

    public void setRes(int resIndex)
    {
        Resolution resolution = resolutions[resIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
