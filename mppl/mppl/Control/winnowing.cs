using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace mppl.Control
{
    public class Winnowing
    {
        public static List<int> getFingerprint(string input)
        {
            List<int> fingerprint;
            List<int> hash;
            hash = new List<int>();
            int[] buffer;
            int counter = 0;
            int window=10;
            int r=0, min=0;
            fingerprint = new List<int>();
            setHash(input,hash);
            if (hash.Count < window)
                window = hash.Count;
            buffer = new int[window];
            for (int i = 0; i < window; i++) hash[i] = int.MaxValue;
            for(int i =0;i<window;i++)
            {
                buffer[r] = buffer[counter];
                if (buffer[r] < buffer[min])
                {
                    min = r;
                }
                r = (r + 1) % window;
                counter++;
            }
            fingerprint.Add(buffer[min]);
            while(counter<hash.Count)
            {
                
                    if (min == r)
                    {
                        for (int i = 0; i < window; i++)
                            if (buffer[i] < buffer[min]) min = i;
                        fingerprint.Add(buffer[min]);
                    }
                    else
                    {
                        if (buffer[r] < buffer[min])
                        {
                            min = r;
                            fingerprint.Add(buffer[min]);
                        }
                    }
                    counter++;
                    r = (r + 1) % window;
                    if (counter < hash.Count)
                        buffer[r] = hash[counter];
            }
            return fingerprint;
        }
        static void setHash(string input, List<int> hash)
        {
            Regex regexp = new Regex("[^a-zA-Z0-9]");
            input = regexp.Replace(input, "");
            int prime;
            if (input.Length >= 65)
            {
                prime = primeRollingHash(input.Trim(), 0, 64);
                hash.Add(prime);
                string tempString;
                tempString = input.Substring(1, 65);
                for (int i = 1; tempString != null; i++)
                {
                    prime = rollHashRight(prime, input, i - 1, i + 64);
                    hash.Add(prime);
                    if (i + 65 < input.Length)
                        tempString = input.Substring(i + 1, 65);
                    else
                        tempString = null;
                }
            }
            else
            {
                prime = primeRollingHash(input.Trim(), 0, input.Length - 1);
                hash.Add(prime);
            }
        }
        static int primeRollingHash(String input, int start, int end, int mod = 1000007)
        {
            int acc = 0;
            for (int i = start; i <= end; i++)
            {
                char c = input[i];
                //acc = (acc*primeBase)%mod;
                acc += (c * ((int)Math.Pow((double)101, (double)end - i) % mod)%mod);
            }
            if ((acc % mod) < 0)
                return (acc % mod) + mod;
            return acc % mod;
        }
        public static int rollHashRight(int currentHashValue, String input,
                                        int start, int newEnd, int mod=1000007)
        {
            if (newEnd == input.Length)
                return currentHashValue;
            int length = newEnd - start - 1;
            int multiplier = 101;
            char newChar = input[newEnd];
            int firstValue = input[start];
            if (length > 0)
            {
                double k = Math.Pow((double)101, (double)length);
                firstValue = (firstValue * ((int)Math.Pow((double)101, (double)length) % mod)%mod);
            }
            if (currentHashValue < firstValue)
                currentHashValue += mod;
            return ((currentHashValue - firstValue) * multiplier + newChar) % mod;
        }
    }
}