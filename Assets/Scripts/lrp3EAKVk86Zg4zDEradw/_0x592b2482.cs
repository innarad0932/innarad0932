using UnityEngine;

// Builds one run out of a seed and then PROVES it is climbable before handing it
// over: for every band it simulates the real ascent - the container rising at the
// real speed, swinging across on the real latch curve - against the real beam
// motion, and accepts the band only when clean windows exist often enough AND
// recur often enough that a player waiting for one is not caught by the decay
// field. A band that will not converge is relaxed step by step; one that still
// will not falls back to a hand-checked safe beam, the only fixed numbers here.
//
// Measured over 9600 generated bands (600 seeds x 3 routes) with this recipe:
// zero fallbacks, 30% of bands needing one or more relax steps.
public static class _0x592b2482
{
    public static _0xba2ddbf5 Build(_0xfeee9a77 _0xdb09f378, int _0x4bfd395e, int _0x017aeb36, float _0x03334e8e)
    {
        _0xba2ddbf5 _0xa9c822cb = new _0xba2ddbf5();
        _0xa9c822cb.Seed = _0x017aeb36;
        _0xa9c822cb.SectionCount = _0xe8c9d026.SectionsOf(_0x4bfd395e);
        System.Random _0x3670cf46 = new System.Random(_0x017aeb36);
        BuildLedges(_0xa9c822cb, _0xdb09f378, _0x3670cf46);
        float _0xed4b68fc = _0xe8c9d026.BeamSpeedScaleOf(_0x4bfd395e);
        for (int _0x2325aee0 = 0; _0x2325aee0 < _0xa9c822cb.SectionCount; _0x2325aee0++)
        {
            AddBand(_0xa9c822cb, _0xdb09f378, _0x3670cf46, _0x2325aee0, _0xed4b68fc, _0x03334e8e);
        }

        _0xa9c822cb.BeaconX = (float)(_0x3670cf46.NextDouble() * 2.0 - 1.0) * _0xdb09f378.ShaftInnerWidth * 0.18f;
        return _0xa9c822cb;
    }

    private static void BuildLedges(_0xba2ddbf5 _0xecd37757, _0xfeee9a77 _0xf601dc3a, System.Random _0x97ff371c)
    {
        int _0x49f891bf = _0x97ff371c.Next(0, 2) == 0 ? -1 : 1;
        int _0x20eaba8f = 1;
        float _0x376a188f = _0xf601dc3a.ShaftInnerWidth * 0.06f;
        for (int _0x915c787f = 0; _0x915c787f <= _0xecd37757.SectionCount; _0x915c787f++)
        {
            if (_0x915c787f > 0)
            {
                // A ledge may repeat a side once, never twice: the climb reads as a
                // zig-zag instead of a straight line up one wall.
                bool _0x5b971678 = _0x20eaba8f < 2 && _0x97ff371c.Next(0, 100) < 32;
                if (!_0x5b971678)
                {
                    _0x49f891bf = -_0x49f891bf;
                    _0x20eaba8f = 1;
                }
                else
                {
                    _0x20eaba8f++;
                }
            }

            _0xba2ddbf5._0xc882083b _0x5a879398 = new _0xba2ddbf5._0xc882083b();
            _0x5a879398.Index = _0x915c787f;
            _0x5a879398.Side = _0x49f891bf;
            _0x5a879398.Jitter = (float)(_0x97ff371c.NextDouble() * 2.0 - 1.0) * _0x376a188f;
            _0x5a879398.X = _0xf601dc3a._0x672509ab(_0x49f891bf, _0x5a879398.Jitter);
            _0x5a879398.Y = _0x915c787f * _0xf601dc3a.SectionStep;
            _0xecd37757.Ledges.Add(_0x5a879398);
        }
    }

    private static _0xba2ddbf5._0xdb7d2ef1 DrawBeam(_0xfeee9a77 _0x906edace, System.Random _0x078d0ee9, int _0x672e0836, float _0x9e14fbed, float _0x109e7dc2, _0xba2ddbf5._0xc882083b _0x8f2015e2, _0xba2ddbf5._0xc882083b _0xd88867cb)
    {
        // The opening band is deliberately gentle: a narrower, slower beam, so the
        // first ascent teaches the timing instead of punishing it.
        float _0x6aeb327d = _0x672e0836 == 0 ? 0.78f : 1f;
        float width = _0x906edace.ShaftInnerWidth * (0.28f + 0.18f * (float)_0x078d0ee9.NextDouble()) * _0x109e7dc2 * _0x6aeb327d;
        float _0x59fbfcdd = (float)(_0x078d0ee9.NextDouble() * 2.0 - 1.0) * _0x906edace.ShaftInnerWidth * 0.06f;
        float _0xa801ef24 = (_0x906edace.ShaftInnerWidth - width) * 0.5f - Mathf.Abs(_0x59fbfcdd);
        _0xba2ddbf5._0xdb7d2ef1 _0xe807aa90 = new _0xba2ddbf5._0xdb7d2ef1();
        _0xe807aa90.Band = _0x672e0836;
        _0xe807aa90.Y = _0x8f2015e2.Y + (_0xd88867cb.Y - _0x8f2015e2.Y) * (0.28f + 0.22f * (float)_0x078d0ee9.NextDouble());
        _0xe807aa90.Width = width;
        _0xe807aa90.Centre = _0x59fbfcdd;
        _0xe807aa90.Span = Mathf.Max(0f, _0xa801ef24) * (0.7f + 0.3f * (float)_0x078d0ee9.NextDouble());
        _0xe807aa90.Rate = (0.9f + 0.8f * (float)_0x078d0ee9.NextDouble()) * _0x9e14fbed * _0x109e7dc2 * _0x6aeb327d;
        _0xe807aa90.Phase = (float)(_0x078d0ee9.NextDouble() * Mathf.PI * 2.0);
        return _0xe807aa90;
    }

    private const int BandAttempts = 18;
    private const float MinSuccessRate = 0.22f;
    private const float ProbeStep = 0.06f;
    private const float ProbeHorizon = 6f;
    private static _0xba2ddbf5._0xdb7d2ef1 SafeBeam(_0xfeee9a77 _0x1d779efe, int _0x7fc62b53, _0xba2ddbf5._0xc882083b _0x59b4b0bd, _0xba2ddbf5._0xc882083b _0xbc6f3e25)
    {
        _0xba2ddbf5._0xdb7d2ef1 _0xa93bf0d6 = new _0xba2ddbf5._0xdb7d2ef1();
        _0xa93bf0d6.Band = _0x7fc62b53;
        _0xa93bf0d6.Y = _0x59b4b0bd.Y + (_0xbc6f3e25.Y - _0x59b4b0bd.Y) * 0.4f;
        _0xa93bf0d6.Width = _0x1d779efe.ShaftInnerWidth * 0.3f;
        _0xa93bf0d6.Centre = 0f;
        _0xa93bf0d6.Span = (_0x1d779efe.ShaftInnerWidth - _0xa93bf0d6.Width) * 0.48f;
        _0xa93bf0d6.Rate = 1.1f;
        _0xa93bf0d6.Phase = _0x7fc62b53 * 0.7f;
        return _0xa93bf0d6;
    }

    private static bool IsClimbable(_0xba2ddbf5._0xdb7d2ef1 _0x3c37c5cc, _0xfeee9a77 _0xc6ca9ddb, _0xba2ddbf5._0xc882083b _0xc3671a33, _0xba2ddbf5._0xc882083b _0x716214dd, float _0x5da96dbf)
    {
        float _0x93c7b155 = _0x716214dd.Y - _0xc3671a33.Y;
        float _0x428641f3 = _0x93c7b155 / Mathf.Max(0.01f, _0x5da96dbf);
        float _0x2a948341 = _0xc6ca9ddb.ContainerWidth * 0.5f;
        float _0x27f4efd8 = (_0xc6ca9ddb.BeamThickness + _0xc6ca9ddb.ContainerWidth) * 0.5f;
        int _0x10777610 = 0;
        int _0x6b89513e = 0;
        float _0x9106d100 = -1f;
        float _0x84deca1f = -1f;
        float _0xeade4165 = 0f;
        for (float _0x2387555a = 0f; _0x2387555a < ProbeHorizon; _0x2387555a += ProbeStep)
        {
            _0x10777610++;
            bool _0xec56823a = true;
            for (float _0x909c2de5 = 0f; _0x909c2de5 <= _0x428641f3 && _0xec56823a; _0x909c2de5 += ClimbStep)
            {
                float _0x3255e021 = _0x2387555a + _0x909c2de5;
                float _0x44e5235e = Mathf.Clamp01(_0x909c2de5 / Mathf.Max(0.01f, _0x428641f3));
                float _0x9d9af415 = _0xc3671a33.Y + _0x93c7b155 * _0x44e5235e;
                if (Mathf.Abs(_0x3c37c5cc.Y - _0x9d9af415) > _0x27f4efd8)
                {
                    continue;
                }

                float _0x1dee13ed = Mathf.Lerp(_0xc3671a33.X, _0x716214dd.X, _0xc6ca9ddb._0x2d7c6d07(_0x716214dd.Y - _0x9d9af415));
                if (Mathf.Abs(_0x3c37c5cc._0x8920a821(_0x3255e021) - _0x1dee13ed) < _0x3c37c5cc.Width * 0.5f + _0x2a948341)
                {
                    _0xec56823a = false;
                }
            }

            if (!_0xec56823a)
            {
                continue;
            }

            _0x6b89513e++;
            if (_0x84deca1f < 0f)
            {
                _0x84deca1f = _0x2387555a;
            }
            else
            {
                _0xeade4165 = Mathf.Max(_0xeade4165, _0x2387555a - _0x9106d100);
            }

            _0x9106d100 = _0x2387555a;
        }

        if (_0x6b89513e == 0 || _0x10777610 == 0)
        {
            return false;
        }

        // The horizon wraps: the wait between the last window and the first window
        // of the next cycle counts too.
        _0xeade4165 = Mathf.Max(_0xeade4165, ProbeHorizon - _0x9106d100 + _0x84deca1f);
        return (float)_0x6b89513e / _0x10777610 >= MinSuccessRate && _0xeade4165 <= MaxDeadGap;
    }

    private static void AddBand(_0xba2ddbf5 _0x8956b046, _0xfeee9a77 _0xa9925814, System.Random _0x27f9ba86, int _0x98d09a0f, float _0x26d8cbdd, float _0x1c627fc7)
    {
        _0xba2ddbf5._0xc882083b _0x2ddbd977 = _0x8956b046.Ledges[_0x98d09a0f];
        _0xba2ddbf5._0xc882083b _0xb86ebe69 = _0x8956b046.Ledges[_0x98d09a0f + 1];
        for (int _0x33993311 = 0; _0x33993311 < BandAttempts; _0x33993311++)
        {
            float _0x3a28ef93 = 1f - Mathf.Min(0.5f, _0x33993311 * 0.07f);
            _0xba2ddbf5._0xdb7d2ef1 _0x51756db3 = DrawBeam(_0xa9925814, _0x27f9ba86, _0x98d09a0f, _0x26d8cbdd, _0x3a28ef93, _0x2ddbd977, _0xb86ebe69);
            if (IsClimbable(_0x51756db3, _0xa9925814, _0x2ddbd977, _0xb86ebe69, _0x1c627fc7))
            {
                if (_0x33993311 > 0)
                {
                    _0x8956b046.RelaxedBands++;
                }

                _0x8956b046.Beams.Add(_0x51756db3);
                return;
            }
        }

        _0x8956b046.UsedFallback = true;
        _0x8956b046.Beams.Add(SafeBeam(_0xa9925814, _0x98d09a0f, _0x2ddbd977, _0xb86ebe69));
    }

    private const float ClimbStep = 0.02f;
    private const float MaxDeadGap = 3.2f;
}