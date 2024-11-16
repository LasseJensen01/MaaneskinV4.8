using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DTO.Models {
    public static class IDIncrementClass {
        private static int lastID = 1;

        public static int GenerateID() {
            return Interlocked.Increment(ref lastID);
        }
    }
}
