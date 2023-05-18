using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Image))]
public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float amountScale = 1.2f;
    public float durationScale = 0.1f;
    private Vector3 _defaultScale;
    private Tween _currentTween;
    public Color colorScale;
    private Color _colorStart;
    public Image image;

    private void Awake()
    {
        _defaultScale = transform.localScale;
        image = GetComponent<Image>();
        _colorStart = image.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
        _currentTween = transform.DOScale(_defaultScale * amountScale,durationScale);
        image.color = new Color(colorScale.r,colorScale.g,colorScale.b);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        _currentTween.Kill();
        transform.localScale = _defaultScale;
        image.color = _colorStart;
    }

    private void OnDisable()
    {
        _currentTween.Kill();
        _currentTween = null;
        transform.localScale = _defaultScale;
        image.color = _colorStart;
    }
}
