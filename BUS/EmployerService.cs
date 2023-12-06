using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class EmployerService
    {
        public List<Employer> GetAll()
        {
            try
            {
                var employers = new List<Employer>();

                using (DBContext db = new DBContext())
                {
                    employers = db.Employers.ToList();
                }

                if (employers == null)
                {
                    throw new Exception("Employer in database is null");
                }

                return employers.Where(x => x.is__delete == 0).ToList();
            }catch(Exception ex)
            {
                throw new Exception("Erorr where is: " + ex.Message);
            }
        }
    }
}
