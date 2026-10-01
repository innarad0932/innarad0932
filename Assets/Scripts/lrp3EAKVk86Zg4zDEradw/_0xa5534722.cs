using UnityEngine;

// One sweeping energy beam. Its horizontal motion is a bounded sine, so the beam
// physically cannot leave the shaft and the corridor beside it is always
// ShaftInnerWidth - Width wide. The run director ticks it, so pausing the game is
// simply not calling Step.
public sealed class _0xa5534722 : MonoBehaviour
{
    public float _0xbf5242a1
    {
        get
        {
            return this._0xb6738ef8;
        }
    }

    public void _0x5732d7e1(float _0x2025311f)
    {
        if (this._0x1ec64267 == null)
        {
            return;
        }

        Vector3 _0x40281af9 = this.transform.localPosition;
        _0x40281af9.x = this._0x1ec64267._0x8920a821(_0x2025311f);
        this.transform.localPosition = _0x40281af9;
        if (this._renderer != null)
        {
            // A slow breath on the core, so a beam reads as live energy rather than
            // a painted bar even while the player is standing still.
            this._0xea0c4361 = _0x2025311f * 2.4f + this._0x1ec64267.Phase;
            Color _0x8734452b = this._renderer.color;
            _0x8734452b.a = 0.85f + 0.15f * Mathf.Abs(Mathf.Sin(this._0xea0c4361));
            this._renderer.color = _0x8734452b;
        }
    }

    [SerializeField]
    private SpriteRenderer _renderer;
    private float _0xb6738ef8;
    public float _0xd6e9ea88
    {
        get
        {
            return this._0x1ec64267 == null ? 0f : this._0x1ec64267.Y;
        }
    }

    private float _0xea0c4361;
    public float _0x274dd850
    {
        get
        {
            return this._0x1ec64267 == null ? 0f : this._0x1ec64267.Width * 0.5f;
        }
    }

    private _0xba2ddbf5._0xdb7d2ef1 _0x1ec64267;
    public bool _0x6346b29e(float _0x18966b8e, float _0xe006e975, float _0x2340e377, float _0x718964ec)
    {
        if (this._0x1ec64267 == null)
        {
            return false;
        }

        if (Mathf.Abs(_0xe006e975 - this.transform.localPosition.y) > _0x718964ec + this._0xb6738ef8 * 0.5f)
        {
            return false;
        }

        return Mathf.Abs(_0x18966b8e - this.transform.localPosition.x) < _0x2340e377 + this._0x274dd850;
    }

    public void _0xd5ffd075(_0xba2ddbf5._0xdb7d2ef1 _0x758044bd, float _0xa502cf61, Color _0x545bc58f)
    {
        this._0x1ec64267 = _0x758044bd;
        this._0xb6738ef8 = _0xa502cf61;
        if (this._renderer != null)
        {
            this._renderer.size = new Vector2(_0x758044bd.Width, _0xa502cf61);
            this._renderer.color = _0x545bc58f;
        }

        this.transform.localPosition = new Vector3(_0x758044bd._0x8920a821(0f), _0x758044bd.Y, 0f);
        this._0xea0c4361 = _0x758044bd.Phase;
    }
}