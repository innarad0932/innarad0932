using UnityEngine;

// The decay field eating the shaft from below. It is the only clock in the game:
// nothing else can end a run that the player is not actively steering, and every
// successful clamp buys the player another section of head room.
public sealed class _0x9d98541b : MonoBehaviour
{
    public float _0xe2b5f58f
    {
        get
        {
            return this._0xf6173bdb;
        }
    }

    private void _0xf7754076()
    {
        this.transform.localPosition = new Vector3(0f, this._0xf6173bdb + this._0x206fa88a - this._0x717b815c * 0.5f, 0f);
        if (this._haze != null)
        {
            Vector3 _0x1b4f923e = this._haze.transform.localPosition;
            _0x1b4f923e.x = 0f;
            _0x1b4f923e.y = this._0x717b815c * 0.5f + this._0x2670b5ef * 0.5f;
            this._haze.transform.localPosition = _0x1b4f923e;
        }
    }

    private float _0xf6173bdb;
    private float _0x2670b5ef;
    [SerializeField]
    private SpriteRenderer _haze;
    private float _0x206fa88a;
    [SerializeField]
    private SpriteRenderer _renderer;
    public void _0xd823a0d0(float width, float _0xc04fc448, float _0x24ffd047, Color _0x80589a84, Color _0xba5951d1)
    {
        this._0x717b815c = _0xc04fc448;
        this._0x2670b5ef = _0xc04fc448 * 0.5f;
        this._0xf6173bdb = _0x24ffd047;
        if (this._renderer != null)
        {
            this._renderer.size = new Vector2(width, _0xc04fc448);
            this._renderer.color = _0x80589a84;
        }

        if (this._haze != null)
        {
            this._haze.size = new Vector2(width, this._0x2670b5ef);
            this._haze.color = _0xba5951d1;
        }

        this._0xf7754076();
    }

    private float _0x717b815c;
    public void _0x136d9c94(float amount)
    {
        this._0xf6173bdb += amount;
        this._0xf7754076();
    }

    public void _0xe8c3670b(float _0x29ec85eb)
    {
        this._0x206fa88a = Mathf.Sin(_0x29ec85eb * 2.1f) * 0.03f;
        this._0xf7754076();
    }
}