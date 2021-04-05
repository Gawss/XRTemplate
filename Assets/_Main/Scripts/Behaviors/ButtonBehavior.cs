using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    private Image currentImage;
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private Sprite secondarySprite;

    // Start is called before the first frame update
    void Start()
    {
        currentImage = this.GetComponent<Image>();
    }

    public void SwitchIcon()
    {
        if (currentImage.sprite == defaultSprite) currentImage.sprite = secondarySprite;
        else currentImage.sprite = defaultSprite;
    }
}
