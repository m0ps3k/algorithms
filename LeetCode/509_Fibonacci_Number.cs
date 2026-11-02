public class Solution {
    public int Fib(int n) {
        if (n == 0) return 0;
        if (n == 1) return 1;
        var res1 = Fib(n - 1);
        var res2 = Fib(n - 2);
        return res1 + res2;
    }
}