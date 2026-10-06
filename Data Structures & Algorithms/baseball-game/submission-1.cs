public class Solution {
    public int CalPoints(string[] operations) {
           Stack<int> st = [];

 foreach (string op in operations)
 {
     if (int.TryParse(op,out int num))
     {
         st.Push(num);
     }

     if (op[0] == '+')
     {
         int n1 = st.Pop();
         int n2 = st.Peek();
         st.Push(n1);

         st.Push(n1 + n2);
     }

     if (op[0] == 'C')
     {
         st.Pop();
     }

     if (op[0] == 'D')
     {
         int number = st.Peek();

         st.Push(number * 2);
     }


 }

 return st.Sum();
    }
}