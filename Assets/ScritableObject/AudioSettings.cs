using UnityEngine;

[CreateAssetMenu(fileName = "AudioSettings", menuName = "ScriptableObjects/Audio Settings")]
public class AudioSettings : ScriptableObject
{
    public float masterV = 1f;
    public float musicV = 1f;
    public float sfxV = 1f;
}
