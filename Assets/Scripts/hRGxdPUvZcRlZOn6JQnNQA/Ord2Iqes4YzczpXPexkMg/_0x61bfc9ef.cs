using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x61bfc9ef : MonoBehaviour
{
    private void _0xa7228022()
    {
        if (this.ScoreCurrent > _0xbecc5006._0x07e12f3a._0xf709b24e)
            _0xbecc5006._0x07e12f3a._0xf709b24e = this.ScoreCurrent;
        if (_0x921a4263.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x73484f9d)
                this._0x3fb5a885();
    }

    [HideInInspector]
    public int TimeLeft;
    public List<TMP_Text> LevelNumberText = new();
    [HideInInspector]
    public int CurrentGameIndex;
    public void _0xbb87e32d(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xac52ab98();
            this._0xa7228022();
        }
    }

    private static _0x61bfc9ef _0x234bd8d7;
    [HideInInspector]
    public int ScoreCurrent;
    public List<TMP_Text> ScoreText = new();
    public void _0x3fb5a885()
    {
        if (!this.IsGameEnd)
        {
            this._0xee53d9c0();
            _0xbecc5006.IsAfterLevelComplete = true;
            _0xbecc5006.IsAfterLevelFailed = false;
            _0x673f471c _0x6528970a = _0xf905b1bd.Instance._0x399c969a(_0xcb53ffe7._0x8436a0ff.WIN).GetComponent<_0x673f471c>();
            if (_0x921a4263.Instance.IsCheckScoreEnabled)
                _0x6528970a.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x73484f9d}";
            else
                _0x6528970a.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x921a4263.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xcb53ffe7._0x60707aff._0x6f92c0dd)
                    _0xcb53ffe7._0x60707aff._0x6f92c0dd = this.ScoreCurrent;
                _0x6528970a.ContentAdditionalText.text = $"{_0xcb53ffe7._0x60707aff._0x6f92c0dd}";
            }
            else
            {
                _0x6528970a.ContentAdditionalText.text = $"{this._0x26f52039}";
                _0xcb53ffe7._0x60707aff._0x6f92c0dd += this._0x26f52039;
            }

            if (_0x921a4263.Instance.IsLevelIncrementOnWin)
                ++_0xbecc5006._0x07e12f3a._0x8db918c9;
            _0xf905b1bd.Instance._0x6698f986(_0xcb53ffe7._0x8436a0ff.WIN);
        }
    }

    private void _0x5bcd8288()
    {
        if (this.ScoreCurrent >= this._0x73484f9d)
            this._0x3fb5a885();
        else
            this._0x042937af();
    }

    private void _0xa988193e()
    {
        this.TimerText.ForEach(_0x1f546bc6 => _0x1f546bc6.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xa06a34d2._0x67170f41(new byte[6] { 88, 88, 105, 15, 70, 70 }, 53)));
    }

    public void _0x52340454()
    {
        _0xbecc5006.Instance._0x217d0da4(true);
        _0xbecc5006.Instance.LoadSceneByIndex(_0xcb53ffe7._0xd8635e47.SCENE_0);
    }

    public int CustomTargetScore = 10;
    [HideInInspector]
    public bool IsGameEnd;
    private int _0x26f52039 => this.ScoreCurrent;

    private IEnumerator _0x6cc75c70()
    {
        this._0xa988193e();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xbecc5006.Instance._0xc3eb6597 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xbecc5006.Instance._0xfe7dd6e9)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xa988193e();
            }
        }

        if (!this.IsGameEnd)
            this._0x042937af();
    }

    public List<TMP_Text> TimerText = new();
    private int _0x73484f9d => this.CustomTargetScore + _0xbecc5006._0x07e12f3a._0x8db918c9 * 10;

    private void Awake()
    {
        _0x234bd8d7 = this.gameObject.GetComponent<_0x61bfc9ef>();
    }

    public List<Button> PauseButtons = new();
    public void _0x042937af()
    {
        if (_0x921a4263.Instance.IsOnlyWinGameEndEnabled)
            this._0x3fb5a885();
        if (!this.IsGameEnd)
        {
            this._0xee53d9c0();
            _0xbecc5006.IsAfterLevelComplete = false;
            _0xbecc5006.IsAfterLevelFailed = true;
            _0x673f471c _0x5a2c3094 = _0xf905b1bd.Instance._0x399c969a(_0xcb53ffe7._0x8436a0ff.LOSE).GetComponent<_0x673f471c>();
            if (_0x921a4263.Instance.IsCheckScoreEnabled)
                _0x5a2c3094.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x73484f9d}";
            else
                _0x5a2c3094.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x5a2c3094.ContentAdditionalText.text = $"{0}";
            _0xcb53ffe7._0x60707aff._0x6f92c0dd += 0;
            _0xf905b1bd.Instance._0x6698f986(_0xcb53ffe7._0x8436a0ff.LOSE);
        }
    }

    private void _0xac52ab98()
    {
        if (_0x921a4263.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x1f546bc6 => _0x1f546bc6.text = $"{this.ScoreCurrent}/{this._0x73484f9d}");
        else
            this.ScoreText.ForEach(_0x1f546bc6 => _0x1f546bc6.text = $"{this.ScoreCurrent}");
    }

    public int CustomTimeInitial = 30;
    public List<TMP_Text> SubtitleText = new();
    private void _0xee53d9c0()
    {
        this.IsGameEnd = true;
        _0xbecc5006.IsAfterLevelComplete = true;
    }

    public List<Button> HomeButtons = new();
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x34684be3;
        this.CurrentGameIndex = _0xbecc5006.Instance._0xc3eb6597;
        foreach (Button _0x02dc8d3c in this.HomeButtons)
            _0x02dc8d3c.onClick.AddListener(() =>
            {
                this._0x52340454();
            });
        foreach (Button _0x77d227f9 in this.PauseButtons)
            _0x77d227f9.onClick.AddListener(() =>
            {
                _0xbecc5006.Instance._0x217d0da4(false);
                _0xf905b1bd.Instance._0x6698f986(_0xcb53ffe7._0x8436a0ff.PAUSE);
            });
        this._0xac52ab98();
        this.LevelNumberText.ForEach(_0x1f546bc6 => _0x1f546bc6.text = $"LVL {_0xbecc5006._0x07e12f3a._0x8db918c9 + 1}");
        if (_0x921a4263.Instance.IsTimerEnabled)
        {
            this._0xa988193e();
            this.StartCoroutine(this._0x6cc75c70());
        }
    }

    private int _0x34684be3 => this.CustomTimeInitial + _0xbecc5006._0x07e12f3a._0x8db918c9 * 10;
}

internal static class _0xa06a34d2
{
    internal static string _0x67170f41(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}