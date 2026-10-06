public class Solution {
    public int EvalRPN(string[] tokens) {
         Stack<int> st = [];

 foreach (string token in tokens)
 {
     if (int.TryParse(token, out int num))
     {
         st.Push(num);
     }
     else if (token == "+")
     {
         int n1 = st.Pop();
         int n2 = st.Pop();

         int res = n1 + n2;

         st.Push(res);
     }
     else if (token == "*")
     {
         int n1 = st.Pop();
         int n2 = st.Pop();

         int res = n1 * n2;

         st.Push(res);
     }
     else if (token == "/")
     {
         int n1 = st.Pop();
         int n2 = st.Pop();

         int res = n2 / n1;

         st.Push(res);
     }
     else if (token == "-")
     {
         int n1 = st.Pop();
         int n2 = st.Pop();

         int res = n2 - n1;

         st.Push(res);
     }
 }

 return st.Peek();
    }
}
