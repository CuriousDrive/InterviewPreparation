using System;
using System.Collections.Generic;
using System.Text;

namespace TestDomePractice
{
    class InheritanceTest
    {
        public static void Main2(string[] args)
        {
            OptimizedDiskCache optimizedDiskCache = new OptimizedDiskCache();
            Cache cache = (Cache)optimizedDiskCache;
            DiskCache diskCache = (DiskCache)cache;
        }
    }

    public class Cache { }
    public class DiskCache : Cache { }
    public class MemoryCache : Cache { }
    public class OptimizedDiskCache : DiskCache { }
}
