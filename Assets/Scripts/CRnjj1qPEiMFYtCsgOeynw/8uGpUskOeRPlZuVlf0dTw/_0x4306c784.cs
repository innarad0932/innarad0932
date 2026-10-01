using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x4306c784 : MonoBehaviour
{
    private static UnityEvent _0x7bfe69f2 = new();
    private void Start()
    {
    }

    private static void SafeAreaChanged()
    {
        _0xb88178f2 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private CanvasScaler _0x0d61ad0c;
    private static readonly List<_0x4306c784> _0xba31f74e = new();
    private void _0xdb30378f()
    {
        if (this._0xe5453c66 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x1ae8ae54 = Screen.safeArea;
        Vector2 _0x45a34f96 = _0x1ae8ae54.position;
        Vector2 _0x1426dc50 = _0x1ae8ae54.position + _0x1ae8ae54.size;
        _0x45a34f96.x /= screenWidth;
        _0x45a34f96.y /= screenHeight;
        _0x1426dc50.x /= screenWidth;
        _0x1426dc50.y /= screenHeight;
        this._0xe5453c66.anchorMin = _0x45a34f96;
        this._0xe5453c66.anchorMax = _0x1426dc50;
        this._0xe5453c66.offsetMin = Vector2.zero;
        this._0xe5453c66.offsetMax = Vector2.zero;
        if (this._0x0d61ad0c == null)
            return;
        Vector2 _0x3bd73d74 = _0x1426dc50 - _0x45a34f96;
        float _0xd8933af1 = 2f - _0x3bd73d74.x;
        float _0x7877ef4b = 2f - _0x3bd73d74.y;
        this._0x0d61ad0c.referenceResolution = this._0x7c4b0921 * new Vector2(_0xd8933af1, _0x7877ef4b);
    }

    private static bool _0x30d47791;
    private static ScreenOrientation _0xb572346d = ScreenOrientation.LandscapeLeft;
    private static void OrientationChanged()
    {
        _0xb572346d = Screen.orientation;
        _0x5c4281a5.x = Screen.width;
        _0x5c4281a5.y = Screen.height;
        _0xb88178f2 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x7bfe69f2.Invoke();
    }

    private static Rect _0xb88178f2 = Rect.zero;
    private void Update()
    {
        if (_0xba31f74e.Count == 0 || _0xba31f74e[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xb572346d)
            OrientationChanged();
        if (Screen.safeArea != _0xb88178f2)
            SafeAreaChanged();
        if (Screen.width != _0x5c4281a5.x || Screen.height != _0x5c4281a5.y)
            ResolutionChanged();
    }

    private RectTransform _0x0226e1cd;
    private void OnDestroy()
    {
        if (_0xba31f74e != null && _0xba31f74e.Contains(this))
            _0xba31f74e.Remove(this);
    }

    private Canvas _0x87bbc42c;
    private static void ResolutionChanged()
    {
        _0x5c4281a5.x = Screen.width;
        _0x5c4281a5.y = Screen.height;
        _0xb88178f2 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x7bfe69f2.Invoke();
    }

    private RectTransform _0xe5453c66;
    private static Vector2 _0x5c4281a5 = Vector2.zero;
    private Vector2 _0x7c4b0921;
    private void Awake()
    {
        if (!_0xba31f74e.Contains(this))
            _0xba31f74e.Add(this);
        this._0x87bbc42c = this.GetComponent<Canvas>();
        this._0x0d61ad0c = this.GetComponent<CanvasScaler>();
        if (this._0x0d61ad0c != null)
            this._0x7c4b0921 = this._0x0d61ad0c.referenceResolution;
        this._0x0226e1cd = this.GetComponent<RectTransform>();
        this._0xe5453c66 = this.transform.Find(_0xa8d79ff2._0x20b544d3(new byte[8] { 247, 197, 194, 193, 229, 214, 193, 197 }, 164)) as RectTransform;
        if (!_0x30d47791)
        {
            _0xb572346d = Screen.orientation;
            _0x5c4281a5.x = Screen.width;
            _0x5c4281a5.y = Screen.height;
            _0xb88178f2 = Screen.safeArea;
            _0x30d47791 = true;
        }

        this._0xdb30378f();
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0xf1eeaa0d = 0; _0xf1eeaa0d < _0xba31f74e.Count; _0xf1eeaa0d++)
            _0xba31f74e[_0xf1eeaa0d]._0xdb30378f();
    }
}

internal static class _0xa8d79ff2
{
    internal static string _0x20b544d3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}