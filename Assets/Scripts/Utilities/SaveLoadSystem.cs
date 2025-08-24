using System;
using System.Text;
using UnityEngine;

public static class SaveLoadSystem
{
    public static string EncryptDecrypt(string data, string key)
    {
        byte[] dataBytes = Encoding.UTF8.GetBytes(data);
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        byte[] result = new byte[dataBytes.Length];

        for (int i = 0; i < dataBytes.Length; ++i)
        {
            result[i] = (byte)(dataBytes[i] ^ keyBytes[i % keyBytes.Length]);
        }

        return Convert.ToBase64String(result);
    }

    public static string Decrypt(string encryptedBase64, string key)
    {
        byte[] encryptedBytes = Convert.FromBase64String(encryptedBase64);
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        byte[] result = new byte[encryptedBytes.Length];

        for (int i = 0; i < encryptedBytes.Length; ++i)
        {
            result[i] = (byte)(encryptedBytes[i] ^ keyBytes[i % keyBytes.Length]);
        }

        return Encoding.UTF8.GetString(result);
    }

    public static void SaveJson<PlayerData>(string prefsKey, PlayerData data, string xorKey)
    {
        string json = JsonUtility.ToJson(data);
        string encrypted = EncryptDecrypt(json, xorKey);
        PlayerPrefs.SetString(prefsKey, encrypted);
        PlayerPrefs.Save();
    }

    public static PlayerData LoadJson<PlayerData>(string prefsKey, string xorKey) where PlayerData : new()
    {
        if (!PlayerPrefs.HasKey(prefsKey))
            return new PlayerData();

        string encrypted = PlayerPrefs.GetString(prefsKey);
        string decryptedJson = Decrypt(encrypted, xorKey);

        return JsonUtility.FromJson<PlayerData>(decryptedJson);
    }
}
