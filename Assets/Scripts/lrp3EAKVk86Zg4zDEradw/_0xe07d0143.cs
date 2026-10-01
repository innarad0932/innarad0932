using System.Collections;
using DG.Tweening;
using UnityEngine;

// The cargo container the player drives. It owns only its own presentation -
// size, tint, the clamp punch and the impact flash. Where it goes is decided by
// the run director.
public sealed class _0xe07d0143 : MonoBehaviour
{
    private IEnumerator _0x0589fc8e()
    {
        float _0x6d4db4e2 = 0f;
        const float _0x7e0d8214 = 0.24f;
        while (_0x6d4db4e2 < _0x7e0d8214)
        {
            _0x6d4db4e2 += Time.deltaTime;
            float _0x1a378f43 = Mathf.Sin(Mathf.Clamp01(_0x6d4db4e2 / _0x7e0d8214) * Mathf.PI);
            this._renderer.size = this._0x6e422e39 * (1f + 0.12f * _0x1a378f43);
            yield return null;
        }

        this._renderer.size = this._0x6e422e39;
        this._0xd31c5fb9 = null;
    }

    private Vector2 _0x6e422e39;
    private Color _0x69ff3362;
    public void _0x9600e711(Color _0x0be86850)
    {
        if (this._renderer == null)
        {
            return;
        }

        DOTween.Kill(this._renderer);
        this._renderer.color = _0x0be86850;
        this._renderer.DOColor(this._0x69ff3362, 0.32f).SetEase(Ease.OutQuad);
    }

    public void _0x681a3e6e(float _0x5807d000, Color _0x44aa2e25)
    {
        this._0x6e422e39 = new Vector2(_0x5807d000, _0x5807d000);
        this._0x69ff3362 = _0x44aa2e25;
        if (this._renderer != null)
        {
            this._renderer.size = this._0x6e422e39;
            this._renderer.color = _0x44aa2e25;
        }
    }

    public void SetTilt(float _0xed2f2af0)
    {
        this.transform.localRotation = Quaternion.Euler(0f, 0f, _0xed2f2af0);
    }

    public float _0x7e184c74
    {
        get
        {
            return this._0x6e422e39.x * 0.5f;
        }
    }

    // The clamp punch is driven through renderer.size, never through the transform
    // scale: the sprite is authored with an explicit size and the two must not fight.
    public void _0xa13613b3()
    {
        if (this._renderer == null || !this.isActiveAndEnabled)
        {
            return;
        }

        if (this._0xd31c5fb9 != null)
        {
            this.StopCoroutine(this._0xd31c5fb9);
        }

        this._0xd31c5fb9 = this.StartCoroutine(this._0x0589fc8e());
    }

    private Coroutine _0xd31c5fb9;
    public float _0x84791234
    {
        get
        {
            return this._0x6e422e39.y * 0.5f;
        }
    }

    [SerializeField]
    private SpriteRenderer _renderer;
    public void _0xb474f1bb(float _0xeaf6cc77, float _0x3df9e0c6)
    {
        this.transform.localPosition = new Vector3(_0xeaf6cc77, _0x3df9e0c6, 0f);
    }
}