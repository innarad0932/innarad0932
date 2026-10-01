using TMPro;
using UnityEngine;
using UnityEngine.UI;

// One factory for every piece of runtime UI in the game, so the menu, the HUD and
// the three result cards share exactly the same plates, labels and buttons. All
// text is authored with word wrap OFF, autosize ON and a readable floor, and every
// line break is an explicit \n in the string.
public static class _0xcae6177a
{
    // A pressable face. The template's own chrome ships with every raycast target
    // switched off, so the visible fill IS the hit area and the tint target.
    public static Button Face(Image _0x8d8fc7cc, System.Action _0x81436c69)
    {
        _0x8d8fc7cc.raycastTarget = true;
        Button _0xd0e38249 = _0x8d8fc7cc.gameObject.AddComponent<Button>();
        _0xd0e38249.targetGraphic = _0x8d8fc7cc;
        ColorBlock _0xf7cb4a79 = _0xd0e38249.colors;
        _0xf7cb4a79.normalColor = Color.white;
        _0xf7cb4a79.highlightedColor = Color.white;
        _0xf7cb4a79.pressedColor = new Color(0.72f, 0.78f, 0.95f, 1f);
        _0xf7cb4a79.selectedColor = Color.white;
        _0xf7cb4a79.disabledColor = new Color(0.45f, 0.48f, 0.6f, 1f);
        _0xf7cb4a79.fadeDuration = 0.08f;
        _0xd0e38249.colors = _0xf7cb4a79;
        _0xd0e38249.onClick.AddListener(() => _0x81436c69.Invoke());
        return _0xd0e38249;
    }

    public static RectTransform Place(RectTransform _0x5150f213, Vector2 _0x8d27bf51, Vector2 _0x7f1e69a9, Vector2 _0x9c02ac62)
    {
        _0x5150f213.anchorMin = _0x8d27bf51;
        _0x5150f213.anchorMax = _0x8d27bf51;
        _0x5150f213.pivot = new Vector2(0.5f, 0.5f);
        _0x5150f213.anchoredPosition = _0x7f1e69a9;
        _0x5150f213.sizeDelta = _0x9c02ac62;
        return _0x5150f213;
    }

    public const float FontFloor = 28f;
    public static TextMeshProUGUI Label(Transform _0x6f232295, string _0x2d2b2ea5, string _0x96dab640, float _0x3cc5d540, Color _0xfdf9588a, TMP_FontAsset _0xc546e0d5, TextAlignmentOptions _0xa4914fa9)
    {
        RectTransform _0x5baffe06 = Node(_0x6f232295, _0x2d2b2ea5);
        TextMeshProUGUI _0x3c5d7a9a = _0x5baffe06.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0xc546e0d5 != null)
        {
            _0x3c5d7a9a.font = _0xc546e0d5;
        }

        _0x3c5d7a9a.text = _0x96dab640;
        _0x3c5d7a9a.color = _0xfdf9588a;
        _0x3c5d7a9a.alignment = _0xa4914fa9;
        _0x3c5d7a9a.richText = false;
        _0x3c5d7a9a.raycastTarget = false;
        _0x3c5d7a9a.enableWordWrapping = false;
        _0x3c5d7a9a.overflowMode = TextOverflowModes.Overflow;
        _0x3c5d7a9a.enableAutoSizing = true;
        _0x3c5d7a9a.fontSizeMax = _0x3cc5d540;
        _0x3c5d7a9a.fontSizeMin = Mathf.Max(FontFloor, _0x3cc5d540 * 0.62f);
        _0x3c5d7a9a.fontSize = _0x3cc5d540;
        return _0x3c5d7a9a;
    }

    // A rounded panel. The radius comes from the sliced sprite's pixels-per-unit
    // multiplier: lower is rounder.
    public static Image Plate(Transform _0x9fe5ac9c, string _0x572a99fd, Sprite _0x98f40e9a, Color _0x1cda708b, float _0x7c77fd5d)
    {
        RectTransform _0x5d0d0262 = Node(_0x9fe5ac9c, _0x572a99fd);
        Image _0x45a53135 = _0x5d0d0262.gameObject.AddComponent<Image>();
        if (_0x98f40e9a != null)
        {
            _0x45a53135.sprite = _0x98f40e9a;
            _0x45a53135.type = Image.Type.Sliced;
            _0x45a53135.pixelsPerUnitMultiplier = Mathf.Max(0.2f, _0x7c77fd5d);
        }

        _0x45a53135.color = _0x1cda708b;
        _0x45a53135.raycastTarget = false;
        return _0x45a53135;
    }

    // A transparent catcher for taps anywhere in a region. A fully transparent
    // Image is culled by the raycaster, so it keeps a sliver of alpha and opts out
    // of transparent-mesh culling.
    public static Image HitZone(Transform _0x58301478, string _0x971826a0)
    {
        RectTransform _0x059170c0 = Node(_0x58301478, _0x971826a0);
        Image _0x38ad4a28 = _0x059170c0.gameObject.AddComponent<Image>();
        _0x38ad4a28.color = new Color(1f, 1f, 1f, 0.004f);
        _0x38ad4a28.raycastTarget = true;
        if (_0x38ad4a28.canvasRenderer != null)
        {
            _0x38ad4a28.canvasRenderer.cullTransparentMesh = false;
        }

        return _0x38ad4a28;
    }

    // Content art: always aspect-preserving, so a 512x512 source never ends up
    // stretched into a 512x256 slot.
    public static Image Picture(Transform _0x0ce878ff, string _0x81e7c295, Sprite _0xea9b6449, Color _0xf60cfe10)
    {
        RectTransform _0x2b1ca616 = Node(_0x0ce878ff, _0x81e7c295);
        Image _0x8b09d90b = _0x2b1ca616.gameObject.AddComponent<Image>();
        _0x8b09d90b.sprite = _0xea9b6449;
        _0x8b09d90b.preserveAspect = true;
        _0x8b09d90b.color = _0xf60cfe10;
        _0x8b09d90b.raycastTarget = false;
        return _0x8b09d90b;
    }

    // Switch off everything a container already holds, so template chrome cannot
    // show through the screen we build in its place.
    public static void ClearBody(Transform _0x35873f23)
    {
        if (_0x35873f23 == null)
        {
            return;
        }

        for (int _0x3f4bb502 = _0x35873f23.childCount - 1; _0x3f4bb502 >= 0; _0x3f4bb502--)
        {
            Transform _0x7558a0cf = _0x35873f23.GetChild(_0x3f4bb502);
            if (_0x7558a0cf != null)
            {
                _0x7558a0cf.gameObject.SetActive(false);
            }
        }
    }

    public static RectTransform Node(Transform _0x2bbc506c, string _0x334ff2c8)
    {
        GameObject _0xe461dad5 = new GameObject(_0x334ff2c8, typeof(RectTransform));
        RectTransform _0x4146c331 = _0xe461dad5.GetComponent<RectTransform>();
        _0x4146c331.SetParent(_0x2bbc506c, false);
        _0x4146c331.localScale = Vector3.one;
        // A fresh RectTransform starts 100x100 in the middle: stretch it first so
        // children resolve their anchors against the real panel, not against 100x100.
        Stretch(_0x4146c331);
        return _0x4146c331;
    }

    public static RectTransform Stretch(RectTransform _0x8619c466)
    {
        _0x8619c466.anchorMin = Vector2.zero;
        _0x8619c466.anchorMax = Vector2.one;
        _0x8619c466.pivot = new Vector2(0.5f, 0.5f);
        _0x8619c466.anchoredPosition = Vector2.zero;
        _0x8619c466.sizeDelta = Vector2.zero;
        return _0x8619c466;
    }

    // A flat colour block. Unity draws an Image with no sprite as a solid quad, so
    // this is a real rectangle and never the dreaded "missing sprite" white slab.
    public static Image Solid(Transform _0x7a56f70b, string _0x9a87a603, Color _0xa9c6e3a6)
    {
        RectTransform _0x151cc836 = Node(_0x7a56f70b, _0x9a87a603);
        Image _0x299a48c9 = _0x151cc836.gameObject.AddComponent<Image>();
        _0x299a48c9.color = _0xa9c6e3a6;
        _0x299a48c9.raycastTarget = false;
        return _0x299a48c9;
    }
}