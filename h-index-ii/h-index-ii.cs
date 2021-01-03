public class Solution {
    public int HIndex(int[] citations) {
        if(citations==null || citations.Length==0)
        {
            return 0;
        }
        
        int n = citations.Length;
        int low =0;
        int high = n-1;
        while(low<=high)
        {
            int mid = low + (high-low)/2;
            if(citations[mid]==n-mid)
            {
                return n-mid;
            }
            else if(citations[mid]>n-mid)
            {
                high = mid-1;
            }
            else
            {
                low = mid+1;
            }
            
        
        }
        return n-low;
}
}
