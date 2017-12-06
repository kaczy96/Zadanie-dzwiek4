using UnityEngine;
using UnityEngine.UI;

public class VolumePanel : MonoBehaviour {
    [SerializeField] Slider volumeSlider;

    void Awake() {
        volumeSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    void OnSliderValueChanged(float value) {
        Controllers.soundManager.SetMasterVolume(value);
    }
}