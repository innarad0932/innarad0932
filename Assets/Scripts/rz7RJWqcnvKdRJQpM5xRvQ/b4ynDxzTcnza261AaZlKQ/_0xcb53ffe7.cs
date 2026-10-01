using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xcb53ffe7
{
    public class _0x34be3882
    {
        private static readonly _0x34be3882 _0x155bceb6 = new();
        public static readonly _0x34be3882[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x155bceb6,
            _0x155bceb6,
            _0x155bceb6,
        };
        private int _0x26247c36 => 0;
        private int _0x4fe9c7ac => 10;
        private string _0xced63f55 => _0xa8e3b4ec._0x4232214c(new byte[4] { 87, 127, 116, 111 }, 26);
        private string _0x8f45bdc3 => _0xa8e3b4ec._0x4232214c(new byte[8] { 77, 68, 87, 68, 77, 122, 49, 124 }, 1);

        private int _0x5baded8b
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xa8e3b4ec._0x4232214c(new byte[25] { 64, 118, 113, 113, 102, 109, 119, 68, 111, 108, 97, 98, 111, 64, 107, 98, 115, 119, 102, 113, 74, 109, 103, 102, 123 }, 3)))
                    PlayerPrefs.SetInt(_0xa8e3b4ec._0x4232214c(new byte[25] { 99, 85, 82, 82, 69, 78, 84, 103, 76, 79, 66, 65, 76, 99, 72, 65, 80, 84, 69, 82, 105, 78, 68, 69, 88 }, 32), 0);
                return PlayerPrefs.GetInt(_0xa8e3b4ec._0x4232214c(new byte[25] { 43, 29, 26, 26, 13, 6, 28, 47, 4, 7, 10, 9, 4, 43, 0, 9, 24, 28, 13, 26, 33, 6, 12, 13, 16 }, 104));
            }

            set => PlayerPrefs.SetInt(_0xa8e3b4ec._0x4232214c(new byte[25] { 222, 232, 239, 239, 248, 243, 233, 218, 241, 242, 255, 252, 241, 222, 245, 252, 237, 233, 248, 239, 212, 243, 249, 248, 229 }, 157), value);
        }

        public int _0x8db918c9
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xced63f55}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xced63f55}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xced63f55}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xced63f55}CurrentLevelIndex", value);
        }

        public int _0xf709b24e
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xced63f55}BestScore"))
                    this._0xf709b24e = 0;
                return PlayerPrefs.GetInt($"{this._0xced63f55}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xced63f55}BestScore", value);
        }

        public bool _0xa6621840
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xced63f55}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xced63f55}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xced63f55}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xced63f55}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x8436a0ff
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x51899f64
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x60707aff
    {
        public static int _0x6f92c0dd
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xa8e3b4ec._0x4232214c(new byte[5] { 218, 246, 240, 247, 234 }, 153)))
                    PlayerPrefs.SetInt(_0xa8e3b4ec._0x4232214c(new byte[5] { 223, 243, 245, 242, 239 }, 156), 0);
                return PlayerPrefs.GetInt(_0xa8e3b4ec._0x4232214c(new byte[5] { 98, 78, 72, 79, 82 }, 33));
            }

            set
            {
                PlayerPrefs.SetInt(_0xa8e3b4ec._0x4232214c(new byte[5] { 166, 138, 140, 139, 150 }, 229), value);
                _0xbecc5006.Instance._0x934501b5();
            }
        }
    }

    public static class _0xd8635e47
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0xa8e3b4ec
{
    internal static string _0x4232214c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}