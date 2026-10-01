using UnityEngine;

// Single source of colour for the whole game. Preset CYBERPUNK with the ticket
// accents substituted; every screen, pop and sprite tint reads from here so the
// menu, the shaft and the result cards cannot drift apart.
public static class _0x1c710ab2
{
    public static readonly Color SurfaceHi = new Color(0.0784f, 0.1098f, 0.2275f, 1f);
    public static readonly Color Accent = new Color(0.1765f, 0.4863f, 1f, 1f);
    public static readonly Color TextMuted = new Color(0.5529f, 0.6353f, 0.8392f, 1f);
    public static readonly Color WallBody = new Color(0.0941f, 0.1294f, 0.2588f, 1f);
    public static readonly Color BgDeep = new Color(0.0627f, 0.0863f, 0.1725f, 1f);
    public static readonly Color OutlineDark = new Color(0.0392f, 0.0627f, 0.1412f, 1f);
    public static readonly Color TextPrimary = new Color(0.9608f, 0.9686f, 1f, 1f);
    public static readonly Color BgDeeper = new Color(0.0392f, 0.0549f, 0.1176f, 1f);
    public static readonly Color TrackDark = new Color(0.102f, 0.1412f, 0.3137f, 1f);
    // Same hue, different opacity. Kept as a helper so translucent variants stay
    // tied to the palette instead of becoming a second set of literals.
    public static Color Fade(Color _0x6fcbc8f3, float _0x7dda4f29)
    {
        _0x6fcbc8f3.a = _0x7dda4f29;
        return _0x6fcbc8f3;
    }

    // Accent of the route the player picked, so the three shafts read apart at a
    // glance on the menu cards and in the HUD.
    public static Color RouteAccent(int _0xff1e586d)
    {
        if (_0xff1e586d <= 0)
        {
            return Accent;
        }

        if (_0xff1e586d == 1)
        {
            return Accent2;
        }

        return Danger;
    }

    public static readonly Color Surface = new Color(0.0941f, 0.1294f, 0.2588f, 1f);
    public static readonly Color Danger = new Color(0.9412f, 0.2941f, 0.3882f, 1f);
    public static readonly Color AccentGlow = new Color(0.4353f, 0.6902f, 1f, 1f);
    public static readonly Color Gold = new Color(0.949f, 0.7686f, 0.3098f, 1f);
    public static readonly Color Accent2 = new Color(0.5451f, 0.2706f, 0.8275f, 1f);
}