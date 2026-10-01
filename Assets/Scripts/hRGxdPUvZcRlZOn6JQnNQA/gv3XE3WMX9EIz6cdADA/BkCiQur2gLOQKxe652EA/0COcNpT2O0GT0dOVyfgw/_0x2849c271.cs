using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x2849c271 : MonoBehaviour
{
    public float DefaultAnimationTime = 0.4f;
    public void _0xde8e230a()
    {
        this._0x63bdc02c?.Pause();
    }

    private Sequence _0x63bdc02c;
    public static _0x2849c271 Instance;
    public void _0xce8e70b8()
    {
        this._0x63bdc02c?.Kill();
        this.AnimationSlider.value = _0x96b34728 ? this.SecondPassSliderValue : 0.05f;
    }

    public GameObject Background;
    public Slider AnimationSlider;
    public void _0x5ee9341d()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x63bdc02c?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x96b34728 = false;
    }

    public GameObject Content;
    private static bool _0x96b34728 = false;
    public float FirstAnimationTime = 10.0f;
    public GameObject Error;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xcb53ffe7._0xd8635e47.SCENE_0 && !_0x96b34728)
        {
            this._0x0c417d10();
        }
        else
        {
            this._0x752c90c0();
        }
    }

    private void _0x0c417d10()
    {
        this.AnimationSlider.value = 0.05f;
        _0x96b34728 = !_0x96b34728;
        this._0x63bdc02c = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x3f26011a => this.AnimationSlider.value = _0x3f26011a, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x38c9f1f2._0x38a77c79?._0xd396cda6();
        });
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x2849c271>();
    }

    public float SecondPassSliderValue = 0.5f;
    public void _0x752c90c0()
    {
        this._0xce8e70b8();
        bool _0x5e8ca875 = _0x96b34728;
        this._0x63bdc02c = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x3f26011a => this.AnimationSlider.value = _0x3f26011a, _0x5e8ca875 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x96b34728 = !_0x96b34728;
    }

    public void _0x25ead04b()
    {
        this._0x63bdc02c?.Play();
    }
}