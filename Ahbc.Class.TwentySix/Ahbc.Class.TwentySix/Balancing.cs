using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.TwentySix
{
    public static class Braces
    {

        /// <summary>
        /// Checks if a string of ONLY braces, ie. "(([][]))" or "{}{}(([]))"
        /// is balanced, in other words, if a open brace matches a closed brace.
        /// </summary>
        /// <param name="braces"></param>
        /// <returns></returns>
        public static bool IsBalanced(string braces)
        {
            var braceStack = new Stack<char>();

            foreach (var brace in braces)
            {
                if (brace == '(')
                {
                    braceStack.Push(brace);
                    continue;
                }

                if (brace == '[')
                {
                    braceStack.Push(brace);
                    continue;
                }

                if (brace == '{')
                {
                    braceStack.Push(brace);
                    continue;
                }

                if (brace == ')')
                {
                    if (braceStack.Any() && braceStack.Peek() == '(')
                    {
                        braceStack.Pop();
                        continue;
                    }
                    return false;
                }

                if (brace == ']')
                {
                    if (braceStack.Any() && braceStack.Peek() == '[')
                    {
                        braceStack.Pop();
                        continue;
                    }
                    return false;
                }

                if (brace == '}')
                {
                    if (braceStack.Any() && braceStack.Peek() == '{')
                    {
                        braceStack.Pop();
                        continue;
                    }
                    return false;
                }

                return false;
            }

            if (braceStack.Any())
            {
                return false;
            }

            return true;
        }
    }
}
