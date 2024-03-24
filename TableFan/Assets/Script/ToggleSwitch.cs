using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ToggleSwitch : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private bool _isPlay = false;
    public bool isPlay { get { return _isPlay; } }
    [SerializeField] private RectTransform toggleIndicator;
    [SerializeField] private Image backgroundImage;
    [SerializeField] private Color playColor;
    [SerializeField] private Color createColor;
    private float playPos;
    private float createPos;
    [SerializeField] private float tweenTime = 0.25f;
    public delegate void ValueChanged(bool value);
    public event ValueChanged valueChanged;
    void Start()
    {
        playPos = toggleIndicator.anchoredPosition.x;
        playPos = backgroundImage.rectTransform.rect.width - toggleIndicator.rect.width;
    }
    private void OnEnable()
    {
        Toggle(isPlay);
    }
    private void Toggle(bool value)
    {
        if (value != isPlay)
        {
            _isPlay = value;
            ToggleColor(isPlay);
            MoveIndicator(isPlay);

            if (valueChanged != null)
                valueChanged(isPlay);
        }
    }
    private void ToggleColor(bool value)
    {
        if (value)
            backgroundImage.DOColor(playColor, tweenTime);
        else
            backgroundImage.DOColor(createColor, tweenTime);
    }
    private void MoveIndicator(bool value)
    {
        if (value)
            toggleIndicator.DOAnchorPosX(playPos, tweenTime);
        else
            toggleIndicator.DOAnchorPosX(createPos, tweenTime);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Toggle(!_isPlay);
    }
}//这个脚本实现了一个切换开关的功能，并且可以与UI交互。以下是对代码功能的解释：切换开关

/*isPlay 是一个公共属性，用于获取当前开关的状态。
toggleIndicator 是一个RectTransform类型的变量，代表开关指示器的UI元素。
backgroundImage 是一个Image类型的变量，代表背景图的UI元素。
playColor 和 createColor 分别是开关打开和关闭时背景图的颜色。
playPos 和 createPos 是开关打开和关闭时指示器位置的值。
tweenTime 是开关颜色和位置动画的持续时间。
valueChanged 是一个事件，当开关的值改变时触发。
Toggle 方法用于切换开关状态，并触发相应的颜色和位置动画。
ToggleColor 方法根据开关状态切换背景图的颜色。
MoveIndicator 方法根据开关状态切换指示器的位置。
OnPointerDown 是UI事件处理方法，当用户点击开关时切换开关的状态。
因此，将该脚本绑定到一个ToggleSwitch的UI对象上，可以实现一个可交互的切换开关。根据开关的状态，会播放相应的颜色和位置动画，并触发相应的事件。
*/






