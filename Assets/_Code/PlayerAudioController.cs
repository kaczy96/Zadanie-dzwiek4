using UnityEngine;
using UnityStandardAssets._2D;

public class PlayerAudioController : MonoBehaviour {
    [SerializeField] PlatformerCharacter2D characterController;
    [SerializeField] AudioSource feetSource;
    [SerializeField] AudioSource mouthSource;

    [SerializeField] AudioClip jumpClip;

    void Awake() {
        characterController.PlayerJumpEvent += OnJump;
    }

    public void OnJump() {
        PlayClip(mouthSource, jumpClip);
    }

    void PlayClip(AudioSource source, AudioClip clip) {
        if(source.isPlaying)
            source.Stop();
        source.clip = clip;
        source.Play();
    }
}