using UnityEngine;
using UnityEngine.Events;

public class ActionOnTrigger : MonoBehaviour {
    public UnityEvent onTriggerEnter = new UnityEvent();

    void OnTriggerEnter2D(Collider2D collider2D) {
        onTriggerEnter.Invoke();
    }
}