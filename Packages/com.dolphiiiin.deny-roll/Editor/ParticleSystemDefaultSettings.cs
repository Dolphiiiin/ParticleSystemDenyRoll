#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class ParticleSystemDefaultSettings
{
    static ParticleSystemDefaultSettings()
    {
        ObjectFactory.componentWasAdded += OnComponentAdded;
    }

    private static void OnComponentAdded(Component component)
    {
        if (component is ParticleSystem)
        {
            ParticleSystem particleSystem = (ParticleSystem)component;
            ParticleSystemRenderer particleSystemRenderer = particleSystem.GetComponent<ParticleSystemRenderer>();
            
            particleSystemRenderer.allowRoll = false;
            Debug.Log("Deny Roll: " + particleSystem.name + "Renderer's allowRoll is set to false");
        }
    }
}
#endif
