using System;
using System.Collections.Generic;
using System.Text;

namespace Eventualist.Extensions.Collections
{
    public class ExtendedDictionary<K,V>:Dictionary<K,V>
    {
        public V this[K key, V defaultValue]
        {
            set
            {
                base[key] = value;
            }
            get
            {
                if (!this.ContainsKey(key))
                {
                    return defaultValue;
                }

                return this[key];
            }
        }

        public V this[K key]
        {
            set
            {
                base[key] = value;
            }
            get
            {
                if (!this.ContainsKey(key))
                {
                    return default(V);
                }

                return base[key];
            }
        }
    }
}
