package com.test._242_validAnagram;

public class Solution {
    public boolean isAnagram(String s, String t) {
        int[] letters = new int[26];
        int length = s.length();
        if(length != t.length()) return false;
        for(int i = 0; i < length; i++)
        {
            letters[s.charAt(i) - 97] ++;
            letters[t.charAt(i) - 97] --;
        }
        for(int o : letters)
        {
            if(o != 0) return false;
        }
        return true;
    }
}
