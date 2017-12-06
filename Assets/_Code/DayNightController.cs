using System;
using UnityEngine;
using UnityEngine.Audio;

public class DayNightController : MonoBehaviour {
    public static event Action<TimeOfDay> TimeOfDayChangedEvent = delegate { };

    [SerializeField] AudioMixerSnapshot Day;
    [SerializeField] AudioMixerSnapshot Sunset;
    [SerializeField] AudioMixerSnapshot Night;

    TimeOfDay timeOfDay;

    public TimeOfDay TimeOfDay {
        get {
            return timeOfDay;
        }
        set {
            if (timeOfDay != value) {
                TimeOfDayChangedEvent(value);
                timeOfDay = value;
            }
        }
    }

    public void GotoNextStage() {
        TimeOfDay = (TimeOfDay) (((int) timeOfDay + 1) % 3);
        Debug.Log("Time of day is: " + timeOfDay);

        if (TimeOfDay == TimeOfDay.Day)
        {
            Day.TransitionTo(0.001f);
        }

        else if (TimeOfDay == TimeOfDay.Sunset)
        {
            Sunset.TransitionTo(0.001f);
        }

        else if (TimeOfDay == TimeOfDay.Night)
        {
            Night.TransitionTo(0.001f);
        }
    }
}