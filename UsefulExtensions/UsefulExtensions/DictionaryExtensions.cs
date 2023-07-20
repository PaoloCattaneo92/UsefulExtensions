using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace PaoloCattaneo.UsefulExtensions;

public static class DictionaryExtensions
{
    public static V? Get<K, V>(this Dictionary<K, V> dictionary, K key) where K : notnull
    {
        if(dictionary == null)
        {
            return default;
        }

        if(!dictionary.TryGetValue(key, out var found))
        {
            return default;
        }

        return found;
    }

    public static void Set<K, V>(this Dictionary<K, V> dictionary, K key, V value) where K : notnull
    {
        if (dictionary == null)
        {
            throw new ArgumentNullException(nameof(dictionary));
        }

        if (dictionary.ContainsKey(key))
        {
            dictionary[key] = value;
            return;
        }

        dictionary.Add(key, value);
    }

    public static void Set<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> keyValuePair) where TKey : notnull
    {
        dictionary.Set(keyValuePair.Key, keyValuePair.Value);
    }
}
