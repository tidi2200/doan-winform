using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using BAL;
using DAL;

namespace BAL
{
    public class BAL_DM_CHITIETHD
    {
        public bool Them(BEL_DM_CHITIETHD cthd)
        {
            try
            {
                DAL_DM_CHITIETHD objdal = new DAL_DM_CHITIETHD();
                return objdal.Them(cthd);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
