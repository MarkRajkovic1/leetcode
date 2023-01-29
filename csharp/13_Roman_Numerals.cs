public class Solution {
    public int dictionary(char c){
        switch(c){
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
    public int RomanToInt(string s) {
        int sum = 0;
        int length = s.Length;
        for (int i=0;i<length-1;i++){
            int letter = dictionary(s[i]);
            if (letter < dictionary(s[i+1])){
               sum-= letter;
            }  else {
                sum+=letter; 
            }
        }
        return sum+dictionary(s[length-1]);
    }
}
