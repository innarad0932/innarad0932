using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x64710ced : MonoBehaviour
{
    public void Show()
    {
        this._0xd167ec7e();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x3e2c0a04.Instance._0x6cb9a7a8(_0x3e2c0a04.Instance.CurrentPanelIndex);
            });
        }
    }

    public Ease Ease = Ease.OutSine;
    public bool IsScaledDownOnAwake = true;
    public GameObject OuterBackground;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x3c5b007e();
    }

    private void _0xad0bd423()
    {
        if (this.OuterBackground != null)
        {
            Image _0x73006492 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x73006492, true);
            _0x73006492.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0x3c5b007e()
    {
        if (this.OuterBackground != null)
        {
            Image _0x143a5724 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x143a5724, true);
            _0x143a5724.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public void _0x518dbc39()
    {
        this._0xad0bd423();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private bool _0xc94811d9 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public GameObject Content;
    public TMP_Text MainText;
    private void _0xd167ec7e()
    {
        if (this.OuterBackground != null)
        {
            Image _0xa9f3dc97 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xa9f3dc97, true);
            _0xa9f3dc97.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public float ScaleDuration = 0.4f;
    private void _0xda112384()
    {
        if (this.OuterBackground != null)
        {
            Image _0xbb60f625 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xbb60f625, true);
            _0xbb60f625.DOFade(1f, 0f);
        }
    }

    public TMP_Text HeaderText;
    public void _0x2b9b4b04()
    {
        this._0xda112384();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x3e2c0a04.Instance._0x6cb9a7a8(_0x3e2c0a04.Instance.CurrentPanelIndex);
    }
}