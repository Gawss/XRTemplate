using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public enum Theme
    {
        dark = 0,
        light = 1
    }

    [Header("Environment Elements")]
    [SerializeField] private GameObject floor;
    private Renderer floorRenderer;
    [SerializeField] private Theme theme;

    [Header("Light Environment")]
    [SerializeField] private Environment lightEnv;

    [Header("Dark Environment")]
    [SerializeField] private Environment darkEnv;

    [HideInInspector] public Environment currentEnv;
    private CanvasBehavior[] allCanvas;

    // Start is called before the first frame update
    void Start()
    {
        floorRenderer = floor.GetComponent<Renderer>();
        allCanvas = FindObjectsOfType<CanvasBehavior>();
        UpdateTheme((int)theme);
    }

    public void UpdateTheme(int newTheme)
    {
        theme = (Theme)newTheme;
        switch (theme)
        {
            case Theme.light:
                currentEnv = lightEnv;
                break;
            case Theme.dark:
                currentEnv = darkEnv;
                break;
        }
        currentEnv.Set(floorRenderer, allCanvas);
    }

    public void ToggleTheme()
    {
        if (theme == Theme.light)
        {
            theme = Theme.dark;
            currentEnv = darkEnv;
        }
        else
        {
            theme = Theme.light;
            currentEnv = lightEnv;
        }

        currentEnv.Set(floorRenderer, allCanvas);
    }
}

[System.Serializable]
public class Environment
{
    [SerializeField] private Material floorMaterial;
    [SerializeField] private Material skyboxMaterial;
    [SerializeField] private Color fogColor;

    public Color backgroundColor;
    public Color backgroundSecondColor;
    public Color txtColor;
    public Color borderColor;

    public Color highlightColor;
    public void Set(Renderer _floorRenderer, CanvasBehavior[] _allCanvas)
    {
        _floorRenderer.material = floorMaterial;
        RenderSettings.skybox = skyboxMaterial;
        RenderSettings.fogColor = fogColor;

        foreach(var canvas in _allCanvas)
        {
            canvas.background.color = backgroundColor;
            canvas.border.color = borderColor;
            foreach(var txt in canvas.texts)
            {
                txt.color = txtColor;
            }
        }
        
    }
}
