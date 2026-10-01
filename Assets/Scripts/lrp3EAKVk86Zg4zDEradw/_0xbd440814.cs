using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

// Drives one climb: seeds and builds the shaft, reads the hold/release gesture,
// moves the container, sweeps the beams, raises the decay field and decides the
// result. Everything it spawns comes from the generated prefabs, and every size
// it uses comes from ShaftMetrics, so the same code fits any phone aspect.
public sealed class _0xbd440814 : MonoBehaviour
{
    private void _0x91d744f8()
    {
        float _0x01a170b4 = -this._0x559516e6.SectionStep * (TideStartFactor + 2f);
        float _0x647e216e = this._0x4a914377._0x9af3b595 + this._0x559516e6.SectionStep * 3f;
        float _0x5ffd4601 = this._0x559516e6.WallSegmentHeight;
        int _0xafbb49e8 = Mathf.CeilToInt((_0x647e216e - _0x01a170b4) / _0x5ffd4601) + 1;
        for (int _0x2b0544b0 = 0; _0x2b0544b0 < _0xafbb49e8; _0x2b0544b0++)
        {
            float _0x36ebf5e1 = _0x01a170b4 + _0x2b0544b0 * _0x5ffd4601 + _0x5ffd4601 * 0.5f;
            for (int _0x4abfdbe3 = -1; _0x4abfdbe3 <= 1; _0x4abfdbe3 += 2)
            {
                GameObject _0xb211daa6 = this._0xe13dd8c4(this._wallPrefab, _0x630f4a0e._0x913761b2(new byte[4] { 140, 154, 151, 151 }, 219));
                SpriteRenderer _0x1841aa2a = _0xb211daa6.GetComponent<SpriteRenderer>();
                if (_0x1841aa2a != null)
                {
                    _0x1841aa2a.size = new Vector2(this._0x559516e6.WallThickness, _0x5ffd4601);
                    _0x1841aa2a.color = _0x1c710ab2.WallBody;
                    _0x1841aa2a.flipX = _0x4abfdbe3 > 0;
                }

                float _0xe8583dcf = _0x4abfdbe3 * (this._0x559516e6.WallX + this._0x559516e6.WallThickness * 0.5f);
                _0xb211daa6.transform.localPosition = new Vector3(_0xe8583dcf, _0x36ebf5e1, 0f);
            }
        }
    }

    private void _0x5dc1e451()
    {
        if (this._0x07309d29 == _0x3420b3fa.Finished)
        {
            return;
        }

        this._0x07309d29 = _0x3420b3fa.Finished;
        _0xe8c9d026.ReportResult(this._0x65b49526, this._0x4a914377.SectionCount);
        if (this._0x0d034f7a != null)
        {
            DOTween.Kill(this._0x0d034f7a);
            this._0x0d034f7a.DOColor(_0x1c710ab2.Gold, 0.6f);
        }

        if (this._cards == null)
        {
            return;
        }

        int _0x6c34fba3 = this._0x4a914377.SectionCount;
        float _0x953c1b5e = _0x6c34fba3 * KilometresPerSection;
        int _0x6e2482a2 = this._0xe531699b;
        DOVirtual.DelayedCall(0.7f, () => this._cards._0xf83fee12(_0x6c34fba3, _0x6c34fba3, _0x953c1b5e, _0x6e2482a2, HullMax));
    }

    private Camera _0x319ad40b;
    private SpriteRenderer _0x1db9fff8;
    private float _0xeaa587e0;
    private int _0x65b49526;
    private void _0x1a4d36e8()
    {
        if (this._hud == null || _0x3e2c0a04.Instance == null)
        {
            return;
        }

        List<_0x64710ced> _0x5ccc9ab0 = _0x3e2c0a04.Instance.Panels;
        if (_0x5ccc9ab0 == null || _0x5ccc9ab0.Count <= _0xcb53ffe7._0x51899f64.DEFAULT)
        {
            return;
        }

        _0x64710ced _0xdc4a651f = _0x5ccc9ab0[_0xcb53ffe7._0x51899f64.DEFAULT];
        if (_0xdc4a651f == null || _0xdc4a651f.Content == null)
        {
            return;
        }

        this._hud.Build(_0xdc4a651f.Content.transform, HullMax, this._0x65b49526, () => this._0xc23da986(), () => this._0x53d67f0b());
        this._hud._0x67f7be2f(0, this._0x4a914377.SectionCount);
        this._hud._0x2c9f6ade(0f);
        this._hud._0x9512bc4c(this._0xe531699b);
        if (this._hud._0x1641ab7f != null)
        {
            this._hud._0x1641ab7f._0x4fdd0313(() => this._0x36bff9e9(), () => this._0xf2972f3e());
        }
    }

    [SerializeField]
    private _0x1f02b3e6 _rig;
    private _0x3420b3fa _0x07309d29 = _0x3420b3fa.Idle;
    private void _0xc23da986()
    {
        _0xbecc5006.Instance.LoadSceneByIndex(_0xcb53ffe7._0xd8635e47.SCENE_0);
    }

    private void _0x9e9d54cd()
    {
        this._0xe531699b--;
        if (this._hud != null)
        {
            this._hud._0x9512bc4c(this._0xe531699b);
        }

        if (this._0x5c419fdc != null)
        {
            this._0x5c419fdc._0x9600e711(_0x1c710ab2.Danger);
        }

        if (this._rig != null)
        {
            this._rig._0x0717c22b(this._0x559516e6.HalfHeight * 0.02f);
        }

        this._0x4b112f83(this._0x51c5da37, this._0x69811d06, _0x1c710ab2.Danger);
        if (this._0xe531699b <= 0)
        {
            this._0x1fcce5aa(true);
            return;
        }

        this._0x097c1b52();
    }

    private const float BoostSeconds = 0.55f;
    private void _0xe352ba72(float _0x3ef63191, float _0xc4c8b603)
    {
        this._0xeaa587e0 += _0x3ef63191 / Mathf.Max(0.01f, _0xc4c8b603);
        float _0x45ee35ab = Mathf.Clamp01(this._0xeaa587e0);
        float _0x0d738a2d = 1f - (1f - _0x45ee35ab) * (1f - _0x45ee35ab);
        this._0x69811d06 = Mathf.Lerp(this._0xf11728da, this._0xff7e7e4f, _0x0d738a2d);
        this._0x51c5da37 = Mathf.Lerp(this._0x700173a9, this._0x514c5221, _0x0d738a2d);
        if (this._0x5c419fdc != null)
        {
            this._0x5c419fdc.SetTilt(this._0x07309d29 == _0x3420b3fa.Sliding ? Mathf.Sin(_0x45ee35ab * Mathf.PI) * 6f : 0f);
        }

        if (_0x45ee35ab >= 1f)
        {
            this._0x38f03236(this._0x4ca70955);
        }
    }

    private SpriteRenderer _0x0d034f7a;
    [SerializeField]
    private GameObject _bracketPrefab;
    private void Update()
    {
        if (this._0x4a914377 == null)
        {
            return;
        }

        if (this._0x07309d29 == _0x3420b3fa.Paused)
        {
            return;
        }

        float dt = Time.deltaTime;
        this._0x39de7005 += dt;
        this._0x721d120f();
        this._0x3ef17ce5(dt);
        this._0x8e3b6861(dt);
        this._0x95348715();
        switch (this._0x07309d29)
        {
            case _0x3420b3fa.Charging:
                if (this._0x39de7005 - this._0xd420e046 >= HoldThreshold)
                {
                    this._0x07309d29 = _0x3420b3fa.Rising;
                    if (this._0x1db9fff8 != null)
                    {
                        this._0x1db9fff8.enabled = true;
                    }
                }

                break;
            case _0x3420b3fa.Rising:
                this._0x98abe334(dt);
                break;
            case _0x3420b3fa.Boosting:
                this._0xe352ba72(dt, BoostSeconds);
                break;
            case _0x3420b3fa.Sliding:
                this._0xe352ba72(dt, SlideSeconds);
                break;
        }

        this._0xd482217d();
        this._0x04230de1();
        if (this._rig != null)
        {
            this._rig._0xbb8de802(this._0x69811d06 + this._0x559516e6.CameraLead);
        }
    }

    [SerializeField]
    private GameObject _guidePrefab;
    private void Start()
    {
        this._0x319ad40b = Camera.main;
        this._0x559516e6 = new _0xfeee9a77(this._0x319ad40b);
        this._0x65b49526 = _0xe8c9d026._0x815ca20b;
        this._0xd6cc8038 = this._0x559516e6.SectionStep * RiseFactor;
        int _0x88dc9c7c = _0xe8c9d026.NextAttempt();
        int _0x38bb2878 = (this._0x65b49526 * 7919) ^ (_0x88dc9c7c * 104729);
        this._0x4a914377 = _0x592b2482.Build(this._0x559516e6, this._0x65b49526, _0x38bb2878, this._0xd6cc8038);
        {
#if B_LOGS
            {
                Debug.Log(_0x630f4a0e._0x913761b2(new byte[13] { 2, 42, 49, 56, 63, 45, 4, 121, 42, 60, 60, 61, 100 }, 89) + _0x38bb2878 + _0x630f4a0e._0x913761b2(new byte[7] { 56, 106, 119, 109, 108, 125, 37 }, 24) + this._0x65b49526 + _0x630f4a0e._0x913761b2(new byte[10] { 247, 164, 178, 180, 163, 190, 184, 185, 164, 234 }, 215) + this._0x4a914377.SectionCount + _0x630f4a0e._0x913761b2(new byte[9] { 26, 72, 95, 86, 91, 66, 95, 94, 7 }, 58) + this._0x4a914377.RelaxedBands + _0x630f4a0e._0x913761b2(new byte[10] { 230, 160, 167, 170, 170, 164, 167, 165, 173, 251 }, 198) + this._0x4a914377.UsedFallback);
            }
#endif
        }

        this._0x38a7e5c8();
        this._0x1a4d36e8();
        if (this._tutorial != null)
        {
            this._tutorial._0x9e5dfd12();
        }

        if (this._splash != null)
        {
            this._splash._0xd3f77e7a();
        }
    }

    private void _0x04230de1()
    {
        int _0x8ddc54b7 = -1;
        if (this._0x07309d29 == _0x3420b3fa.Rising)
        {
            for (int _0xc31951fa = 0; _0xc31951fa < this._0x4a914377.Ledges.Count; _0xc31951fa++)
            {
                if (Mathf.Abs(this._0x4a914377.Ledges[_0xc31951fa].Y - this._0x69811d06) <= this._0x559516e6.LockWindow)
                {
                    _0x8ddc54b7 = _0xc31951fa;
                    break;
                }
            }
        }

        if (_0x8ddc54b7 == this._0x61edf125)
        {
            return;
        }

        if (this._0x61edf125 >= 0 && this._0x61edf125 < this._0x44bb3361.Count && this._0x44bb3361[this._0x61edf125] != null)
        {
            this._0x44bb3361[this._0x61edf125]._0x70ad1924(false);
        }

        this._0x61edf125 = _0x8ddc54b7;
        if (_0x8ddc54b7 >= 0 && _0x8ddc54b7 < this._0x44bb3361.Count && this._0x44bb3361[_0x8ddc54b7] != null)
        {
            this._0x44bb3361[_0x8ddc54b7]._0x70ad1924(true);
        }
    }

    private int _0x4ca70955;
    private SpriteRenderer _0x3cfb99bf;
    [SerializeField]
    private _0x6e6232e8 _splash;
    private void _0x84da39c7()
    {
        if (this._0x1db9fff8 != null)
        {
            this._0x1db9fff8.enabled = false;
        }

        for (int _0x9f455303 = 0; _0x9f455303 < this._0x4a914377.Ledges.Count; _0x9f455303++)
        {
            if (Mathf.Abs(this._0x4a914377.Ledges[_0x9f455303].Y - this._0x69811d06) <= this._0x559516e6.LockWindow)
            {
                this._0x38f03236(_0x9f455303);
                return;
            }
        }

        this._0x097c1b52();
    }

    private float _0x69811d06;
    private float _0xf11728da;
    [SerializeField]
    private GameObject _beamPrefab;
    [SerializeField]
    private _0xc5edfab0 _cards;
    private float _0x700173a9;
    // While rising the container slides from the ledge it left toward the ledge it
    // is heading for, so the climb reads as a zig-zag and the beams have something
    // to catch.
    private void _0xd482217d()
    {
        if (this._0x07309d29 == _0x3420b3fa.Rising)
        {
            int _0xf5b646d7 = Mathf.Clamp(Mathf.FloorToInt(this._0x69811d06 / this._0x559516e6.SectionStep), 0, this._0x4a914377.SectionCount);
            int _0xdc1aadaf = Mathf.Min(_0xf5b646d7 + 1, this._0x4a914377.SectionCount);
            float _0x644e9788 = this._0x559516e6._0x2d7c6d07(this._0x4a914377.Ledges[_0xdc1aadaf].Y - this._0x69811d06);
            this._0x51c5da37 = Mathf.Lerp(this._0x4a914377.Ledges[_0xf5b646d7].X, this._0x4a914377.Ledges[_0xdc1aadaf].X, _0x644e9788);
        }

        if (this._0x5c419fdc != null)
        {
            this._0x5c419fdc._0xb474f1bb(this._0x51c5da37, this._0x69811d06);
        }

        if (this._0x1db9fff8 != null && this._0x1db9fff8.enabled)
        {
            this._0x1db9fff8.transform.localPosition = new Vector3(this._0x51c5da37, this._0x69811d06 - this._0x559516e6.SectionStep * 0.5f - this._0x559516e6.ContainerWidth * 0.5f, 0f);
        }
    }

    [SerializeField]
    private _0xc7032d7b _hud;
    private const float BoostCooldown = 0.35f;
    private void _0x3ef17ce5(float _0x2dcf533c)
    {
        if (this._0x07309d29 == _0x3420b3fa.Finished)
        {
            return;
        }

        float _0xb5f13796 = TideBaseSpeed + TideGain * this._0xe60cf232;
        this._0x7f27d602 += _0xb5f13796 * _0x2dcf533c;
        if (this._0xcb69d533 != null)
        {
            this._0xcb69d533._0x136d9c94(_0xb5f13796 * _0x2dcf533c);
            this._0xcb69d533._0xe8c3670b(this._0x39de7005);
        }

        float _0x5dbe8a48 = this._0x69811d06 - (this._0x5c419fdc != null ? this._0x5c419fdc._0x84791234 : 0f);
        if (this._0x7f27d602 >= _0x5dbe8a48)
        {
            this._0x1fcce5aa(false);
        }
    }

    private void _0x53d67f0b()
    {
        if (this._0x07309d29 == _0x3420b3fa.Finished || this._0x07309d29 == _0x3420b3fa.Paused)
        {
            return;
        }

        if (this._0x07309d29 == _0x3420b3fa.Charging || this._0x07309d29 == _0x3420b3fa.Rising)
        {
            this._0x84da39c7();
        }

        if (this._cards == null)
        {
            return;
        }

        this._0x0f901720 = _0x3420b3fa.Idle;
        this._0x07309d29 = _0x3420b3fa.Paused;
        this._cards._0x93815cd3(this._0xe60cf232, this._0x4a914377.SectionCount, this._0xe531699b, HullMax, () => this._0xf56abe72());
    }

    [SerializeField]
    private _0x25a19073 _tutorial;
    private void _0x332a0862(int _0xb0ff69d6, _0x3420b3fa _0x86796f81)
    {
        this._0x4ca70955 = Mathf.Clamp(_0xb0ff69d6, 0, this._0x4a914377.SectionCount);
        this._0xf11728da = this._0x69811d06;
        this._0x700173a9 = this._0x51c5da37;
        this._0xff7e7e4f = this._0x4a914377.Ledges[this._0x4ca70955].Y;
        this._0x514c5221 = this._0x4a914377.Ledges[this._0x4ca70955].X;
        this._0xeaa587e0 = 0f;
        this._0x07309d29 = _0x86796f81;
    }

    // A short tap is a metered burst: exactly one section, no beam contact, and a
    // cooldown afterwards, so it is the safe-but-slow way up next to the fast and
    // risky hold.
    private void _0x8602fa31()
    {
        if (this._0xe60cf232 >= this._0x4a914377.SectionCount)
        {
            this._0x07309d29 = _0x3420b3fa.Idle;
            return;
        }

        int _0xb2a5d3b5 = this._0xe60cf232 + 1;
        this._0x332a0862(_0xb2a5d3b5, _0x3420b3fa.Boosting);
    }

    private float _0xd6cc8038;
    private void _0x4b112f83(float _0x72a700ee, float _0x43ca21de, Color _0x88102fb4)
    {
        if (this._0x3cfb99bf == null)
        {
            return;
        }

        this._0x3cfb99bf.transform.localPosition = new Vector3(_0x72a700ee, _0x43ca21de, 0f);
        this._0x3cfb99bf.color = _0x88102fb4;
        this._0x2c419a34 = 0.28f;
    }

    private float _0xd420e046;
    private void _0x097c1b52()
    {
        int _0xc3e78256 = 0;
        for (int _0x0d98a348 = this._0x4a914377.Ledges.Count - 1; _0x0d98a348 >= 0; _0x0d98a348--)
        {
            if (this._0x4a914377.Ledges[_0x0d98a348].Y < this._0x69811d06 - 0.01f)
            {
                _0xc3e78256 = _0x0d98a348;
                break;
            }
        }

        this._0x332a0862(_0xc3e78256, _0x3420b3fa.Sliding);
    }

    private _0x9d98541b _0xcb69d533;
    private float _0x51c5da37;
    private const float HintHoldSeconds = 12f;
    private const float KilometresPerSection = 1.05f;
    private _0xe07d0143 _0x5c419fdc;
    private float _0x7f27d602;
    private bool _0x326874f2()
    {
        if (this._0x5c419fdc == null)
        {
            return false;
        }

        for (int _0x6efae419 = 0; _0x6efae419 < this._0xe8075fa7.Count; _0x6efae419++)
        {
            _0xa5534722 _0x99c5974b = this._0xe8075fa7[_0x6efae419];
            if (_0x99c5974b == null)
            {
                continue;
            }

            if (_0x99c5974b._0x6346b29e(this._0x51c5da37, this._0x69811d06, this._0x5c419fdc._0x7e184c74, this._0x5c419fdc._0x84791234))
            {
                return true;
            }
        }

        return false;
    }

    private int _0x61edf125 = -1;
    private void _0x38a7e5c8()
    {
        _0xba2ddbf5._0xc882083b _0x641a6c86 = this._0x4a914377.Ledges[0];
        this._0x51c5da37 = _0x641a6c86.X;
        this._0x69811d06 = _0x641a6c86.Y;
        this._0x91d744f8();
        this._0xb3038831();
        this._0xde3e0073();
        this._0x5c419fdc = this._0xe13dd8c4(this._containerPrefab, _0x630f4a0e._0x913761b2(new byte[9] { 194, 206, 207, 213, 192, 200, 207, 196, 211 }, 129)).GetComponent<_0xe07d0143>();
        if (this._0x5c419fdc != null)
        {
            this._0x5c419fdc._0x681a3e6e(this._0x559516e6.ContainerWidth, _0x1c710ab2.AccentGlow);
            this._0x5c419fdc._0xb474f1bb(this._0x51c5da37, this._0x69811d06);
        }

        this._0x1db9fff8 = this._0xe13dd8c4(this._guidePrefab, _0x630f4a0e._0x913761b2(new byte[5] { 139, 153, 133, 136, 137 }, 204)).GetComponent<SpriteRenderer>();
        if (this._0x1db9fff8 != null)
        {
            this._0x1db9fff8.size = new Vector2(this._0x559516e6.GuideWidth, this._0x559516e6.SectionStep);
            this._0x1db9fff8.color = _0x1c710ab2.Fade(_0x1c710ab2.Accent, 0.5f);
            this._0x1db9fff8.enabled = false;
        }

        this._0x3cfb99bf = this._0xe13dd8c4(this._sparkPrefab, _0x630f4a0e._0x913761b2(new byte[5] { 88, 91, 74, 89, 64 }, 11)).GetComponent<SpriteRenderer>();
        if (this._0x3cfb99bf != null)
        {
            this._0x3cfb99bf.size = new Vector2(this._0x559516e6.SparkSize, this._0x559516e6.SparkSize);
            this._0x3cfb99bf.color = _0x1c710ab2.Fade(_0x1c710ab2.Gold, 0f);
        }

        this._0x0d034f7a = this._0xe13dd8c4(this._beaconPrefab, _0x630f4a0e._0x913761b2(new byte[6] { 181, 178, 182, 180, 184, 185 }, 247)).GetComponent<SpriteRenderer>();
        if (this._0x0d034f7a != null)
        {
            this._0x0d034f7a.size = new Vector2(this._0x559516e6.BeaconSize, this._0x559516e6.BeaconSize);
            this._0x0d034f7a.color = _0x1c710ab2.TextMuted;
            this._0x0d034f7a.transform.localPosition = new Vector3(this._0x4a914377.BeaconX, this._0x4a914377._0x9af3b595 + this._0x559516e6.SectionStep * 0.95f, 0f);
        }

        this._0x7f27d602 = _0x641a6c86.Y - this._0x559516e6.SectionStep * TideStartFactor;
        this._0xcb69d533 = this._0xe13dd8c4(this._tidePrefab, _0x630f4a0e._0x913761b2(new byte[11] { 237, 236, 234, 232, 240, 246, 239, 224, 236, 229, 237 }, 169)).GetComponent<_0x9d98541b>();
        if (this._0xcb69d533 != null)
        {
            this._0xcb69d533._0xd823a0d0(this._0x559516e6.ScreenWidth * 1.04f, this._0x559516e6.TideBandHeight, this._0x7f27d602, _0x1c710ab2.Fade(_0x1c710ab2.Accent2, 0.92f), _0x1c710ab2.Fade(_0x1c710ab2.Danger, 0.34f));
        }

        if (this._rig != null)
        {
            this._rig._0x900dd677(this._0x69811d06 + this._0x559516e6.CameraLead);
        }
    }

    [SerializeField]
    private GameObject _tidePrefab;
    private void _0xf56abe72()
    {
        if (this._0x07309d29 != _0x3420b3fa.Paused)
        {
            return;
        }

        this._0x07309d29 = this._0x0f901720;
        this._0xf7e967e0 = this._0x39de7005 + 0.3f;
    }

    private int _0xe60cf232;
    private void _0x721d120f()
    {
        for (int _0x92715efc = 0; _0x92715efc < this._0xe8075fa7.Count; _0x92715efc++)
        {
            if (this._0xe8075fa7[_0x92715efc] != null)
            {
                this._0xe8075fa7[_0x92715efc]._0x5732d7e1(this._0x39de7005);
            }
        }
    }

    private GameObject _0xe13dd8c4(GameObject _0x8a18db6a, string _0xcc12370d)
    {
        GameObject _0xe43331e9 = Instantiate(_0x8a18db6a, this.transform, false);
        _0xe43331e9.name = _0xcc12370d;
        return _0xe43331e9;
    }

    private void _0xf2972f3e()
    {
        if (this._0x07309d29 == _0x3420b3fa.Charging)
        {
            this._0x8602fa31();
            return;
        }

        if (this._0x07309d29 == _0x3420b3fa.Rising)
        {
            this._0x84da39c7();
        }
    }

    [SerializeField]
    private GameObject _sparkPrefab;
    private void _0xde3e0073()
    {
        for (int _0x6cbc45df = 0; _0x6cbc45df < this._0x4a914377.Beams.Count; _0x6cbc45df++)
        {
            _0xba2ddbf5._0xdb7d2ef1 _0xc5b76ea1 = this._0x4a914377.Beams[_0x6cbc45df];
            GameObject _0x676ae180 = this._0xe13dd8c4(this._beamPrefab, _0x630f4a0e._0x913761b2(new byte[5] { 127, 120, 124, 112, 98 }, 61) + _0x6cbc45df);
            _0xa5534722 _0x2bc7cedb = _0x676ae180.GetComponent<_0xa5534722>();
            if (_0x2bc7cedb != null)
            {
                _0x2bc7cedb._0xd5ffd075(_0xc5b76ea1, this._0x559516e6.BeamThickness, _0x1c710ab2.Danger);
                this._0xe8075fa7.Add(_0x2bc7cedb);
            }
        }
    }

    private const float RiseFactor = 1.38f;
    private enum _0x3420b3fa
    {
        Idle,
        Charging,
        Rising,
        Boosting,
        Sliding,
        Paused,
        Finished,
    }

    private float _0xf7e967e0;
    private float _0x2c419a34;
    private void _0x95348715()
    {
        if (this._hud == null)
        {
            return;
        }

        float _0x4006cc1f = this._0x39de7005 <= HintHoldSeconds ? 1f : Mathf.Lerp(1f, 0.45f, Mathf.Clamp01((this._0x39de7005 - HintHoldSeconds) / 0.6f));
        this._hud._0xfa55a1cf(_0x4006cc1f);
    }

    private float _0xff7e7e4f;
    private const float SlideSeconds = 0.35f;
    private void _0x1fcce5aa(bool _0x75df7476)
    {
        if (this._0x07309d29 == _0x3420b3fa.Finished)
        {
            return;
        }

        this._0x07309d29 = _0x3420b3fa.Finished;
        _0xe8c9d026.ReportResult(this._0x65b49526, this._0xe60cf232);
        if (this._0x5c419fdc != null)
        {
            this._0x5c419fdc._0x9600e711(_0x1c710ab2.Danger);
        }

        this._0x4b112f83(this._0x51c5da37, this._0x69811d06, _0x1c710ab2.Danger);
        if (this._cards == null)
        {
            return;
        }

        int _0x880659c3 = this._0xe60cf232;
        int _0x295abb2e = this._0x4a914377.SectionCount;
        int _0xcac998fd = _0xe8c9d026.BestOf(this._0x65b49526);
        DOVirtual.DelayedCall(0.6f, () => this._cards._0x2596b9ca(_0x75df7476, _0x880659c3, _0x295abb2e, _0xcac998fd));
    }

    private readonly List<_0x60b7383e> _0x44bb3361 = new List<_0x60b7383e>();
    private void _0x38f03236(int _0xd82734cd)
    {
        if (this._0x1db9fff8 != null)
        {
            this._0x1db9fff8.enabled = false;
        }

        int _0x7561c090 = this._0xe60cf232;
        this._0xe60cf232 = Mathf.Clamp(_0xd82734cd, 0, this._0x4a914377.SectionCount);
        this._0x69811d06 = this._0x4a914377.Ledges[this._0xe60cf232].Y;
        this._0x51c5da37 = this._0x4a914377.Ledges[this._0xe60cf232].X;
        this._0x07309d29 = _0x3420b3fa.Idle;
        this._0xf7e967e0 = this._0x39de7005 + BoostCooldown;
        this._0xeaa587e0 = 0f;
        if (_0x7561c090 >= 0 && _0x7561c090 < this._0x44bb3361.Count && this._0x44bb3361[_0x7561c090] != null)
        {
            this._0x44bb3361[_0x7561c090]._0x182e6d1d(false);
        }

        if (this._0xe60cf232 < this._0x44bb3361.Count && this._0x44bb3361[this._0xe60cf232] != null)
        {
            this._0x44bb3361[this._0xe60cf232]._0x182e6d1d(true);
        }

        if (this._0x5c419fdc != null)
        {
            this._0x5c419fdc.SetTilt(0f);
            this._0x5c419fdc._0xa13613b3();
        }

        this._0x4b112f83(this._0x51c5da37, this._0x69811d06, _0x1c710ab2.Gold);
        if (this._hud != null)
        {
            this._hud._0x67f7be2f(this._0xe60cf232, this._0x4a914377.SectionCount);
            this._hud._0x2c9f6ade(this._0xe60cf232 * KilometresPerSection);
        }

        if (this._0xe60cf232 >= this._0x4a914377.SectionCount)
        {
            this._0x5dc1e451();
        }
    }

    private int _0xe531699b = HullMax;
    private void _0x8e3b6861(float _0x496e4441)
    {
        if (this._0x3cfb99bf == null || this._0x2c419a34 <= 0f)
        {
            return;
        }

        this._0x2c419a34 = Mathf.Max(0f, this._0x2c419a34 - _0x496e4441);
        float _0xcc806388 = this._0x2c419a34 / 0.28f;
        Color _0xee0d3f3b = this._0x3cfb99bf.color;
        _0xee0d3f3b.a = _0xcc806388;
        this._0x3cfb99bf.color = _0xee0d3f3b;
        float _0xb897ed75 = this._0x559516e6.SparkSize * (1.35f - 0.45f * _0xcc806388);
        this._0x3cfb99bf.size = new Vector2(_0xb897ed75, _0xb897ed75);
    }

    private _0xba2ddbf5 _0x4a914377;
    [SerializeField]
    private GameObject _wallPrefab;
    private void _0x36bff9e9()
    {
        if (this._0x07309d29 != _0x3420b3fa.Idle || this._0x39de7005 < this._0xf7e967e0)
        {
            return;
        }

        this._0x07309d29 = _0x3420b3fa.Charging;
        this._0xd420e046 = this._0x39de7005;
    }

    private _0xfeee9a77 _0x559516e6;
    private const float TideGain = 0.0045f;
    private const float TideBaseSpeed = 0.045f;
    private _0x3420b3fa _0x0f901720 = _0x3420b3fa.Idle;
    private void _0xb3038831()
    {
        for (int _0x774cc3c2 = 0; _0x774cc3c2 < this._0x4a914377.Ledges.Count; _0x774cc3c2++)
        {
            _0xba2ddbf5._0xc882083b _0x6040a604 = this._0x4a914377.Ledges[_0x774cc3c2];
            GameObject _0x1ab00fa6 = this._0xe13dd8c4(this._bracketPrefab, _0x630f4a0e._0x913761b2(new byte[6] { 75, 66, 67, 64, 66, 88 }, 7) + _0x774cc3c2);
            // The ledge art hangs off the wall and sits slightly below the clamp
            // line, so the container reads as resting ON it rather than inside it.
            _0x1ab00fa6.transform.localPosition = new Vector3(_0x6040a604.Side * this._0x559516e6.WallX + _0x6040a604.Jitter, _0x6040a604.Y - this._0x559516e6.BracketHeight * 0.3f, 0f);
            _0x60b7383e _0xfc044083 = _0x1ab00fa6.GetComponent<_0x60b7383e>();
            if (_0xfc044083 != null)
            {
                _0xfc044083._0x0f78b31d(this._0x559516e6.BracketWidth, this._0x559516e6.BracketHeight, _0x6040a604.Side, _0x1c710ab2.Fade(_0x1c710ab2.Accent, 0.62f), _0x1c710ab2.Gold, _0x1c710ab2.AccentGlow);
            }

            this._0x44bb3361.Add(_0xfc044083);
        }

        if (this._0x44bb3361.Count > 0 && this._0x44bb3361[0] != null)
        {
            this._0x44bb3361[0]._0x182e6d1d(true);
        }
    }

    [SerializeField]
    private GameObject _containerPrefab;
    private const int HullMax = 3;
    [SerializeField]
    private GameObject _beaconPrefab;
    private float _0x514c5221;
    private void _0x98abe334(float _0xd55efb4f)
    {
        this._0x69811d06 += this._0xd6cc8038 * _0xd55efb4f;
        float _0x94097725 = this._0x4a914377._0x9af3b595;
        if (this._0x69811d06 >= _0x94097725)
        {
            this._0x69811d06 = _0x94097725;
            this._0x38f03236(this._0x4a914377.SectionCount);
            return;
        }

        if (this._0x326874f2())
        {
            this._0x9e9d54cd();
        }
    }

    private readonly List<_0xa5534722> _0xe8075fa7 = new List<_0xa5534722>();
    // Far enough below the start that a player who never touches the screen has
    // 69s before the field reaches them, close enough that its crest is on screen
    // from the first frame - it is the only thing pressing the player upward.
    private const float TideStartFactor = 2.8f;
    private const float HoldThreshold = 0.18f;
    private float _0x39de7005;
}

internal static class _0x630f4a0e
{
    internal static string _0x913761b2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}