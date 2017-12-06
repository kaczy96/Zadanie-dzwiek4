using UnityEngine;

public class PlayerFootstepsAudioController : MonoBehaviour {
    [SerializeField] AudioClip[] clips;
    [SerializeField] AudioSource source;

    int currentFootstepIndex = -1;

    public void PlayRandomFootstep() {
        if (source.isPlaying)
            source.Stop();
        source.clip = GetRandomFootstep();
        Randomise();
        source.Play();
    }

    AudioClip GetRandomFootstep() {
        var index = 0;
        while (currentFootstepIndex == index)
            index = Random.Range(0, clips.Length);
        currentFootstepIndex = index;
        return clips[index];
    }

    void Randomise() {
        //losowy pitch i volume (z tym drugim bez zbytniej przesady)
    }
}