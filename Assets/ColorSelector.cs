using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelector : MonoBehaviour
{
    [SerializeField]
    private List<ColorOption> colorOptions = new List<ColorOption>()
    {
        new ColorOption { name = "Red", color = Color.red, isSelected = false },
        new ColorOption { name = "Green", color = Color.green, isSelected = true },
        new ColorOption { name = "Blue", color = Color.blue, isSelected = false }
    };

    // Other script logic...

    private void OnGUI()
    {
        GUILayout.Label("Select Colors:");

        foreach (var option in colorOptions)
        {
            option.isSelected = GUILayout.Toggle(option.isSelected, option.name);
        }
    }
}

[System.Serializable]
public class ColorOption
{
    public string name;
    public Color color;
    public bool isSelected;
}
