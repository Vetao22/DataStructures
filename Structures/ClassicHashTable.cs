using System.Net.Http.Headers;
using System.Collections.Generic;
using System;

namespace DataStructures.Structures
{
    public class ClassicHashTable
    {
        Dictionary<string, string> arr = new Dictionary<string, string>();

        public bool Add(string key, string value)
        {
            long hashValue = GetHash(key);

            if(!arr.ContainsKey(key))
            {
                arr.Add(key, value);
                return true;
            }
            return false;
        }

        public bool Remove(string key)
        {
            if(arr.ContainsKey(key))
            {
                arr.Remove(key);
                return true;
            }
            return false;
        }

        public string GetValue(string key)
        {
            if(arr.ContainsKey(key))
            {
                return arr[key];
            }
            return string.Empty;
        }

        public string GetKey(string value)
        {
            if(arr.ContainsValue(value))
            {
                foreach(string key in arr.Keys)
                {
                    if(GetValue(key) == value)
                    {
                        return key;
                    }
                }
            }
            return string.Empty;
        }

        
        long GetHash(string key)
        {
            key = key.ToLower();

            short p = 31;
            double m = 1e9 + 9;
            long hashValue = 0;
            long pow = 1;

            foreach(char c in key)
            {
                hashValue = (long)((hashValue + (c - 'a' + 1) * pow) % m);
                pow = (long)((pow * p) % m);
            }

            return hashValue;
        }
    
        public void Print()
        {
            foreach(string key in arr.Keys)
            {
                string value = GetValue(key);

                Console.WriteLine($"Key: {key}, Value: {value}");
            }
        }
    }
}