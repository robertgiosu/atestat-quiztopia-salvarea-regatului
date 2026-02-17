using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlVolum : MonoBehaviour
{
    public Slider volumeSlider; // Reference to the UI Slider

    void Start()
    {
        // Set the slider's initial value to the current volume
        volumeSlider.value = AudioListener.volume;
        // Add a listener to respond to changes in the slider value
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    void OnVolumeChanged(float volume)
    {
        // Adjust the volume based on the slider value
        AudioListener.volume = volume;
    }
}
