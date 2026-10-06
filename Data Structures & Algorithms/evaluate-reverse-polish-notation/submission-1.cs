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

         st.Push(n1 + n2);
     }
     else if (token == "*")
     {
         int n1 = st.Pop();
         int n2 = st.Pop();


         st.Push(n1 * n2);
     }
     else if (token == "/")
     {
         int n1 = st.Pop();
         int n2 = st.Pop();

         st.Push(n2/n1);
     }
     else if (token == "-")
     {
         int n1 = st.Pop();
         int n2 = st.Pop();


         st.Push(n2-n1);
     }
 }

 return st.Peek();
    }
}
