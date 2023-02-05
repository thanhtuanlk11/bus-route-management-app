using BusinessLayer.DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HRFunctions : BaseFunctions
    {
        private static HRFunctions instance = null;
        public static HRFunctions Instance
        {
            get
            {
                if (instance == null)
                    instance = new HRFunctions();
                return instance;
            }
        }

        public ReflectType GetReflectTypeByID(int id)
        {
            return ReflectTypeExt.Instance.ReflectType_Select_ID(id);
        }

        public List<Reflect> SelectAllReflect()
        {
            //Ghi loc, kiem tra quyen, kiem du lieu co hop le khong?
            return ReflectExt.Instance.Reflect_Select_All();
        }

        public List<Reflect> SearchReflectCriteria(string multiColumn, int pageSize, int pageIndex, out int total)
        {
            return ReflectExt.Instance.Reflect_Find_KeyWord(multiColumn, pageSize, pageIndex, out total);
        }

        public List<ReflectType> SearchReflectTypeByCrieria(string multiColumn, int pageSize, int pageIndex, out int total)
        {
            return ReflectTypeExt.Instance.ReflectType_Find_KeyWord(multiColumn, pageIndex, pageSize, out total);
        }

        public List<ReflectType> SelectAllReflectType()
        {
            //Ghi loc, kiem tra quyen, kiem du lieu co hop le khong?
            return ReflectTypeExt.Instance.ReflectType_Select_All();
        }

        public void AddReflect(object reflect)
        {
            throw new NotImplementedException();
        }

        public int InsertUpdateReflectType(int id, string name)
        {
            ReflectType reflectType;
            reflectType = new ReflectType
            {
                ReflectTypeID = id,
                Name = name,
               
            };
            return ReflectTypeExt.Instance.ReflectType_InsertUpdate(reflectType);
        }


        public int AddReflect(Reflect reflect)
        {
            return ReflectExt.Instance.Reflect_InsertUpdate(reflect);
        }

        public Reflect FindReflectByID(int id)
        {
            return ReflectExt.Instance.Reflect_Select_ID(id);
        }

        public ReflectType FindReflectTypeByID(int id)
        {
            return ReflectTypeExt.Instance.ReflectType_Select_ID(id);
        }

        public ReflectType SelectReflectTypeByIDs(int id)
        {
            return ReflectTypeExt.Instance.ReflectType_Select_ID(id);
        }

        public void DeleteReflectType(int id)
        {
            ReflectTypeExt.Instance.ReflectType_Delete(id);
        }

        public void DeleteReflectTypeIDs(List<string> ids)
        {
            ReflectTypeExt.Instance.ReflectType_Delete_IDs(ids);
        }

        public void DeleteReflectByID(int id)
        {
            ReflectExt.Instance.Reflect_Delete(id);
        }

        public List<Reflect> Reflect_Pagination(int PageSize, int PageIndex, out int TotalRows)
        {
            return ReflectExt.Instance.Reflect_Pagination(PageSize, PageIndex, out TotalRows);
        }

        public List<ReflectType> Reflect_Type_Pagination(int PageSize, int PageIndex, out int TotalRows)
        {
            return ReflectTypeExt.Instance.ReflectType_Pagination(PageSize, PageIndex, out TotalRows);
        }

        public int Get_Reflect_Total_Row()
        {
            return ReflectExt.Instance.Get_Total_Rows();
        }
        public void DeleteReflectByIDs(List<string> list)
        {
            ReflectExt.Instance.Reflect_Delete_IDs(list);
        }
        public void DeleteReflect (int id)
        {
            ReflectExt.Instance.Reflect_Delete(id);
        }

        public Reflect FindBusByTitle(string tieude)
        {
            return ReflectExt.Instance.Reflect_Select_Title(tieude);
        }
        public List<Reflect> Reflect_Find_KeyWord ( int PageSize, int PageIndex, out int TotalRows)
        {
            return ReflectExt.Instance.Reflect_Find_KeyWord("", PageSize, PageIndex, out TotalRows);
        } 
        public List<ReflectType> Reflect_Find_Type_KeyWord(int PageSize, int PageIndex, out int TotalRows)
        {
            return ReflectTypeExt.Instance.ReflectType_Find_KeyWord("", PageSize, PageIndex, out TotalRows);
        }

        public ReflectType FindBusTypeByReflectTypeNameAndCarMarker(string Reflecttypename)
        {
            return ReflectTypeExt.Instance.ReflectType_Select_ReflectTypeName(Reflecttypename);
        }
       
    }
}