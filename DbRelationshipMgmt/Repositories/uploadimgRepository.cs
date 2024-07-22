using DbRelationshipMgmt.Data;
using DbRelationshipMgmt.Interface;
using DbRelationshipMgmt.Models;

namespace DbRelationshipMgmt.Repositories
{
    public class uploadimgRepository : Iuploadimg
    {
        private readonly MyAppDbContext _myAppDbContext;

        public uploadimgRepository(MyAppDbContext myAppDbContext)
        {
            _myAppDbContext = myAppDbContext;
        }

        public Iuploadimg Addimg(Iuploadimg iuploadimg, byte[] imagebytes)
        {
            _myAppDbContext.Add(new uploadimg() { photo = imagebytes });
            _myAppDbContext.SaveChanges();
            return iuploadimg;
        }
    }
}
