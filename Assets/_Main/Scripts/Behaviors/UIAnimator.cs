using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class UIAnimator : MonoBehaviour
{
    private Vector3 defaultScale;

    private void OnEnable()
    {
        PlayFadeIn();
    }

    public void PlayFadeIn()
    {
        defaultScale = this.transform.localScale;
        this.transform.localScale = Vector3.zero;
        this.transform.DOScale(defaultScale, 1.5f);
    }

    public void OnPanelHoverEnter(TextMeshProUGUI txtPro)
    {
        txtPro.color = SceneManager.Instance.settings.currentEnv.highlightColor;
    }

    public void OnPanelHoverExit(TextMeshProUGUI txtPro)
    {
        txtPro.color = SceneManager.Instance.settings.currentEnv.txtColor;
    }

    public void ToggleGameObj(GameObject go)
    {
        go.SetActive(!go.activeSelf);
    }
}
