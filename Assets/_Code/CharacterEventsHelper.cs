using UnityEngine;

public class CharacterEventsHelper : MonoBehaviour {
    [SerializeField] PlayerFootstepsAudioController footstepsController;

    public void PlayFootstep() {
        footstepsController.PlayRandomFootstep();
    }
}