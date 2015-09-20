using UnityEngine;
using System.Collections;

public class Audio4D : MonoBehaviour
{
    public Tesseract targetObject;

    public AudioClip xy;
    public AudioClip xz;
    public AudioClip xw;
    public AudioClip yz;
    public AudioClip yw;
    public AudioClip zw;

    AudioSource source_xy;
    AudioSource source_xz;
    AudioSource source_xw;
    AudioSource source_yz;
    AudioSource source_yw;
    AudioSource source_zw;

    void Start()
    {
        source_xy = gameObject.AddComponent<AudioSource>();
        source_xz = gameObject.AddComponent<AudioSource>();
        source_xw = gameObject.AddComponent<AudioSource>();
        source_yz = gameObject.AddComponent<AudioSource>();
        source_yw = gameObject.AddComponent<AudioSource>();
        source_zw = gameObject.AddComponent<AudioSource>();

        source_xy.clip = xy;
        source_xz.clip = xz;
        source_xw.clip = xw;
        source_yz.clip = yz;
        source_yw.clip = yw;
        source_zw.clip = zw;

        source_xy.loop = true;
        source_xz.loop = true;
        source_xw.loop = true;
        source_yz.loop = true;
        source_yw.loop = true;
        source_zw.loop = true;

        source_xy.Play();
        source_xz.Play();
        source_xw.Play();
        source_yz.Play();
        source_yw.Play();
        source_zw.Play();
    }

    void Update()
    {
        float dampener = 0.15f;

        source_xy.volume = (targetObject.GetRotation(Axis4D.xy) / 360f) * dampener;
        source_xz.volume = (targetObject.GetRotation(Axis4D.xz) / 360f) * dampener;
        source_xw.volume = (targetObject.GetRotation(Axis4D.xw) / 360f) * dampener;
        source_yz.volume = (targetObject.GetRotation(Axis4D.yz) / 360f) * dampener;
        source_yw.volume = (targetObject.GetRotation(Axis4D.yw) / 360f) * dampener;
        source_zw.volume = (targetObject.GetRotation(Axis4D.zw) / 360f) * dampener;
    }
}
