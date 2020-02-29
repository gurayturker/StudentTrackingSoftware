using StudentTrackingSoftware.Dal.Interfaces;
using StudentTrackinSoftware.Common.Message;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTrackingSoftware.Dal.Base
{
    public class UnitOfWork<T> : IUnitOfWork<T>  where T : class
    {
        private readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            if (context == null) return;
            _context = context;

        }
        public IRepository<T> Rep => new Repository<T>(_context);

        public bool Save()
        {
            try
            {
                _context.SaveChanges();

            }
            catch (DbUpdateException ex)
            {

                var sqlEx = (SqlException)ex.InnerException?.InnerException;
                if (sqlEx == null)
                {
                    Messages.ErrorMessage(ex.Message);
                    return false;
                }
                switch (sqlEx.Number)
                {
                    case 208:
                        Messages.ErrorMessage("The table you want to process was not found in the database.");
                        break;
                    case 547:
                        Messages.ErrorMessage("Selected card have traded .This card cannot be delete.");
                        break;
                    case 2601:
                    case 2627:
                        Messages.ErrorMessage("The data you entered  has been used before.");
                        break;
                    case 4060:
                        Messages.ErrorMessage("The database you want to process was not found.");
                        break;
                    case 18456:
                        Messages.ErrorMessage("The username or password you want to connect to the server is incorrect.");
                        break;
                    default:
                        Messages.ErrorMessage(sqlEx.Message);
                        break;
                }
                return false;
            }
            catch (Exception ex)
            {
                Messages.ErrorMessage(ex.Message);
                return false;
            }
            return true;
        }

        #region Dispose
        private bool _isposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!_isposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

               

                _isposedValue = true;
            }
        }

     
        public void Dispose()
        {
            
            Dispose(true);
            GC.SuppressFinalize(this);
           
        }
        #endregion
    }
}
