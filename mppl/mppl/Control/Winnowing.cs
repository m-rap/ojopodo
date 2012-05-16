using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            int window=4;
            int r=0, min=0;
            fingerprint = new List<int>();
            setHash(input,hash);
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
            input = input.Replace(" ", "");
            int prime = primeRollingHash(input.Trim(), 0, 4, 1000);
            string tempString;
            tempString = input.Substring(1, 5);
            for (int i = 0; tempString != null; i++)
            {
                prime = rollHashRight(prime, input, i - 1, i + 4, 1000);
                hash.Add(prime);
                if (i + 5 < input.Length)
                    tempString = input.Substring(i + 1, 5);
                else
                    tempString = null;
            }
        }
        static int primeRollingHash(String input, int start, int end, int mod = 1000000)
        {
            int acc = 0;
            for (int i = start; i <= end; i++)
            {
                char c = input[i];
                //acc = (acc*primeBase)%mod;
                acc += (c * (int)Math.Pow((double)101, (double)end - i) % mod);
            }
            return acc % mod;
        }
        public static int rollHashRight(int currentHashValue, String input,
                                        int start, int newEnd, int mod)
        {
            if (newEnd == input.Length)
                return currentHashValue;
            int length = newEnd - start - 1;
            int multiplier = 101;
            char newChar = input[newEnd];
            int firstValue = input[start];
            if (length > 0)
                firstValue = (firstValue * (int)Math.Pow((double)101, (double)length) % mod);
            return ((currentHashValue - firstValue) * multiplier + newChar) % mod;
        }
    }
}