using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour {
    [SerializeField] AudioMixer masterMixer;

    void Awake() {
        Controllers.soundManager = this;
    }

    public void SetMasterVolume(float value) {
        masterMixer.SetFloat("MasterVolume", value);
        
    }
}