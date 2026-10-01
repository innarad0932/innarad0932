using UnityEngine;

// Every world size in the game is derived here from the camera, never written as
// a literal, so the shaft fits a 19.5:9 phone and a 20:9 phone equally.
public sealed class _0xfeee9a77
{
    public float WallThickness;
    public float SectionStep;
    // How far across to the next ledge the container has swung. It hugs the wall
    // it launched from for most of the climb and only latches over once the ledge
    // is within reach - that is what keeps a beam sweeping the middle of the shaft
    // dodgeable, and it is the SAME curve the layout solver simulates.
    public float _0x2d7c6d07(float _0x45ef6d41)
    {
        float _0x8d1b0de2 = Mathf.Clamp01(1f - _0x45ef6d41 / Mathf.Max(0.001f, this.LatchWindow));
        return _0x8d1b0de2 * _0x8d1b0de2 * (3f - 2f * _0x8d1b0de2);
    }

    public float BracketInset;
    public float BeaconSize;
    public float CameraLead;
    public float WallX;
    public float ContainerWidth;
    public float HalfWidth;
    public float LatchWindow;
    public float BracketHeight;
    // Horizontal centre of the container when it is clamped on a bracket of the
    // given side (-1 left, +1 right), including the small per-bracket jitter the
    // layout generator adds.
    public float _0x672509ab(int _0x7db9584d, float _0xea601eac)
    {
        return _0x7db9584d * this.BracketInset + _0xea601eac;
    }

    public float ScreenHeight;
    public float ShaftInnerWidth;
    public float SparkSize;
    public void _0x56eddef9(Camera _0xbad9cd9b)
    {
        float _0x180d02e8 = 5f;
        float _0x0c0b2e03 = 0.4615f;
        if (_0xbad9cd9b != null)
        {
            _0x180d02e8 = _0xbad9cd9b.orthographicSize;
            if (_0xbad9cd9b.aspect > 0.05f)
            {
                _0x0c0b2e03 = _0xbad9cd9b.aspect;
            }
        }

        this.HalfHeight = _0x180d02e8;
        this.HalfWidth = _0x180d02e8 * _0x0c0b2e03;
        this.ScreenWidth = this.HalfWidth * 2f;
        this.ScreenHeight = this.HalfHeight * 2f;
        this.ShaftInnerWidth = this.ScreenWidth * 0.78f;
        this.WallX = this.ShaftInnerWidth * 0.5f;
        this.WallThickness = this.ScreenWidth * 0.16f;
        this.WallSegmentHeight = this.HalfHeight * 0.48f;
        this.SectionStep = this.HalfHeight * 0.24f;
        this.ContainerWidth = this.ShaftInnerWidth * 0.135f;
        this.BracketWidth = this.ShaftInnerWidth * 0.2f;
        // Every generated sprite ships as a 512x512 square, so a ledge is drawn
        // square too: a rectangle here would stretch the art.
        this.BracketHeight = this.BracketWidth;
        this.BeamThickness = this.HalfHeight * 0.04f;
        this.BeaconSize = this.ShaftInnerWidth * 0.36f;
        this.SparkSize = this.ShaftInnerWidth * 0.22f;
        this.GuideWidth = this.ContainerWidth * 0.35f;
        this.LockWindow = this.SectionStep * 0.32f;
        this.LatchWindow = this.SectionStep * 0.5f;
        this.CameraLead = this.HalfHeight * 0.24f;
        this.BracketInset = this.WallX - this.BracketWidth * 0.42f;
        this.TideBandHeight = this.HalfHeight * 0.52f;
    }

    public float GuideWidth;
    public float WallSegmentHeight;
    public _0xfeee9a77(Camera _0x3eced720)
    {
        this._0x56eddef9(_0x3eced720);
    }

    public float BracketWidth;
    public float LockWindow;
    public float HalfHeight;
    public float ScreenWidth;
    public float BeamThickness;
    public float TideBandHeight;
}