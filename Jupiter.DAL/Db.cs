using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.DAL
{
   public class Db
    {
        private Db() { }
        private static JupiterDBContext _context;
        public static JupiterDBContext Context
        {
            get
            {
                if(_context==null)
                {
                    _context = new JupiterDBContext();
                }
                return _context;
            }

        }
    }
}
