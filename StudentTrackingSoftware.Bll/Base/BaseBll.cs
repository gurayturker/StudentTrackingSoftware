using StudentTrackingSoftware.Bll.Functions;
using StudentTrackingSoftware.Bll.Interfaces;
using StudentTrackingSoftware.Dal.Interfaces;
using StudentTrackingSoftware.Model.Entities.Base;
using StudentTrackinSoftware.Common.Enums;
using StudentTrackinSoftware.Common.Functions;
using StudentTrackinSoftware.Common.Message;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace StudentTrackingSoftware.Bll.Base
{
    public class BaseBll<T,TContext>:IBaseBll where T:BaseEntity where TContext:DbContext
  {
        private readonly Control _ctrl;
        private IUnitOfWork<T> _unitOfWork;

        protected  BaseBll(){}

        protected BaseBll(Control ctrl)
        {
            _ctrl = ctrl;
        }
        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Find(filter, selector);
        }
        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Select(filter, selector);
        }
        protected bool BaseInsert(BaseEntity entity,Expression<Func<T,bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            //validation
            _unitOfWork.Rep.Insert(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }
        protected bool BaseUpdate(BaseEntity oldEntity,BaseEntity currentEntity,Expression<Func<T,bool>>filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            //validation
            var changedFileds = oldEntity.GetChangedFields(currentEntity);
            if (changedFileds.Count == 0) return true;
            _unitOfWork.Rep.Update(currentEntity.EntityConvert<T>(),changedFileds);
            return _unitOfWork.Save();
        }  
        protected bool BaseDelete(BaseEntity entity,CardType cardType,bool messageShow = true)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            if (messageShow)

                if (Messages.DeleteMessage(cardType.ToName()) != DialogResult.Yes) return false;
            _unitOfWork.Rep.Delete(entity.EntityConvert<T>());
            return _unitOfWork.Save();

        }
        #region Dispose

     
        public void Dispose()
        {
            _ctrl?.Dispose();
            _unitOfWork?.Dispose();
           
        }
        #endregion
  }
}
