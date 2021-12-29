using UnityEngine;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    [SerializeField] private PlayableDirector playableDirector;

    void StartLevel()
    {
        playableDirector.Play();
    }
}