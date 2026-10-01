using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x2e8fc3b7 : MonoBehaviour
{
    private Touch? _0x344862cd(Bounds _0x542cf920, TouchPhase _0x8a64c433)
    {
        if (!_0xbecc5006.Instance._0xfe7dd6e9)
            return null;
        foreach (Touch _0xda04d41e in Touch.activeTouches)
            if (_0xda04d41e.phase == _0x8a64c433)
            {
                Vector3 _0xc9d410ca = Camera.main.ScreenToWorldPoint(_0xda04d41e.screenPosition);
                Vector3 _0xfc62b341 = new(_0xc9d410ca.x, _0xc9d410ca.y, _0x542cf920.center.z);
                if (_0x542cf920.Contains(_0xfc62b341) && this._0x026cd837(_0xda04d41e))
                    return _0xda04d41e;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x568968b9(Bounds _0xba46c1aa)
    {
        if (!_0xbecc5006.Instance._0xfe7dd6e9)
            return null;
        foreach (Touch _0xcf9f4791 in Touch.activeTouches)
            if (_0xcf9f4791.ended)
            {
                Vector3 _0x75d97a15 = Camera.main.ScreenToWorldPoint(_0xcf9f4791.screenPosition);
                Vector3 _0xf891611d = new(_0x75d97a15.x, _0x75d97a15.y, _0xba46c1aa.center.z);
                if (_0xba46c1aa.Contains(_0xf891611d) && this._0x026cd837(_0xcf9f4791))
                    return _0xcf9f4791;
            }

        return null;
    }

    private Touch? _0x3111e46a()
    {
        if (!_0xbecc5006.Instance._0xfe7dd6e9)
            return null;
        foreach (Touch _0x1ee6923e in Touch.activeTouches)
            if (_0x1ee6923e.ended)
                if (this._0x026cd837(_0x1ee6923e))
                    return _0x1ee6923e;
        return null;
    }

    private Touch? _0x8f306f87(Bounds _0xc5063d67)
    {
        if (!_0xbecc5006.Instance._0xfe7dd6e9)
            return null;
        foreach (Touch _0x70ca3bba in Touch.activeTouches)
            if (!_0x70ca3bba.ended)
            {
                Vector3 _0x380e22d4 = Camera.main.ScreenToWorldPoint(_0x70ca3bba.screenPosition);
                Vector3 _0x751fd251 = new(_0x380e22d4.x, _0x380e22d4.y, _0xc5063d67.center.z);
                if (_0xc5063d67.Contains(_0x751fd251) && this._0x026cd837(_0x70ca3bba))
                    return _0x70ca3bba;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x13afe38b = this.gameObject.GetComponent<_0x2e8fc3b7>();
    }

    private void _0xb4c4572a(Touch? _0xbe595ec5)
    {
        if (!_0xbecc5006.Instance._0xfe7dd6e9)
        {
            _0xbe595ec5 = null;
            return;
        }

        int _0x2f45c11d = _0xbe595ec5.Value.touchId;
        _0xbe595ec5 = Touch.activeTouches.FirstOrDefault(_0xe9a24942 => _0xe9a24942.touchId == _0x2f45c11d);
        if (!this._0x026cd837(_0xbe595ec5.Value))
            _0xbe595ec5 = null;
    }

    private Touch? _0xdaa88101()
    {
        if (!_0xbecc5006.Instance._0xfe7dd6e9)
            return null;
        foreach (Touch _0x56e8fbf8 in Touch.activeTouches)
            if (!_0x56e8fbf8.ended)
                if (this._0x026cd837(_0x56e8fbf8))
                    return _0x56e8fbf8;
        return null;
    }

    private static _0x2e8fc3b7 _0x13afe38b;
    private bool _0x617c44ba(Touch? _0xcc4ff046, Bounds _0xe37795f3, TouchPhase _0x0598713d)
    {
        if (!_0xbecc5006.Instance._0xfe7dd6e9)
        {
            _0xcc4ff046 = null;
            return false;
        }

        if (_0xcc4ff046 != null)
            if (_0xcc4ff046.Value.phase == _0x0598713d)
            {
                Vector3 _0x54dcd9f8 = Camera.main.ScreenToWorldPoint(_0xcc4ff046.Value.screenPosition);
                Vector3 _0x70a088d0 = new(_0x54dcd9f8.x, _0x54dcd9f8.y, _0xe37795f3.center.z);
                if (_0xe37795f3.Contains(_0x70a088d0) && this._0x026cd837(_0xcc4ff046.Value))
                    return true;
            }

        return false;
    }

    private bool _0x026cd837(Touch? _0xbeaae0c3)
    {
        if (!_0xbeaae0c3.HasValue)
            return false;
        Vector3 _0xef73e3d3 = Camera.main.ScreenToWorldPoint(_0xbeaae0c3.Value.screenPosition);
        Vector3 _0xc8067a0c = _0xef73e3d3;
        _0xc8067a0c.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xc8067a0c))
            return true;
        _0xbeaae0c3 = null;
        return false;
    }
}