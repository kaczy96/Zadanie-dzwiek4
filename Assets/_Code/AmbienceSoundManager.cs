using UnityEngine;
using UnityEngine.Audio;

public class AmbienceSoundManager : MonoBehaviour {
    [SerializeField] AudioMixerSnapshot meadow;
    [SerializeField] AudioMixerSnapshot forest;

    public void TransitionToMeadow() {
        meadow.TransitionTo(1.0f);
    }

    public void TransitionToForest() {
        forest.TransitionTo(1.0f);
    }
}