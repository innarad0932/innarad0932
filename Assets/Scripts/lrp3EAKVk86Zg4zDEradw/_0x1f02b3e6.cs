using UnityEngine;

// Scrolls the shaft past a camera that never moves.
//
// The template's backgrounds live on a WORLD-SPACE canvas: driving the camera up
// the tower would leave that art behind and the upper shaft would play against
// nothing. So the camera stays put and this rig slides the whole shaft root down
// instead, which looks identical and keeps every canvas where the template put
// it. The impact shake is an offset on the same transform rather than a tween,
// because a tween and a SmoothDamp fighting over one position is a visible
// stutter.
public sealed class _0x1f02b3e6 : MonoBehaviour
{
    private float _0xc94bfe92;
    private float _0x665cc9e3;
    private void LateUpdate()
    {
        if (!this._0x379595b2)
        {
            return;
        }

        this._0xc94bfe92 = Mathf.SmoothDamp(this._0xc94bfe92, this._0xbe76a313, ref this._0x2319ab17, 0.18f);
        float _0xf219483a = 0f;
        float _0x97ba1ad0 = 0f;
        if (this._0x05a8745b > 0f)
        {
            this._0x05a8745b = Mathf.Max(0f, this._0x05a8745b - this._0x3e140383 * Time.deltaTime);
            _0xf219483a = Mathf.Sin(Time.time * 58f) * this._0x05a8745b;
            _0x97ba1ad0 = Mathf.Cos(Time.time * 47f) * this._0x05a8745b;
        }

        this._0xffbbbc62(_0xf219483a, _0x97ba1ad0);
    }

    // Everything the run spawns is a child of this transform, so one translation
    // scrolls walls, ledges, beams, the container and the decay field together.
    private void _0xffbbbc62(float _0x374c43e1, float _0xa01a84d1)
    {
        this.transform.localPosition = new Vector3(_0x374c43e1, -this._0xc94bfe92 + _0xa01a84d1, 0f);
    }

    private float _0xbe76a313;
    public void _0xbb8de802(float _0xcdf72f38)
    {
        this._0xbe76a313 = Mathf.Max(this._0x665cc9e3, _0xcdf72f38);
    }

    public void _0x900dd677(float _0x59d28298)
    {
        this._0x665cc9e3 = _0x59d28298;
        this._0xbe76a313 = _0x59d28298;
        this._0xc94bfe92 = _0x59d28298;
        this._0x379595b2 = true;
        this._0xffbbbc62(0f, 0f);
    }

    public void _0x0717c22b(float _0x4bd7f5d8)
    {
        this._0x05a8745b = _0x4bd7f5d8;
        this._0x3e140383 = _0x4bd7f5d8 / 0.22f;
    }

    private bool _0x379595b2;
    private float _0x3e140383;
    private float _0x05a8745b;
    private float _0x2319ab17;
}