namespace Top_Interview_150.Stack;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        List<char> open = ['(', '[', '{'];
        List<char> close = [')', ']', '}'];

        var stack = new Stack<char>();
        foreach (var item in s)
        {
            if (open.Contains(item))
            {
                stack.Push(item);
            }
            if (close.Contains(item))
            {
                if (stack.Count == 0)
                    return false;
                var top=stack.Pop();
                if(open.IndexOf(top) != close.IndexOf(item))
                    return false;
            }
        }
        return stack.Count == 0;
    }
}