using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SFX : MonoBehaviour
{
    AudioSource clip;
    void Start() { Score.scored += GetComponent<AudioSource>().Play; }
}
