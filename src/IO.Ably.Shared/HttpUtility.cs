﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IO.Ably
{
    using kvp = KeyValuePair<string, string>;

    public sealed class HttpUtility
    {
        public static HttpValueCollection ParseQueryString(string query)
        {
            if (query == null)
            {
                throw new ArgumentNullException("query");
            }

            if ((query.Length > 0) && (query[0] == '?'))
            {
                query = query.Substring(1);
            }

            return new HttpValueCollection(query, true);
        }
    }

    public class HttpValueCollection
    {
        public IEnumerable<string> AllKeys
        {
            get { return _data.Select(i => i.Key); }
        }

        private readonly List<kvp> _data = new List<kvp>();

        public string this[string name]
        {
            get
            {
                string[] items = GetValues(name);
                if (items == null)
                {
                    return null;
                }

                return string.Join(",", items);
            }

            set
            {
                // If the specified key already exists in the collection, setting this property overwrites the existing list of values with the specified value.
                _data.RemoveAll(i => i.Key == name);
                _data.Add(new kvp(name, value));
            }
        }

        public string[] GetValues(string name)
        {
            string[] res = _data.Where(i => i.Key == name).Select(i => i.Value).ToArray();
            if (res.Length <= 0)
            {
                return null;
            }

            return res;
        }

        public void Add(string name, string value)
        {
            _data.Add(new kvp(name, value));
        }

        public HttpValueCollection() { }

        public HttpValueCollection(string query)
            : this(query, true) { }

        public HttpValueCollection(string query, bool urlencoded)
        {
            if (!string.IsNullOrEmpty(query))
            {
                FillFromString(query, urlencoded);
            }
        }

        private void FillFromString(string query, bool urlencoded)
        {
            // http://stackoverflow.com/a/20284635/126995
            int num = (query != null) ? query.Length : 0;
            for (int i = 0; i < num; i++)
            {
                int startIndex = i;
                int num4 = -1;
                while (i < num)
                {
                    char ch = query[i];
                    if (ch == '=')
                    {
                        if (num4 < 0)
                        {
                            num4 = i;
                        }
                    }
                    else if (ch == '&')
                    {
                        break;
                    }

                    i++;
                }

                string str = null;
                string str2 = null;
                if (num4 >= 0)
                {
                    str = query.Substring(startIndex, num4 - startIndex);
                    str2 = query.Substring(num4 + 1, (i - num4) - 1);
                }
                else
                {
                    str2 = query.Substring(startIndex, i - startIndex);
                }

                if (urlencoded)
                {
                    Add(Uri.UnescapeDataString(str), Uri.UnescapeDataString(str2));
                }
                else
                {
                    Add(str, str2);
                }

                if ((i == (num - 1)) && (query[i] == '&'))
                {
                    Add(null, string.Empty);
                }
            }
        }

        /// <summary>
        /// For internal testing only.
        /// This method does not URL encode and should be considered unsafe for general use.
        /// </summary>
        internal string ToQueryString()
        {
            var n = _data.Count;
            if (n == 0)
            {
                return string.Empty;
            }

            var s = new StringBuilder();

            foreach (var k in AllKeys)
            {
                var key = k;
                var keyPrefix = (key != null) ? (key + "=") : string.Empty;

                var values = GetValues(key);
                if (s.Length > 0)
                {
                    s.Append('&');
                }

                if (values == null || values.Length == 0)
                {
                    s.Append(keyPrefix);
                }
                else
                {
                    string item;
                    if (values.Length == 1)
                    {
                        s.Append(keyPrefix);
                        item = values[0];
                        s.Append(item);
                    }
                    else
                    {
                        for (var j = 0; j < values.Length; j++)
                        {
                            if (j > 0)
                            {
                                s.Append('&');
                            }

                            s.Append(keyPrefix);
                            item = values[j];

                            s.Append(item);
                        }
                    }
                }
            }

            return s.ToString();
        }
    }
}
