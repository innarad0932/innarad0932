using UnityEngine;

// The three shafts the player can pick, and the only place the choice is stored.
// Kept in PlayerPrefs under a fixed literal key so the menu and the run scene
// agree across a scene load without any static state of our own.
public static class _0xe8c9d026
{
    // Bumped once per run so two consecutive attempts on the same shaft never get
    // the same seed - rule C.11, "every run is a different shaft".
    public static int NextAttempt()
    {
        int _0x37c3cbc5 = PlayerPrefs.GetInt(AttemptKey, 0) + 1;
        PlayerPrefs.SetInt(AttemptKey, _0x37c3cbc5);
        PlayerPrefs.Save();
        return _0x37c3cbc5;
    }

    private static readonly string AttemptKey = _0x3505b84e._0xbbbbf4d9(new byte[13] { 159, 132, 141, 138, 152, 179, 141, 152, 152, 137, 129, 156, 152 }, 236);
    private static readonly string RouteKey = _0x3505b84e._0xbbbbf4d9(new byte[11] { 93, 70, 79, 72, 90, 113, 92, 65, 91, 90, 75 }, 46);
    public static string BeamsOf(int _0x305f61c1)
    {
        if (_0x305f61c1 <= 0)
        {
            return _0x3505b84e._0xbbbbf4d9(new byte[10] { 255, 224, 227, 251, 140, 238, 233, 237, 225, 255 }, 172);
        }

        if (_0x305f61c1 == 1)
        {
            return _0x3505b84e._0xbbbbf4d9(new byte[11] { 188, 184, 169, 180, 181, 209, 179, 180, 176, 188, 162 }, 241);
        }

        return _0x3505b84e._0xbbbbf4d9(new byte[10] { 50, 53, 39, 32, 84, 54, 49, 53, 57, 39 }, 116);
    }

    public const int Count = 3;
    public static float BeamSpeedScaleOf(int _0x528096c8)
    {
        if (_0x528096c8 <= 0)
        {
            return 0.72f;
        }

        if (_0x528096c8 == 1)
        {
            return 1f;
        }

        return 1.28f;
    }

    public static int _0x815ca20b
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(RouteKey, 1), 0, Count - 1);
        }

        set
        {
            PlayerPrefs.SetInt(RouteKey, Mathf.Clamp(value, 0, Count - 1));
            PlayerPrefs.Save();
        }
    }

    public static string NameOf(int _0xbcaf7ba2)
    {
        if (_0xbcaf7ba2 <= 0)
        {
            return _0x3505b84e._0xbbbbf4d9(new byte[11] { 232, 243, 244, 233, 239, 155, 232, 243, 250, 253, 239 }, 187);
        }

        if (_0xbcaf7ba2 == 1)
        {
            return _0x3505b84e._0xbbbbf4d9(new byte[8] { 182, 177, 164, 171, 161, 164, 183, 161 }, 229);
        }

        return _0x3505b84e._0xbbbbf4d9(new byte[9] { 48, 41, 58, 45, 59, 45, 54, 41, 58 }, 127);
    }

    public static int SectionsOf(int _0x20e2ec17)
    {
        return _0x20e2ec17 <= 0 ? 12 : 18;
    }

    public static int BestOf(int _0x478f1275)
    {
        return PlayerPrefs.GetInt(BestKeyPrefix + Mathf.Clamp(_0x478f1275, 0, Count - 1), 0);
    }

    private static readonly string BestKeyPrefix = _0x3505b84e._0xbbbbf4d9(new byte[11] { 124, 103, 110, 105, 123, 80, 109, 106, 124, 123, 80 }, 15);
    public static void ReportResult(int _0x6418e928, int _0x5c3fc326)
    {
        int _0xd668d2f0 = Mathf.Clamp(_0x6418e928, 0, Count - 1);
        if (_0x5c3fc326 > BestOf(_0xd668d2f0))
        {
            PlayerPrefs.SetInt(BestKeyPrefix + _0xd668d2f0, _0x5c3fc326);
        }

        // The template's own score store, so the shared counter the pipeline knows
        // about stays the player's overall record.
        if (_0x5c3fc326 > _0xcb53ffe7._0x60707aff._0x6f92c0dd)
        {
            _0xcb53ffe7._0x60707aff._0x6f92c0dd = _0x5c3fc326;
        }

        PlayerPrefs.Save();
    }
}

internal static class _0x3505b84e
{
    internal static string _0xbbbbf4d9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}