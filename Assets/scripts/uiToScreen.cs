using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class UiToScreen : MonoBehaviour, IPointerClickHandler
{
    public bool isOnScreen = false;
    private RectTransform sizeRect;
    private Canvas canvas;
    public GameObject closeButton;
    private Vector3 origin;
    public void OnPointerClick(PointerEventData eventData)
    {
        // Handle click or touch here
        Debug.Log("It'sClick");
        origin = sizeRect.localPosition;
        goToScreen();
    }
    public void Start()
    {
        canvas = gameObject.GetComponent<Canvas>();
        sizeRect = gameObject.GetComponent<RectTransform>();
    }

    public void goToScreen()
    {
        if (isOnScreen == false)
        {
            isOnScreen = true;
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
            closeButton.SetActive(true);
        }

    }
    public void closeScreen()
    {
        if (isOnScreen == true)
        {
            isOnScreen = false;
            canvas.renderMode = RenderMode.WorldSpace;
            sizeRect.localPosition = origin;
            sizeRect.localRotation = Quaternion.identity;
            sizeRect.sizeDelta = new Vector2(720, 1280);
            sizeRect.localScale = new Vector3(0.1f, 0.1f, 0.1f);

            closeButton.SetActive(false);
        }
    }
}