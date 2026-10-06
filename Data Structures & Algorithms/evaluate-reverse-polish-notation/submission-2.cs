public class Solution {
    public int EvalRPN(string[] tokens) {
         Stack<int> st = [];

 foreach (string token in tokens)
 {
    
     if (token == "+")
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
     else 
     {
         st.Push(int.Parse(token));
     }
 }

 return st.Peek();
    }
}
