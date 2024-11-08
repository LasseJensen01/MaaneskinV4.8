using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context {
    internal class MaaneskinInitializer : DbContext{

        public class MaaneskinContext() : base("Maaneskin") {

    }
}
