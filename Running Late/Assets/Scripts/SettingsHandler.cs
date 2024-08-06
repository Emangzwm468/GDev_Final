using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsHandler : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Dropdown Resolution;
    Resolution[] resolutions;

    [SerializeField] AudioMixer audioMixer;
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
        audioMixer.SetFloat("MusicVol", Mathf.Log10(volume) * 20);
    }

    public void Qualityset (int quality)
    {
        QualitySettings.SetQualityLevel (quality);
    }

    public void Lowquality()
    {
        QualitySettings.SetQualityLevel(0, true);
    }

    public void Medquality()
    {
        QualitySettings.SetQualityLevel(1, true);
    }

    public void Hiquality()
    {
        QualitySettings.SetQualityLevel(2, true);
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
