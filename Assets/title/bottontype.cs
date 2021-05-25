using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class bottontype : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public BottonType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;
    public CanvasGroup optionGroup;
    public void Start()
    {
        defaultScale = buttonScale.localScale;
    }
    bool isSound;
    public void OnBottonClick()
    {
        switch(currentType)
        {
            case BottonType.New:
                manager.LoadSceneHandle("SampleScene", 0);
                break;
            case BottonType.Continue:
                manager.LoadSceneHandle("SampleScene", 1);
                break;
            case BottonType.Option:
                CanvasGroupOn(optionGroup);
                CanvasGroupOff(mainGroup);
                break;
            case BottonType.Sound:
                if(isSound)
                {
                    isSound = !isSound;
                    Debug.Log("종료");
                    break;
                }
                else
                {
                    Debug.Log("종료");
                    break;
                    //사운드on
                }
            case BottonType.Back:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(optionGroup);
                break;
            case BottonType.Quit:
                Application.Quit();
                Debug.Log("종료");
                break;
            case BottonType.Restart:
                manager.LoadSceneHandle("SampleScene", 0);
                break;
            case BottonType.MainMenu:
                manager2.LoadSceneHandle2("title", 0);
                break;
        }
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }
    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.2f;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
