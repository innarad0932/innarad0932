using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x3bdb394f : MonoBehaviour
{
    private RectTransform _0xf8dc9bc0;
    private void Awake()
    {
        if (!_0xe279eac1.Contains(this))
            _0xe279eac1.Add(this);
        this._0x7e05ec0d = this.GetComponent<Canvas>();
        this._0x73093b3c = this.GetComponent<RectTransform>();
        this._0xf8dc9bc0 = this.transform.Find(_0x0ed12ffd._0xd83a1569(new byte[8] { 180, 134, 129, 130, 166, 149, 130, 134 }, 231)) as RectTransform;
        if (!_0x4951884e)
        {
            _0x2d0b8e2e = Screen.orientation;
            _0x41e6bd89.x = Screen.width;
            _0x41e6bd89.y = Screen.height;
            _0x3fda0e49 = Screen.safeArea;
            _0x4951884e = true;
        }

        this._0x6409ca24();
    }

    private static Vector2 _0x41e6bd89 = Vector2.zero;
    private static ScreenOrientation _0x2d0b8e2e = ScreenOrientation.LandscapeLeft;
    private void Update()
    {
        if (_0xe279eac1[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x2d0b8e2e)
            OrientationChanged();
        if (Screen.safeArea != _0x3fda0e49)
            SafeAreaChanged();
        if (Screen.width != _0x41e6bd89.x || Screen.height != _0x41e6bd89.y)
            ResolutionChanged();
    }

    private Canvas _0x7e05ec0d;
    private static Rect _0x3fda0e49 = Rect.zero;
    private static void ResolutionChanged()
    {
        _0x41e6bd89.x = Screen.width;
        _0x41e6bd89.y = Screen.height;
        _0xf7b94c7e.Invoke();
    }

    private void _0x6409ca24()
    {
        if (this._0xf8dc9bc0 == null)
            return;
        Rect _0x4d86a87c = Screen.safeArea;
        Vector2 _0x1cf71098 = _0x4d86a87c.position;
        Vector2 _0x130d5d63 = _0x4d86a87c.position + _0x4d86a87c.size;
        _0x1cf71098.x /= this._0x7e05ec0d.pixelRect.width;
        _0x1cf71098.y /= this._0x7e05ec0d.pixelRect.height;
        _0x130d5d63.x /= this._0x7e05ec0d.pixelRect.width;
        _0x130d5d63.y /= this._0x7e05ec0d.pixelRect.height;
        this._0xf8dc9bc0.anchorMin = _0x1cf71098;
        this._0xf8dc9bc0.anchorMax = _0x130d5d63;
    }

    private void OnDestroy()
    {
        if (_0xe279eac1 != null && _0xe279eac1.Contains(this))
            _0xe279eac1.Remove(this);
    }

    private static readonly List<_0x3bdb394f> _0xe279eac1 = new();
    private static void OrientationChanged()
    {
        _0x2d0b8e2e = Screen.orientation;
        _0x41e6bd89.x = Screen.width;
        _0x41e6bd89.y = Screen.height;
        _0xf7b94c7e.Invoke();
    }

    private static UnityEvent _0xf7b94c7e = new();
    private static void SafeAreaChanged()
    {
        _0x3fda0e49 = Screen.safeArea;
        for (int _0x30adf65d = 0; _0x30adf65d < _0xe279eac1.Count; _0x30adf65d++)
            _0xe279eac1[_0x30adf65d]._0x6409ca24();
    }

    private static bool _0x4951884e;
    private RectTransform _0x73093b3c;
}

internal static class _0x0ed12ffd
{
    internal static string _0xd83a1569(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}