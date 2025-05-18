using UnityEngine;

public class ParticleExample : MonoBehaviour
{
    public ParticleSystem explosionEffect;

    public void Start()
    {
        Explode();
    }

    public void Explode()
    {
        explosionEffect.Play();
    }

}
