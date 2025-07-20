using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class WeatherSystem : MonoBehaviour
{
    [Header("Global")]
    public Material globalMaterial;
    public Light sunLight;
    public Material skyboxMaterial;
    public TMP_Text weatherText;

    [Header("Winter Assets")]
    public ParticleSystem winterParticleSystem;
    public Volume winterVolume;

    [Header("Rain Assets")]
    public ParticleSystem rainParticleSystem;
    public Volume rainVolume;

    [Header("Autumn Assets")]
    public ParticleSystem autumnParticleSystem;
    public Volume autumnVolume;

    [Header("Summer Assets")]
    public ParticleSystem summerParticleSystem;
    public Volume summerVolume;

    private void Start()
    {
        Summer();
    }

    public void Winter()
    {
        winterParticleSystem.Play();
        winterVolume.gameObject.SetActive(true);
        globalMaterial.SetFloat("_SnowFade", 1);

        rainParticleSystem.Stop();
        rainVolume.enabled = false;
        globalMaterial.SetFloat("_Metallic", 0);
        autumnParticleSystem.Stop();
        autumnVolume.enabled = false;
        summerParticleSystem.Stop();
        summerVolume.enabled = false;
    }

    public void Rain()
    {
        rainParticleSystem.Play();
        rainVolume.gameObject.SetActive(true);
        globalMaterial.SetFloat("_Metallic", 1);

        winterParticleSystem.Stop();
        winterVolume.enabled = false;
        globalMaterial.SetFloat("_SnowFade", 0);
        autumnParticleSystem.Stop();
        autumnVolume.enabled = false;
        summerParticleSystem.Stop();
        summerVolume.enabled = false;
    }

    public void Autumn()
    {
        rainParticleSystem.Play();
        rainVolume.gameObject.SetActive(true);
        globalMaterial.SetFloat("_Metallic", 0.5f);

        winterParticleSystem.Stop();
        winterVolume.enabled = false;
        globalMaterial.SetFloat("_SnowFade", 0);
        rainParticleSystem.Stop();
        rainVolume.enabled = false;
        summerParticleSystem.Stop();
        summerVolume.enabled = false;
    }

    public void Summer()
    {
        summerParticleSystem.Play();
        summerVolume.gameObject.SetActive(true);
        

        winterParticleSystem.Stop();
        winterVolume.enabled = false;
        globalMaterial.SetFloat("_SnowFade", 0);
        autumnParticleSystem.Stop();
        autumnVolume.enabled = false;
        globalMaterial.SetFloat("_Metallic", 0);
        rainParticleSystem.Stop();
        rainVolume.enabled = false;
        
    }

}
