using UnityEngine;

[RequireComponent(typeof(SonarFx))]
public class SonarFxSwitcher : MonoBehaviour
{
    public Gradient baseAlbedo;
    public Gradient baseEmission;
    public Gradient waveColor;
    public float switchSpeed = 5;
    public GameObject winLevel;
    SonarFx fx;
    float parameter = 1;
    float target;

    public bool state
    {
        get { return target > 0.0f; }
        set { target = state ? 1.0f : 0.0f; }
    }

    void Awake()
    {
        fx = GetComponent<SonarFx>();
        fx.enabled = true;
    }

    void Update()
    {
        if (parameter == 1)
        {
            // set colour to red
            fx.waveColor = waveColor.Evaluate(1);
        }
        else
        {
            // if false then set the colour of the wave to black
            // making it not visible
            fx.waveColor = waveColor.Evaluate(0);
        }

        // 0 makes scene light
        // 1 makes the scene dark
        fx.baseColor = baseAlbedo.Evaluate(1);

        // 0 makes everything white
        // 1 makes everything black/dark
        fx.addColor = baseEmission.Evaluate(1);
    }

    public void Toggle()
    {
        if (parameter == 1)
        {
            parameter = 0;
        }
        else
        {
            parameter = 1;
        }
    }
}