using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.XPath;

namespace netSchematron
{
    public static class XPathReservedFunction
    {
        public static Dictionary<string, Func<object, object>> FunctionList;

        static XPathReservedFunction()
        {
            FunctionList = new Dictionary<string, Func<object, object>>();
            FunctionList.Add("xs:date", XSDate);
            FunctionList.Add("number", Number);
            FunctionList.Add("current-date", CurrentDate);
            FunctionList.Add("matches", Matches);
            FunctionList.Add("normalize-space", NormalizeSpace);
            FunctionList.Add("exists", Exists);
            FunctionList.Add("distinct-values", DistinctValues);
            FunctionList.Add("count", Count);
            FunctionList.Add("sum", Sum);
            FunctionList.Add("starts-with", StartsWith);
            FunctionList.Add("contains", Contains);
            FunctionList.Add("max", Max);
            FunctionList.Add("string-length", StringLength);
            FunctionList.Add("xs:decimal", XSDecimal);
            FunctionList.Add("concat", Concat);
            FunctionList.Add("string", ToString);
            FunctionList.Add("name", Name);
            FunctionList.Add("substring", Substring);
            FunctionList.Add("ends-with", EndsWith);
        }

        private static string TrimAndNormalizeSpace(this string value)
        {
            char[] src = value.Trim().ToCharArray();
            int dstIdx = 0;
            bool lastWasWS = false;
            for (int i = 0; i < src.Length; i++)
            {
                char ch = src[i];
                if (src[i] == '\u0020')
                {
                    if (lastWasWS == false)
                    {
                        src[dstIdx++] = ch;
                        lastWasWS = true;
                    }
                }
                else
                {
                    lastWasWS = false;
                    src[dstIdx++] = ch;
                }
            }
            return new string(src, 0, dstIdx);
        }

        public static object GetFirstOrDefault(object value)
        {
            object result;
            List<XPathNavigator> list = value as List<XPathNavigator>;
            if (list == null)
            {
                result = value;
            }
            else if (list.Count > 0)
            {
                result = list.FirstOrDefault().Value;
            }
            else
            {
                result = null;
            }

            return result;
        }

        private static object XSDate(object parameterList)
        {
            DateTime dateTime;
            string value = GetFirstOrDefault(parameterList) as string ?? String.Empty;
            return DateTime.TryParse(value, out dateTime) ? dateTime : (DateTime?)null;
        }

        private static object Number(object parameterList)
        {
            double doubleValue;
            string value = GetFirstOrDefault(parameterList) as string;
            return Double.TryParse(value, out doubleValue) ? doubleValue : (double?)null;
        }

        private static object CurrentDate(object parameterList)
        {
            if (parameterList != null)
            {
                throw new Exception("SchematronExpressionHelper.CurrentDate argument is not as expected");
            }
            return DateTime.Now.ToString();
        }

        private static object Matches(object parameterList)
        {
            List<object> list = parameterList as List<object>;
            if (list == null || list.Count != 2)
            {
                throw new Exception("SchematronExpressionHelper.Matches argument is not as expected");
            }

            string first = GetFirstOrDefault(list[0]) as string ?? String.Empty;
            string second = GetFirstOrDefault(list[1]) as string ?? String.Empty;
            return Regex.IsMatch(first, second);
        }

        private static object NormalizeSpace(object parameterList)
        {
            string value = GetFirstOrDefault(parameterList) as string ?? String.Empty;
            return value.TrimAndNormalizeSpace();
        }

        private static object Exists(object parameterList)
        {
            List<XPathNavigator> list = parameterList as List<XPathNavigator>;
            if (list == null)
            {
                throw new Exception("SchematronExpressionHelper.DistinctValues argument is not as expected");
            }
            return list.Count >= 1;
        }

        private static object DistinctValues(object parameterList)
        {
            List<XPathNavigator> list = parameterList as List<XPathNavigator>;
            if (list == null)
            {
                throw new Exception("SchematronExpressionHelper.DistinctValues argument is not as expected");
            }

            List<string> keyList = new List<string>();
            List<XPathNavigator> valueList = new List<XPathNavigator>();

            list.ForEach(
                (item) => {
                    if (!keyList.Contains(item.Value))
                    {
                        keyList.Add(item.Value);
                        valueList.Add(item);
                    }
                }
            );

            return valueList;
        }

        private static object Count(object parameterList)
        {
            List<XPathNavigator> list = parameterList as List<XPathNavigator>;
            if (list == null)
            {
                throw new Exception("SchematronExpressionHelper.Count argument is not as expected");
            }
            return (double)list.Count;
        }

        private static object Sum(object parameterList)
        {
            List<XPathNavigator> list = parameterList as List<XPathNavigator>;
            if (list == null)
            {
                throw new Exception("SchematronExpressionHelper.Sum argument is not as expected");
            }
            return list.Sum(item => item.ValueAsDouble);
        }

        private static object StartsWith(object parameterList)
        {
            List<object> list = parameterList as List<object>;
            if (list == null || list.Count != 2)
            {
                throw new Exception("SchematronExpressionHelper.StartsWith argument is not as expected");
            }
            string first = GetFirstOrDefault(list[0]) as string ?? String.Empty;
            string second = GetFirstOrDefault(list[1]) as string ?? String.Empty;
            return first.StartsWith(second);
        }

        private static object Contains(object parameterList)
        {
            List<object> list = parameterList as List<object>;
            if (list == null || list.Count != 2)
            {
                throw new Exception("SchematronExpressionHelper.Contains argument is not as expected");
            }
            string first = GetFirstOrDefault(list[0]) as string ?? String.Empty;
            string second = GetFirstOrDefault(list[1]) as string ?? String.Empty;
            return first.Contains(second);
        }

        private static object Max(object parameterList)
        {
            double? result = null;
            List<XPathNavigator> list = parameterList as List<XPathNavigator>;
            if (list == null)
            {
                throw new Exception("SchematronExpressionHelper.Max argument is not as expected");
            }
            else if (list.Count > 0)
            {
                result = list.Max(item => item.ValueAsDouble);
            }
            return result;
        }

        private static object StringLength(object parameterList)
        {
            string value = GetFirstOrDefault(parameterList) as string ?? String.Empty;
            return value.Length;
        }

        private static object XSDecimal(object parameterList)
        {
            double doubleValue;
            string value = GetFirstOrDefault(parameterList) as string;
            return Double.TryParse(value, out doubleValue) ? doubleValue : (double?)null;
        }

        private static object Concat(object parameterList)
        {
            List<object> list = parameterList as List<object>;
            if (list == null || list.Count < 2)
            {
                throw new Exception("SchematronExpressionHelper.Concat argument is not as expected");
            }

            string result = String.Empty;
            foreach (object value in list)
            {
                string asString = GetFirstOrDefault(value) as string ?? String.Empty;
                result += asString;
            }
            return result;
        }

        private static object ToString(object parameterList)
        {
            string value = GetFirstOrDefault(parameterList)?.ToString() ?? String.Empty;
            return value;
        }

        private static object Name(object parameterList)
        {
            string value = String.Empty;
            List<XPathNavigator> list = parameterList as List<XPathNavigator>;
            if (list == null)
            {
                throw new Exception("SchematronExpressionHelper.Name argument is not as expected");
            }

            value = list.FirstOrDefault().Name;
            return value;
        }

        private static object Substring(object parameterList)
        {
            string value = String.Empty;
            List<object> list = parameterList as List<object>;
            if (list == null || list.Count < 2)
            {
                throw new Exception("SchematronExpressionHelper.Substring argument is not as expected");
            }
            else if (list.Count == 2)
            {
                string first = GetFirstOrDefault(list[0]) as string ?? String.Empty;
                double second = (double)GetFirstOrDefault(list[1]);

                value = first.Substring((int)second - 1);
            }
            else if (list.Count == 3)
            {
                string first = GetFirstOrDefault(list[0]) as string ?? String.Empty;
                double second = (double)GetFirstOrDefault(list[1]);
                double third = (double)GetFirstOrDefault(list[2]);

                value = first.Substring((int)second - 1, (int)third);
            }

            return value;
        }

        private static object EndsWith(object parameterList)
        {
            bool value = false;
            List<object> list = parameterList as List<object>;
            if (list == null || list.Count < 2)
            {
                throw new Exception("SchematronExpressionHelper.Substring argument is not as expected");
            }
            else if (list.Count == 2)
            {
                string first = GetFirstOrDefault(list[0]) as string ?? String.Empty;
                string second = GetFirstOrDefault(list[1]) as string ?? String.Empty;

                value = first.EndsWith(second);
            }
            // else if (list.Count == 3) it has three arguments version
            // {
            // }

            return value;
        }
    }
}