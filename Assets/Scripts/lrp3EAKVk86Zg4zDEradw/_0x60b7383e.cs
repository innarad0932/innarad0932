using UnityEngine;

// A wall ledge the container can clamp onto. It lights up gold while it is inside
// the clamp window, which is the game's only "release now" cue.
public sealed class _0x60b7383e : MonoBehaviour
{
    private bool _0xfddf5cc1;
    private Color _0xe9849395;
    private Color _0x60a7c819;
    public void _0x182e6d1d(bool _0x85eaee58)
    {
        if (this._0x78429515 == _0x85eaee58)
        {
            return;
        }

        this._0x78429515 = _0x85eaee58;
        this._0x81774b0c();
    }

    public void _0x70ad1924(bool _0x6b9851b8)
    {
        if (this._0xfddf5cc1 == _0x6b9851b8)
        {
            return;
        }

        this._0xfddf5cc1 = _0x6b9851b8;
        this._0x81774b0c();
    }

    private void _0x81774b0c()
    {
        if (this._renderer == null)
        {
            return;
        }

        if (this._0x78429515)
        {
            this._renderer.color = this._0x892215bd;
            return;
        }

        this._renderer.color = this._0xfddf5cc1 ? this._0xe9849395 : this._0x60a7c819;
    }

    private bool _0x78429515;
    private Color _0x892215bd;
    [SerializeField]
    private SpriteRenderer _renderer;
    public void _0x0f78b31d(float width, float height, int _0x86b26197, Color _0x8544d4f7, Color _0xbe0ea47f, Color _0xd5d6c96e)
    {
        this._0x60a7c819 = _0x8544d4f7;
        this._0xe9849395 = _0xbe0ea47f;
        this._0x892215bd = _0xd5d6c96e;
        if (this._renderer != null)
        {
            this._renderer.size = new Vector2(width, height);
            this._renderer.flipX = _0x86b26197 > 0;
            this._renderer.color = _0x8544d4f7;
        }
    }
}