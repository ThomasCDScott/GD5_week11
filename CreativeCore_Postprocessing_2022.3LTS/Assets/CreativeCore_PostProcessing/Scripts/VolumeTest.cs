using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
public class VolumeTest : MonoBehaviour
{
    public Volume globalVolume;
    ColorAdjustments _colAdj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        globalVolume.profile.TryGet(out _colAdj);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
